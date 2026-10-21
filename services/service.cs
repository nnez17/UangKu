using Microsoft.EntityFrameworkCore;
using Uangku.Data;
using Uangku.Models;
using UangKu.Data;
using UangKu.Models;

namespace UangKu.Services;

public sealed class DashboardSummary
{
    public decimal transactionBalance { get; set; }
    public decimal targetBalance { get; set; }
    public decimal totalBalance { get; set; }
    public decimal totalIncome { get; set; }
    public decimal totalExpense { get; set; }
    public Target? trimaryTarget { get; set; }
}

public sealed class Service
{
    public List<Wallet> GetWallets()
    {
        using var context = Db.CreateContext();
        return context.Wallets
            .AsNoTracking()
            .OrderBy(w => w.id)
            .ToList();
    }

    public List<Target> GetTargets()
    {
        using var context = Db.CreateContext();
        return context.Targets
            .AsNoTracking()
            .OrderByDescending(t => t.createdAt)
            .ThenByDescending(t => t.id)
            .ToList();
    }

    public List<TransactionsRecord> GetTransactions(int limit = 250)
    {
        using var context = Db.CreateContext();
        return context.Transactions
            .AsNoTracking()
            .Include(t => t.Wallet)
            .Include(t => t.Target)
            .OrderByDescending(tr => tr.transactionAt)
            .ThenByDescending(tr => tr.id)
            .Take(limit)
            .Select(tr => new TransactionRecord
            {
                Id = tr.id,
                TransactionAt = tr.transactionAt.ToLocalTime(),
                Type = tr.type,
                Amount = tr.amount,
                WalletName = tr.Wallet != null ? tr.Wallet.name : "",
                TargetName = tr.Target != null ? tr.Target.name : null,
                Note = tr.note
            })
            .ToList();
    }

    public List<TransactionsRecord> GetFilteredTransactions(string? jenis = null, string? dompet = null, string? periode = null, int limit = 250)
    {
        using var context = Db.CreateContext();
        IQueryable<Transaction> query = context.Transactions
            .AsNoTracking()
            .Include(t => t.Wallet)
            .Include(t => t.Target);

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
            if (periode.Equals("Minggu", StringComparison.OrdinalIgnoreCase))
            {
                var cutoff = DateTime.UtcNow.AddDays(-7);
                query = query.Where(t => t.transactionAt >= cutoff);
            }
            else if (periode.Equals("Bulan", StringComparison.OrdinalIgnoreCase))
            {
                var cutoff = DateTime.UtcNow.AddDays(-30);
                query = query.Where(t => t.transactionAt >= cutoff);
            }
            else if (periode.Equals("Tahun", StringComparison.OrdinalIgnoreCase))
            {
                var cutoff = DateTime.UtcNow.AddYears(-1);
                query = query.Where(t => t.transactionAt >= cutoff);
            }
        }

