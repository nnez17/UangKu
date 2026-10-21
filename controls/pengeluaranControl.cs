namespace UangKu.Controls;

public partial class PengeluaranControl : UserControl
{
    public event EventHandler? DashboardRequested;

    public PengeluaranControl()
    {
        InitializeComponent();
        btnBatalPengeluaran.Click += (_, _) => DashboardRequested?.Invoke(this, EventArgs.Empty);
        btnSimpanPengeluaran.Click += (_, _) => DashboardRequested?.Invoke(this, EventArgs.Empty);
    }
}
