namespace Uangku.Models;

public sealed class TransactionsRecord
{
    public int id { get; set; }
    public DateTime transactionAt { get; set; }
    public string type { get; set; } = "";
    public decimal amount { get; set; }
    public string walletName { get; set; } = "";
    public string? targetName { get; set; }
    public string? note { get; set; }
}