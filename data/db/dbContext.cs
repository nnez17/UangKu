using Microsoft.EntityFrameworkCore;
using Npgsql;
using UangKu.Models;

namespace UangKu.Data;

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
            optionsBuilder.UseNpgsql(Db.DataSource, o =>
            {
                o.MapEnum<WalletType>("wallet_type");
                o.MapEnum<TransactionType>("transaction_type");
                o.MapEnum<TargetStatus>("target_status");
            });
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
                .HasConversion(
                    v => Enum.Parse<WalletType>(v, true),
                    v => v.ToString().ToLowerInvariant())
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
            entity.Property(e => e.walletId).HasColumnName("wallet_id").IsRequired();
            entity.Property(e => e.name).HasColumnName("name").HasMaxLength(128).IsRequired();
            entity.Property(e => e.targetAmount)
                .HasColumnName("target_amount")
                .HasColumnType("decimal")
                .IsRequired();
            entity.Property(e => e.currentAmount)
                .HasColumnName("current_amount")
                .HasColumnType("decimal")
                .HasDefaultValue(0m);
            entity.Property(e => e.createdAt)
                .HasColumnName("created_at")
                .HasColumnType("timestamptz")
                .HasDefaultValueSql("NOW()");
            entity.Ignore(e => e.finishedAt);
            entity.Property(e => e.status)
                .HasColumnName("status")
                .HasConversion(
                    v => Enum.Parse<TargetStatus>(v, true),
                    v => v.ToString().ToLowerInvariant())
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
            entity.ToTable("transactions");
            entity.HasKey(e => e.id);
            entity.Property(e => e.id).HasColumnName("id");
            entity.Property(e => e.walletId).HasColumnName("wallet_id").IsRequired();
            entity.Property(e => e.targetId).HasColumnName("target_id");
            entity.Property(e => e.type)
                .HasColumnName("type")
                .HasConversion(
                    v => Enum.Parse<TransactionType>(v, true),
                    v => v.ToString().ToLowerInvariant())
                .IsRequired();
            entity.Property(e => e.amount)
                .HasColumnName("amount")
                .HasColumnType("decimal")
                .IsRequired();
            entity.Property(e => e.transactionAt)
                .HasColumnName("transaction_at")
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