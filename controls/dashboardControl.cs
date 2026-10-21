namespace UangKu.Controls;

public partial class DashboardControl : UserControl
{
    public event EventHandler? RiwayatRequested;

    public DashboardControl()
    {
        InitializeComponent();
        btnLihatSemua.Click += (_, _) => RiwayatRequested?.Invoke(this, EventArgs.Empty);
    }
}
