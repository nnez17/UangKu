using NpgsqlTypes;

namespace UangKu.Models;

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
    Expense
}

public enum TargetStatus
{
    [PgName("active")]
    Active,
    [PgName("complete")]
    Complete
}
