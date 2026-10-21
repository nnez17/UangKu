using Npgsql;
using dotenv.net;
using Uangku.Models;

namespace Uangku.Data;

public static class Db
{
    private static string _connectionString = string.Empty;

    public static string ConnectionString
    {
        get
        {
            if (string.IsNullOrWhiteSpace(_connectionString))
            {
                _connectionString = LoadConnectionString();
            }
            return _connectionString;
        }
    }
    public static AppDbContext CreateContext()
    {
        return new AppDbContext();
    }

    public static void Initialize()
    {
        _connectionString = LoadConnectionString();

        using var context = CreateContext();
        context.Database.EnsureCreated();

        if (!context.Wallets.Any(w => w.type == "transaction"))
        {
            context.Wallets.Add(new Wallet
            {
                name = "Dompet Transaksi",
                type = "transaction",
                balance = 0m
            });
        }

        if (!context.Wallets.Any(w => w.type == "target"))
        {
            context.Wallets.Add(new Wallet
            {
                name = "Dompet Target",
                type = "target",
                balance = 0m
            });
        }

        context.SaveChanges();
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

                var key = line.Substring(0, separatorIndex).Trim();
                var value = line.Substring(separatorIndex + 1).Trim();

                if (value.Length >= 2 &&
                    ((value.StartsWith('"') && value.EndsWith('"')) ||
                     (value.StartsWith('\'') && value.EndsWith('\''))))
                {
                    value = value.Substring(1, value.Length - 2);
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
        var cadidates = new List<string>
        {
            Path.Combine(AppContext.BaseDirectory, ".env"),
            Path.Combine(Directory.GetCurrentDirectory(), ".env")
        };

        var dir = new DirectoryInfo(AppContext.BaseDirectory);
        while (dir != null)
        {
            cadidates.Add(Path.Combine(dir.FullName, ".env"));
            dir = dir.Parent;
        }

        var envPath = cadidates.FirstOrDefault(File.Exists);

        if (envPath != null)
        {
            DotEnv.Load(new DotEnvOptions(
                envFilePaths: new[] { envPath },
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
                 ?? Environment.GetEnvironmentVariable("DB_DATABASE")
                 ?? "postgres";
        var user = Environment.GetEnvironmentVariable("DB_USER")
                  ?? Environment.GetEnvironmentVariable("DB_USERNAME")
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