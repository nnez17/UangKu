namespace UangKu.Controls;

public partial class TambahTargetControl : UserControl
{
    public event EventHandler? TargetRequested;

    public TambahTargetControl()
    {
        InitializeComponent();
        btnBatalTambahTarget.Click += (_, _) => TargetRequested?.Invoke(this, EventArgs.Empty);
        btnSimpanTambahTarget.Click += (_, _) => TargetRequested?.Invoke(this, EventArgs.Empty);
    }
}
