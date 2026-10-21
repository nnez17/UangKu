using Microsoft.EntityFrameworkCore;
using Npgsql;
using Uangku.Models;

namespace Uangku.Data;

public class AppDbContext : DbContext
{
    public DbSet<Wallet> Wallets => Set<Wallet>();
    public DbSet<Target> Targets => Set<Target>();
    public DbSet<Transactions> Transactions => Set<Transactions>();

    //Parameterless Constructor
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql(Db.ConnectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.HasPostgresEnum<WalletType>("wallet_type");
        modelBuilder.HasPostgresEnum<TransactionType>("transaction_type");
        modelBuilder.HasPostgresEnum<TargetStatus>("target_status");

        //Wallet
        modelBuilder.Entity<Wallet>(entity =>
        {
            entity.ToTable('wallet');
            entity.HasKey(e => e.id);
            entity.Property(e => e.id).HasColumnName("id");
            entity.Property(e => e.name).HasColumnName("name").HasMaxLength(128).IsRequired();
            entity.Property(e => e.type)
                .HasColumnName("type")
                .HasConversion<WalletType>()
                .IsRequired;
            entity.Property(e => e.balance)
                .HasColumnName("balance")
                .HasColumnType("decimal")
                .HasDefaultValue(0m);
        });

        //Target
        modelBuilder.Entity<SavingsTarget>(entity =>
        {
            entity.ToTable("target");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.WalletId).HasColumnName("walletId").IsRequired();
            entity.Property(e => e.Name).HasColumnName("name").HasMaxLength(128).IsRequired();
            entity.Property(e => e.TargetAmount)
                .HasColumnName("targetAmount")
                .HasColumnType("decimal")
                .IsRequired();
            entity.Property(e => e.CurrentAmount)
                .HasColumnName("currentAmount")
                .HasColumnType("decimal")
                .HasDefaultValue(0m);
            entity.Property(e => e.CreatedAt)
                .HasColumnName("createdAt")
                .HasColumnType("timestamptz")
                .HasDefaultValueSql("NOW()");
            entity.Property(e => e.FinishAt)
                .HasColumnName("finishAt")
                .HasColumnType("timestamptz")
                .HasDefaultValueSql("NOW()")
                .IsRequired();
            entity.Property(e => e.Status)
                .HasColumnName("status")
                .HasConversion<TargetStatus>()
                .HasDefaultValue("active")
                .IsRequired();

            entity.Ignore(e => e.Remaining);
            entity.Ignore(e => e.ProgressPercentage);

            entity.HasOne(e => e.Wallet)
                .WithMany(w => w.Targets)
                .HasForeignKey(e => e.WalletId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        //Transaction
        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.ToTable("transaction");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.WalletId).HasColumnName("walletId").IsRequired();
            entity.Property(e => e.TargetId).HasColumnName("targetId");
            entity.Property(e => e.Type)
                .HasColumnName("type")
                .HasConversion<TransactionType>()
                .IsRequired();
            entity.Property(e => e.Amount)
                .HasColumnName("amount")
                .HasColumnType("decimal")
                .IsRequired();
            entity.Property(e => e.TransactionAt)
                .HasColumnName("transactionAt")
                .HasColumnType("timestamptz")
                .HasDefaultValueSql("NOW()");
            entity.Property(e => e.Note).HasColumnName("note");

            entity.HasOne(e => e.Wallet)
                .WithMany(w => w.Transactions)
                .HasForeignKey(e => e.WalletId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(e => e.Target)
                .WithMany(t => t.Transactions)
                .HasForeignKey(e => e.TargetId)
                .OnDelete(DeleteBehavior.SetNull);
        });
    }
}