using Microsoft.EntityFrameworkCore;
using Npgsql;
using dotenv.net;
using UangKu.Models;

namespace UangKu.Data;

public static class Db
{
    private static readonly Lazy<string> _connectionString = new(LoadConnectionString);
    private static readonly Lazy<NpgsqlDataSource> _dataSource = new(BuildDataSource);

    public static string ConnectionString => _connectionString.Value;
    public static NpgsqlDataSource DataSource => _dataSource.Value;

    public static AppDbContext CreateContext() => new();

    public static void Initialize()
        => InitializeAsync().GetAwaiter().GetResult();

    public static async Task InitializeAsync(CancellationToken cancellationToken = default)
    {
        await using var context = CreateContext();
        await context.Database.EnsureCreatedAsync(cancellationToken);

        var hasChanges = false;

        if (!await context.Wallets.AnyAsync(w => w.type == "transaction", cancellationToken))
        {
            context.Wallets.Add(new Wallet
            {
                name = "Dompet Transaksi",
                type = "transaction",
                balance = 0m
            });
            hasChanges = true;
        }

        if (!await context.Wallets.AnyAsync(w => w.type == "target", cancellationToken))
        {
            context.Wallets.Add(new Wallet
            {
                name = "Dompet Target",
                type = "target",
                balance = 0m
            });
            hasChanges = true;
        }

        if (hasChanges)
        {
            await context.SaveChangesAsync(cancellationToken);
        }
    }

    private static NpgsqlDataSource BuildDataSource()
    {
        var builder = new NpgsqlDataSourceBuilder(ConnectionString);
        builder.MapEnum<WalletType>("wallet_type");
        builder.MapEnum<TransactionType>("transaction_type");
        builder.MapEnum<TargetStatus>("target_status");
        return builder.Build();
    }

    private static void ParseEnvFileManually(string envPath)
    {
        try
        {
            foreach (var rawLine in File.ReadAllLines(envPath))
            {
                var line = rawLine.Trim();
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith('#') || line.StartsWith(';'))
                    continue;

                var separatorIndex = line.IndexOf('=');
                if (separatorIndex <= 0)
                    continue;

                var key = line[..separatorIndex].Trim();
                var value = line[(separatorIndex + 1)..].Trim();

                if (value.Length >= 2 &&
                    ((value.StartsWith('"') && value.EndsWith('"')) ||
                     (value.StartsWith('\'') && value.EndsWith('\''))))
                {
                    value = value[1..^1];
                }

                if (string.IsNullOrEmpty(Environment.GetEnvironmentVariable(key)))
                {
                    Environment.SetEnvironmentVariable(key, value);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error parsing .env file at {envPath}: {ex.Message}");
        }
    }

    private static void LoadEnvFile()
    {
        var candidates = new List<string>
        {
            Path.Combine(AppContext.BaseDirectory, ".env"),
            Path.Combine(Directory.GetCurrentDirectory(), ".env")
        };

        var dir = new DirectoryInfo(AppContext.BaseDirectory);
        while (dir != null)
        {
            candidates.Add(Path.Combine(dir.FullName, ".env"));
            dir = dir.Parent;
        }

        var envPath = candidates.FirstOrDefault(File.Exists);

        if (envPath != null)
        {
            DotEnv.Load(new DotEnvOptions(
                envFilePaths: [envPath],
                ignoreExceptions: true
            ));

            ParseEnvFileManually(envPath);
        }
        else
        {
            DotEnv.Load(new DotEnvOptions(
                ignoreExceptions: true,
                probeForEnv: true,
                probeLevelsToSearch: 6
            ));
        }
    }

    private static string LoadConnectionString()
    {
        LoadEnvFile();

        var directConn = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
        if (!string.IsNullOrWhiteSpace(directConn))
        {
            return directConn;
        }

        var host = Environment.GetEnvironmentVariable("DB_HOST") ?? "localhost";
        var portStr = Environment.GetEnvironmentVariable("DB_PORT") ?? "5432";
        var db = Environment.GetEnvironmentVariable("DB_NAME")
                 ?? "postgres";
        var user = Environment.GetEnvironmentVariable("DB_USER")
                  ?? "postgres";
        var pass = Environment.GetEnvironmentVariable("DB_PASSWORD");

        if (string.IsNullOrWhiteSpace(pass))
        {
            throw new InvalidOperationException(
                "Password database tidak ditemukan. Pastikan variabel DB_PASSWORD atau DB_CONNECTION_STRING sudah diatur di file .env.");
        }

        var builder = new NpgsqlConnectionStringBuilder
        {
            Host = host,
            Port = int.TryParse(portStr, out var port) ? port : 5432,
            Database = db,
            Username = user,
            Password = pass
        };

        return builder.ConnectionString;
    }
}
