using Microsoft.EntityFrameworkCore;
using UangKu.Data;
using UangKu.Models;

namespace UangKu.Services;

public sealed class DashboardStats
{
    public decimal transactionBalance { get; set; }
    public decimal targetBalance { get; set; }
    public decimal totalBalance { get; set; }
    public decimal totalIncome { get; set; }
    public decimal totalExpense { get; set; }
    public Target? primaryTarget { get; set; }
}

public sealed class Service(Func<AppDbContext>? contextFactory = null)
{
    private readonly Func<AppDbContext> _contextFactory = contextFactory ?? Db.CreateContext;

    private AppDbContext CreateContext() => _contextFactory();

    public async Task<List<Wallet>> GetWalletsAsync(CancellationToken cancellationToken = default)
    {
        await using var context = CreateContext();
        return await context.Wallets
            .AsNoTracking()
            .OrderBy(w => w.id)
            .ToListAsync(cancellationToken);
    }

    public async Task<List<Target>> GetTargetsAsync(CancellationToken cancellationToken = default)
    {
        await using var context = CreateContext();
        return await context.Targets
            .AsNoTracking()
            .OrderByDescending(t => t.createdAt)
            .ThenByDescending(t => t.id)
            .ToListAsync(cancellationToken);
    }

    public async Task<List<Target>> GetActiveTargetsAsync(CancellationToken cancellationToken = default)
    {
        await using var context = CreateContext();
        return await context.Targets
            .AsNoTracking()
            .Where(t => t.status != "complete" && t.currentAmount < t.targetAmount)
            .OrderByDescending(t => t.createdAt)
            .ThenByDescending(t => t.id)
            .ToListAsync(cancellationToken);
    }

    public async Task<List<TransactionsRecord>> GetTransactionsAsync(int limit = 250, CancellationToken cancellationToken = default)
    {
        await using var context = CreateContext();
        var records = await context.Transactions
            .AsNoTracking()
            .OrderByDescending(tr => tr.transactionAt)
            .ThenByDescending(tr => tr.id)
            .Take(limit)
            .Select(tr => new TransactionsRecord
            {
                id = tr.id,
                transactionAt = tr.transactionAt,
                type = tr.type,
                amount = tr.amount,
                walletName = tr.wallet != null ? tr.wallet.name : "",
                targetName = tr.target != null ? tr.target.name : null,
                note = tr.note
            })
            .ToListAsync(cancellationToken);

        foreach (var record in records)
        {
            record.transactionAt = record.transactionAt.ToLocalTime();
        }

        return records;
    }

    public async Task<List<TransactionsRecord>> GetFilteredTransactionsAsync(
        string? jenis = null,
        string? dompet = null,
        string? periode = null,
        int limit = 250,
        CancellationToken cancellationToken = default)
    {
        await using var context = CreateContext();
        IQueryable<Transactions> query = context.Transactions.AsNoTracking();

        if (!string.IsNullOrWhiteSpace(jenis) && jenis != "Semua Jenis")
        {
            if (jenis.Equals("Pemasukan", StringComparison.OrdinalIgnoreCase))
                query = query.Where(t => t.type == "income");
            else if (jenis.Equals("Pengeluaran", StringComparison.OrdinalIgnoreCase))
                query = query.Where(t => t.type == "expense");
        }

        if (!string.IsNullOrWhiteSpace(dompet) && dompet != "Semua Dompet")
        {
            if (dompet.Equals("Dompet Transaksi", StringComparison.OrdinalIgnoreCase))
                query = query.Where(t => t.targetId == null);
            else if (dompet.Equals("Dompet Target", StringComparison.OrdinalIgnoreCase))
                query = query.Where(t => t.targetId != null);
        }

        if (!string.IsNullOrWhiteSpace(periode) && periode != "Semua")
        {
            DateTime? cutoff = periode.ToLowerInvariant() switch
            {
                "minggu" => DateTime.UtcNow.AddDays(-7),
                "bulan" => DateTime.UtcNow.AddDays(-30),
                "tahun" => DateTime.UtcNow.AddYears(-1),
                _ => null
            };

            if (cutoff.HasValue)
            {
                query = query.Where(t => t.transactionAt >= cutoff.Value);
            }
        }

        var records = await query
            .OrderByDescending(t => t.transactionAt)
            .ThenByDescending(t => t.id)
            .Take(limit)
            .Select(tr => new TransactionsRecord
            {
                id = tr.id,
                transactionAt = tr.transactionAt,
                type = tr.type,
                amount = tr.amount,
                walletName = tr.wallet != null ? tr.wallet.name : "",
                targetName = tr.target != null ? tr.target.name : null,
                note = tr.note
            })
            .ToListAsync(cancellationToken);

        foreach (var record in records)
        {
            record.transactionAt = record.transactionAt.ToLocalTime();
        }

        return records;
    }

