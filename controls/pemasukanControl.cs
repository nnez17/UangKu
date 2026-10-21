namespace UangKu.Controls;

public partial class PemasukanControl : UserControl
{
    public event EventHandler? DashboardRequested;

    public PemasukanControl()
    {
        InitializeComponent();
        btnBatalPemasukan.Click += (_, _) => DashboardRequested?.Invoke(this, EventArgs.Empty);
        btnSimpanPemasukan.Click += (_, _) => DashboardRequested?.Invoke(this, EventArgs.Empty);
        radioTarget.CheckedChanged += (_, _) =>
        {
            lblPilihTargetPemasukan.Visible = radioTarget.Checked;
            cmbTargetPemasukan.Visible = radioTarget.Checked;
            lblBantuanTarget.Visible = radioTarget.Checked;
            btnBatalPemasukan.Top = btnSimpanPemasukan.Top = radioTarget.Checked ? 576 : 444;
        };
    }
}
