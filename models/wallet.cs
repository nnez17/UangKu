using UangKu.Models;

namespace Uangku.Models;

public sealed class Wallet
{
    public int id { get; set; }
    public string name { get; set; } = "";
    public string type { get; set; } = "";
    public decimal balance { get; set; }

    public ICollection<Target> Targets { get; set; } = new List<Target>();
    public ICollection<Transactions> Transactions { get; set; } = new List<Transactions>();

    public override string ToString() => $"{name} — {balance:N0}";
};