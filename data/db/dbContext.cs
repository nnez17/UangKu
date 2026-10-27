using Microsoft.EntityFrameworkCore;
using Npgsql;
using Uangku.Models;
using UangKu.Models;

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
            entity.ToTable("wallet");
            entity.HasKey(e => e.id);
            entity.Property(e => e.id).HasColumnName("id");
            entity.Property(e => e.name).HasColumnName("name").HasMaxLength(128).IsRequired();
            entity.Property(e => e.type)
                .HasColumnName("type")
                .HasConversion<WalletType>()
                .IsRequired();
            entity.Property(e => e.balance)
                .HasColumnName("balance")
                .HasColumnType("decimal")
                .HasDefaultValue(0m);
        });

        //Target
        modelBuilder.Entity<Target>(entity =>
        {
            entity.ToTable("target");
            entity.HasKey(e => e.id);
            entity.Property(e => e.id).HasColumnName("id");
            entity.Property(e => e.walletId).HasColumnName("walletId").IsRequired();
            entity.Property(e => e.name).HasColumnName("name").HasMaxLength(128).IsRequired();
            entity.Property(e => e.targetAmount)
                .HasColumnName("targetAmount")
                .HasColumnType("decimal")
                .IsRequired();
            entity.Property(e => e.currentAmount)
                .HasColumnName("currentAmount")
                .HasColumnType("decimal")
                .HasDefaultValue(0m);
            entity.Property(e => e.createdAt)
                .HasColumnName("createdAt")
                .HasColumnType("timestamptz")
                .HasDefaultValueSql("NOW()");
            entity.Property(e => e.finishedAt)
                .HasColumnName("finishAt")
                .HasColumnType("timestamptz")
                .HasDefaultValueSql("NOW()")
                .IsRequired();
            entity.Property(e => e.status)
                .HasColumnName("status")
                .HasConversion<TargetStatus>()
                .HasDefaultValue("active")
                .IsRequired();

            entity.Ignore(e => e.Remaining);
            entity.Ignore(e => e.ProgressPercentage);

            entity.HasOne(e => e.wallet)
                .WithMany(w => w.Targets)
                .HasForeignKey(e => e.walletId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        //Transaction
        modelBuilder.Entity<Transactions>(entity =>
        {
            entity.ToTable("transaction");
            entity.HasKey(e => e.id);
            entity.Property(e => e.id).HasColumnName("id");
            entity.Property(e => e.walletId).HasColumnName("walletId").IsRequired();
            entity.Property(e => e.targetId).HasColumnName("targetId");
            entity.Property(e => e.type)
                .HasColumnName("type")
                .HasConversion<TransactionType>()
                .IsRequired();
            entity.Property(e => e.amount)
                .HasColumnName("amount")
                .HasColumnType("decimal")
                .IsRequired();
            entity.Property(e => e.transactionAt)
                .HasColumnName("transactionAt")
                .HasColumnType("timestamptz")
                .HasDefaultValueSql("NOW()");
            entity.Property(e => e.note).HasColumnName("note");

            entity.HasOne(e => e.wallet)
                .WithMany(w => w.Transactions)
                .HasForeignKey(e => e.walletId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(e => e.target)
                .WithMany(t => t.Transactions)
                .HasForeignKey(e => e.targetId)
                .OnDelete(DeleteBehavior.SetNull);
        });
    }
}