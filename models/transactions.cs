using Uangku.Models;

namespace UangKu.Models;

public sealed class Transactions
{
    public int id { get; set; }
    public int walletId { get; set; }
    public Wallet? wallet { get; set; }
    public int? targetId { get; set; }
    public Target? target { get; set; }
    public string type { get; set; } = "income";
    public decimal amount { get; set; }
    public DateTime transactionsAt { get; set; } = DateTime.UtcNow;
    public string? note { get; set; }
}