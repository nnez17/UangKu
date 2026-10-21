namespace UangKu.Models;

public sealed class Target
{
    public int id { get; set; }
    public int walletId { get; set; }
    public string name { get; set; } = "";
    public decimal targetAmount { get; set; }
    public decimal currentAmount { get; set; } 
    public DateTime createdAt { get; set; } = DateTime.UtcNow;
    public DateTime? finishedAt { get; set; } = DateTime.UtcNow.AddMonths(1);
    public string status { get; set; } = "active";

    public ICollection<Transactions> Transactions { get; set; } = new List<Transactions>();

    public decimal Remaining => Math.Max(0, targetAmount - currentAmount);
    public int ProgressPercentage => targetAmount > 0
        ? Math.Min(100, (int)Math.Round((currentAmount / targetAmount) * 100))
        : 0;

    public override string ToString() =>
        $"{name} - {currentAmount:N0}/{targetAmount:N0} ({status})";
}