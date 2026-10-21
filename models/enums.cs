using NpgsqlTypes;

namespace Uangku.Models;

public enum WalletType
{
    [PgName("transaction")]
    Transaction,
    [PgName("target")]
    Target
}

public enum TransactionType
{
    [PgName("income")]
    Income,
    [PgName("expense")]
    Expanse
}

public enum TargetStatus
{
    [PgName("active")]
    Active,
    [PgName("complate")]
    Complate
}