    public async Task<DashboardStats> GetStatsAsync(CancellationToken cancellationToken = default)
    {
        await using var context = CreateContext();

        var wallets = await context.Wallets
            .AsNoTracking()
            .ToListAsync(cancellationToken);

        var primaryTarget = await context.Targets
            .AsNoTracking()
            .OrderByDescending(t => t.status == "active")
            .ThenByDescending(t => t.createdAt)
            .ThenByDescending(t => t.id)
            .FirstOrDefaultAsync(cancellationToken);

        var totals = await context.Transactions
            .AsNoTracking()
            .GroupBy(t => t.type)
            .Select(g => new { Type = g.Key, Total = g.Sum(x => x.amount) })
            .ToListAsync(cancellationToken);

        var transactionBalance = wallets.FirstOrDefault(w => w.type == "transaction")?.balance ?? 0m;
        var targetBalance = wallets.FirstOrDefault(w => w.type == "target")?.balance ?? 0m;

        var totalIncome = totals.FirstOrDefault(t => t.Type == "income")?.Total ?? 0m;
        var totalExpense = totals.FirstOrDefault(t => t.Type == "expense")?.Total ?? 0m;

        return new DashboardStats
        {
            transactionBalance = transactionBalance,
            targetBalance = targetBalance,
            totalBalance = transactionBalance + targetBalance,
            totalIncome = totalIncome,
            totalExpense = totalExpense,
            primaryTarget = primaryTarget
        };
    }

    public async Task AddIncomeAsync(decimal amount, string? note, int? targetId = null, CancellationToken cancellationToken = default)
    {
        ValidateAmount(amount);

        if (!targetId.HasValue)
        {
            await AddOrdinaryTransactionAsync("income", amount, note, cancellationToken);
            return;
        }

        await using var context = CreateContext();
        await using var tx = await context.Database.BeginTransactionAsync(cancellationToken);

        var target = await context.Targets.FirstOrDefaultAsync(t => t.id == targetId.Value, cancellationToken)
            ?? throw new InvalidOperationException("Target tabungan tidak ditemukan.");

        if (target.status == "complete" || target.currentAmount >= target.targetAmount)
            throw new InvalidOperationException("Target ini sudah selesai.");

        var remaining = target.targetAmount - target.currentAmount;
        if (amount > remaining)
            throw new InvalidOperationException(
                $"Pemasukan melebihi sisa target. Maksimal: Rp {remaining:N0}.");

        var targetWallet = await context.Wallets.FirstOrDefaultAsync(w => w.id == target.walletId && w.type == "target", cancellationToken)
            ?? await context.Wallets.FirstOrDefaultAsync(w => w.type == "target", cancellationToken)
            ?? throw new InvalidOperationException("Dompet Target tidak ditemukan.");

        var transaction = new Transactions
        {
            walletId = targetWallet.id,
            targetId = target.id,
            type = "income",
            amount = amount,
            transactionAt = DateTime.UtcNow,
            note = NormalizeNote(string.IsNullOrWhiteSpace(note) ? $"Pemasukan target: {target.name}" : note)
        };

        context.Transactions.Add(transaction);
        targetWallet.balance += amount;
        target.currentAmount += amount;
        if (target.currentAmount >= target.targetAmount)
        {
            target.status = "complete";
        }

        await context.SaveChangesAsync(cancellationToken);
        await tx.CommitAsync(cancellationToken);
    }

    public Task AddExpenseAsync(decimal amount, string? note, CancellationToken cancellationToken = default)
        => AddOrdinaryTransactionAsync("expense", amount, note, cancellationToken);