        return query
            .OrderByDescending(t => t.transactionAt)
            .ThenByDescending(t => t.id)
            .Take(limit)
            .Select(tr => new TransactionRecord
            {
                Id = tr.id,
                TransactionAt = tr.transactionAt.ToLocalTime(),
                Type = tr.type,
                Amount = tr.amount,
                WalletName = tr.Wallet != null ? tr.Wallet.name : "",
                TargetName = tr.Target != null ? tr.Target.name : null,
                Note = tr.note
            })
            .ToList();
    }

    public DashboardSummary GetSummary()
    {
        using var context = Db.CreateContext();
        var wallets = context.Wallets.AsNoTracking().ToList();
        var targets = context.Targets
            .AsNoTracking()
            .OrderByDescending(t => t.createdAt)
            .ThenByDescending(t => t.id)
            .ToList();

        var transactionWallet = wallets.FirstOrDefault(w => w.type == "transaction");
        var targetWallet = wallets.FirstOrDefault(w => w.type == "target");

        var transactionBalance = transactionWallet?.balance ?? 0m;
        var targetBalance = targetWallet?.balance ?? 0m;
        var totalBalance = transactionBalance + targetBalance;

        var totalIncome = context.Transactions
            .Where(t => t.type == "income")
            .Sum(t => (decimal?)t.amount) ?? 0m;

        var totalExpense = context.Transactions
            .Where(t => t.type == "expense")
            .Sum(t => (decimal?)t.amount) ?? 0m;

        var primaryTarget = targets.FirstOrDefault(t => t.status == "active") ?? targets.FirstOrDefault();

        return new DashboardSummary
        {
            transactionBalance = transactionBalance,
            targetBalance = targetBalance,
            totalBalance = totalBalance,
            totalIncome = totalIncome,
            totalExpense = totalExpense,
            primaryTarget = primaryTarget
        };
    }

    public void AddIncome(decimal amount, string? note)
        => AddOrdinaryTransaction("income", amount, note);

    public void AddExpense(decimal amount, string? note)
        => AddOrdinaryTransaction("expense", amount, note);

    private static void AddOrdinaryTransaction(string type, decimal amount, string? note)
    {
        ValidateAmount(amount);

        using var context = Db.CreateContext();
        using var tx = context.Database.BeginTransaction();

        var wallet = context.Wallets.FirstOrDefault(w => w.type == "transaction")
            ?? throw new InvalidOperationException("Dompet Transaksi tidak ditemukan.");

        if (type == "expense" && wallet.balance < amount)
            throw new InvalidOperationException("Saldo Dompet Transaksi tidak mencukupi.");

        var transaction = new Transaction
        {
            walletId = wallet.id,
            targetId = null,
            type = type,
            amount = amount,
            transactionAt = DateTime.UtcNow,
            note = NormalizeNote(note)
        };

        context.Transactions.Add(transaction);

        var delta = type == "income" ? amount : -amount;
        wallet.balance += delta;

        context.SaveChanges();
        tx.Commit();
    }

    public void DepositToTarget(int targetId, decimal amount, string? note)
    {
        ValidateAmount(amount);

        using var context = Db.CreateContext();
        using var tx = context.Database.BeginTransaction();

        var transWallet = context.Wallets.FirstOrDefault(w => w.Type == "transaction")
            ?? throw new InvalidOperationException("Dompet Transaksi tidak ditemukan.");

        if (transWallet.balance < amount)
            throw new InvalidOperationException("Saldo Dompet Transaksi tidak mencukupi untuk setoran.");

        var target = context.Targets.FirstOrDefault(t => t.id == targetId)
            ?? throw new InvalidOperationException("Target tabungan tidak ditemukan.");

        if (target.status == "complete" || target.currentAmount >= target.targetAmount)
            throw new InvalidOperationException("Target ini sudah selesai.");

        if (amount > target.targetAmount - target.currentAmount)
            throw new InvalidOperationException(
                $"Setoran melebihi sisa target. Maksimal setoran: {(target.targetAmount - target.currentAmount):N2}.");

        var targetWallet = context.Wallets.FirstOrDefault(w => w.id == target.WalletId && w.Type == "target")
            ?? throw new InvalidOperationException("Wallet target pada target ini tidak valid.");

        var transaction = new Transaction
        {
            walletId = transWallet.id,
            targetId = target.id,
            type = "expense",
            amount = amount,
            transactionAt = DateTime.UtcNow,
            note = NormalizeNote(string.IsNullOrWhiteSpace(note) ? $"Setoran target: {target.Name}" : note)
        };

        context.transactions.Add(transaction);

        transWallet.balance -= amount;
        targetWallet.balance += amount;

        target.currentAmount += amount;
        if (target.currentAmount >= target.targetAmount)
        {
            target.status = "complete";
        }

        context.SaveChanges();
        tx.Commit();
    }

    public void WithdrawTarget(int targetId, decimal? amountToWithdraw = null)
    {
        using var context = Db.CreateContext();
        using var tx = context.Database.BeginTransaction();

        var transWallet = context.Wallets.FirstOrDefault(w => w.Type == "transaction")
            ?? throw new InvalidOperationException("Dompet Transaksi tidak ditemukan.");

        var target = context.Targets.FirstOrDefault(t => t.Id == targetId)
            ?? throw new InvalidOperationException("Target tabungan tidak ditemukan.");

        if (target.currentAmount <= 0)
            throw new InvalidOperationException("Tidak ada tabungan yang dapat diambil pada target ini.");

        var amount = amountToWithdraw ?? target.currentAmount;
        ValidateAmount(amount);

        if (amount > target.currentAmount)
            throw new InvalidOperationException(
                $"Nominal penarikan melebihi saldo tabungan target ({target.currentAmount:N0}).");

        var targetWallet = context.Wallets.FirstOrDefault(w => w.Id == target.walletId && w.Type == "target")
            ?? throw new InvalidOperationException("Wallet target pada target ini tidak valid.");

        var transaction = new Transaction
        {
            walletId = transWallet.id,
            targetId = target.id,
            type = "income",
            amount = amount,
            transactionAt = DateTime.UtcNow,
            note = $"Penarikan tabungan: {target.Name}"
        };

        context.Transactions.Add(transaction);

        transWallet.balance += amount;
        targetWallet.balance -= amount;

        target.currentAmount -= amount;
        target.status = target.currentAmount >= target.targetAmount ? "complete" : "active";

        context.SaveChanges();
        tx.Commit();
    }

    public void CreateTarget(string name, decimal targetAmount, DateTime? finishAt = null)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Nama target wajib diisi.");
        if (targetAmount <= 0)
            throw new ArgumentOutOfRangeException(nameof(targetAmount), "Nominal target harus lebih besar dari nol.");

        using var context = Db.CreateContext();
        var targetWallet = context.Wallets.FirstOrDefault(w => w.Type == "target")
            ?? throw new InvalidOperationException("Dompet Tabungan tidak ditemukan.");

        var now = DateTime.UtcNow;
        var target = new SavingsTarget
        {
            walletId = targetWallet.id,
            name = name.Trim(),
            targetAmount = targetAmount,
            currentAmount = 0m,
            createdAt = now,
            finishAt = finishAt.HasValue ? finishAt.Value.ToUniversalTime() : now.AddMonths(1),
            status = "active"
        };

        context.Targets.Add(target);
        context.SaveChanges();
    }

    public void UpdateTarget(int targetId, string name, decimal targetAmount, DateTime? finishAt = null)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Nama target wajib diisi.");
        if (targetAmount <= 0)
            throw new ArgumentOutOfRangeException(nameof(targetAmount), "Nominal target harus lebih besar dari nol.");

        using var context = Db.CreateContext();
        var target = context.Targets.FirstOrDefault(t => t.Id == targetId)
            ?? throw new InvalidOperationException("Target tabungan tidak ditemukan.");

        target.name = name.Trim();
        target.targetAmount = targetAmount;
        if (finishAt.HasValue)
        {
            target.finishAt = finishAt.Value.ToUniversalTime();
        }
        target.status = target.currentAmount >= targetAmount ? "complete" : "active";

        context.SaveChanges();
    }

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

