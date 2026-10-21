namespace UangKu.Controls;

public partial class TargetControl : UserControl
{
    public event EventHandler? TambahTargetRequested;

    public TargetControl()
    {
        InitializeComponent();
        btnTambahTarget.Click += (_, _) => TambahTargetRequested?.Invoke(this, EventArgs.Empty);
    }
}