    private async Task AddOrdinaryTransactionAsync(string type, decimal amount, string? note, CancellationToken cancellationToken)
    {
        ValidateAmount(amount);

        await using var context = CreateContext();
        await using var tx = await context.Database.BeginTransactionAsync(cancellationToken);

        var wallet = await context.Wallets.FirstOrDefaultAsync(w => w.type == "transaction", cancellationToken)
            ?? throw new InvalidOperationException("Dompet Transaksi tidak ditemukan.");

        if (type == "expense" && wallet.balance < amount)
            throw new InvalidOperationException("Saldo Dompet Transaksi tidak mencukupi.");

        var transaction = new Transactions
        {
            walletId = wallet.id,
            targetId = null,
            type = type,
            amount = amount,
            transactionAt = DateTime.UtcNow,
            note = NormalizeNote(note)
        };

        context.Transactions.Add(transaction);
        wallet.balance += type == "income" ? amount : -amount;

        await context.SaveChangesAsync(cancellationToken);
        await tx.CommitAsync(cancellationToken);
    }

    public async Task DepositToTargetAsync(int targetId, decimal amount, string? note, CancellationToken cancellationToken = default)
    {
        ValidateAmount(amount);

        await using var context = CreateContext();
        await using var tx = await context.Database.BeginTransactionAsync(cancellationToken);

        var transWallet = await context.Wallets.FirstOrDefaultAsync(w => w.type == "transaction", cancellationToken)
            ?? throw new InvalidOperationException("Dompet Transaksi tidak ditemukan.");

        if (transWallet.balance < amount)
            throw new InvalidOperationException("Saldo Dompet Transaksi tidak mencukupi untuk setoran.");

        var target = await context.Targets.FirstOrDefaultAsync(t => t.id == targetId, cancellationToken)
            ?? throw new InvalidOperationException("Target tabungan tidak ditemukan.");

        if (target.status == "complete" || target.currentAmount >= target.targetAmount)
            throw new InvalidOperationException("Target ini sudah selesai.");

        var remaining = target.targetAmount - target.currentAmount;
        if (amount > remaining)
            throw new InvalidOperationException(
                $"Setoran melebihi sisa target. Maksimal setoran: Rp {remaining:N0}.");

        var targetWallet = await context.Wallets.FirstOrDefaultAsync(w => w.id == target.walletId && w.type == "target", cancellationToken)
            ?? throw new InvalidOperationException("Wallet target pada target ini tidak valid.");

        var transaction = new Transactions
        {
            walletId = transWallet.id,
            targetId = target.id,
            type = "expense",
            amount = amount,
            transactionAt = DateTime.UtcNow,
            note = NormalizeNote(string.IsNullOrWhiteSpace(note) ? $"Setoran target: {target.name}" : note)
        };

        context.Transactions.Add(transaction);

        transWallet.balance -= amount;
        targetWallet.balance += amount;

        target.currentAmount += amount;
        if (target.currentAmount >= target.targetAmount)
        {
            target.status = "complete";
        }

        await context.SaveChangesAsync(cancellationToken);
        await tx.CommitAsync(cancellationToken);
    }

    public async Task WithdrawTargetAsync(int targetId, decimal? amountToWithdraw = null, CancellationToken cancellationToken = default)
    {
        await using var context = CreateContext();
        await using var tx = await context.Database.BeginTransactionAsync(cancellationToken);

        var transWallet = await context.Wallets.FirstOrDefaultAsync(w => w.type == "transaction", cancellationToken)
            ?? throw new InvalidOperationException("Dompet Transaksi tidak ditemukan.");

        var target = await context.Targets.FirstOrDefaultAsync(t => t.id == targetId, cancellationToken)
            ?? throw new InvalidOperationException("Target tabungan tidak ditemukan.");

        if (target.currentAmount <= 0)
            throw new InvalidOperationException("Tidak ada tabungan yang dapat diambil pada target ini.");

        var amount = amountToWithdraw ?? target.currentAmount;
        ValidateAmount(amount);

        if (amount > target.currentAmount)
            throw new InvalidOperationException(
                $"Nominal penarikan melebihi saldo tabungan target ({target.currentAmount:N0}).");

        var targetWallet = await context.Wallets.FirstOrDefaultAsync(w => w.id == target.walletId && w.type == "target", cancellationToken)
            ?? throw new InvalidOperationException("Wallet target pada target ini tidak valid.");

        var transaction = new Transactions
        {
            walletId = transWallet.id,
            targetId = target.id,
            type = "income",
            amount = amount,
            transactionAt = DateTime.UtcNow,
            note = $"Penarikan tabungan: {target.name}"
        };

        context.Transactions.Add(transaction);

        transWallet.balance += amount;
        targetWallet.balance -= amount;

        var wasComplete = target.status == "complete" || target.currentAmount >= target.targetAmount;
        target.currentAmount -= amount;
        target.status = wasComplete ? "complete" : (target.currentAmount >= target.targetAmount ? "complete" : "active");

        await context.SaveChangesAsync(cancellationToken);
        await tx.CommitAsync(cancellationToken);
    }

    public async Task CreateTargetAsync(string name, decimal targetAmount, DateTime? finishAt = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Nama target wajib diisi.");
        if (targetAmount <= 0)
            throw new ArgumentOutOfRangeException(nameof(targetAmount), "Nominal target harus lebih besar dari nol.");

        await using var context = CreateContext();
        var targetWallet = await context.Wallets.FirstOrDefaultAsync(w => w.type == "target", cancellationToken)
            ?? throw new InvalidOperationException("Dompet Tabungan tidak ditemukan.");

        var now = DateTime.UtcNow;
        var target = new Target
        {
            walletId = targetWallet.id,
            name = name.Trim(),
            targetAmount = targetAmount,
            currentAmount = 0m,
            createdAt = now,
            finishedAt = finishAt.HasValue ? DateTime.SpecifyKind(finishAt.Value, DateTimeKind.Utc) : now.AddMonths(1),
            status = "active"
        };

        context.Targets.Add(target);
        await context.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateTargetAsync(int targetId, string name, decimal targetAmount, DateTime? finishAt = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Nama target wajib diisi.");
        if (targetAmount <= 0)
            throw new ArgumentOutOfRangeException(nameof(targetAmount), "Nominal target harus lebih besar dari nol.");

        await using var context = CreateContext();
        var target = await context.Targets.FirstOrDefaultAsync(t => t.id == targetId, cancellationToken)
            ?? throw new InvalidOperationException("Target tabungan tidak ditemukan.");

        target.name = name.Trim();
        target.targetAmount = targetAmount;
        if (finishAt.HasValue)
        {
            target.finishedAt = DateTime.SpecifyKind(finishAt.Value, DateTimeKind.Utc);
        }
        target.status = target.currentAmount >= targetAmount ? "complete" : "active";

        await context.SaveChangesAsync(cancellationToken);
    }

    // Synchronous wrappers for backward compatibility
    public List<Wallet> GetWallets() => GetWalletsAsync().GetAwaiter().GetResult();
    public List<Target> GetTargets() => GetTargetsAsync().GetAwaiter().GetResult();
    public List<TransactionsRecord> GetTransactions(int limit = 250) => GetTransactionsAsync(limit).GetAwaiter().GetResult();
    public List<TransactionsRecord> GetFilteredTransactions(string? jenis = null, string? dompet = null, string? periode = null, int limit = 250)
        => GetFilteredTransactionsAsync(jenis, dompet, periode, limit).GetAwaiter().GetResult();
    public DashboardStats GetStats() => GetStatsAsync().GetAwaiter().GetResult();
    public void AddIncome(decimal amount, string? note, int? targetId = null) => AddIncomeAsync(amount, note, targetId).GetAwaiter().GetResult();
    public void AddExpense(decimal amount, string? note) => AddExpenseAsync(amount, note).GetAwaiter().GetResult();
    public void DepositToTarget(int targetId, decimal amount, string? note) => DepositToTargetAsync(targetId, amount, note).GetAwaiter().GetResult();
    public void WithdrawTarget(int targetId, decimal? amountToWithdraw = null) => WithdrawTargetAsync(targetId, amountToWithdraw).GetAwaiter().GetResult();
    public void CreateTarget(string name, decimal targetAmount, DateTime? finishAt = null) => CreateTargetAsync(name, targetAmount, finishAt).GetAwaiter().GetResult();
    public void UpdateTarget(int targetId, string name, decimal targetAmount, DateTime? finishAt = null) => UpdateTargetAsync(targetId, name, targetAmount, finishAt).GetAwaiter().GetResult();

    private static void ValidateAmount(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Nominal harus lebih besar dari nol.");
        if (decimal.Round(amount, 2) != amount)
            throw new ArgumentException("Nominal maksimal memiliki 2 angka desimal.");
    }

    private static string? NormalizeNote(string? note)
        => string.IsNullOrWhiteSpace(note) ? null : note.Trim();
}
