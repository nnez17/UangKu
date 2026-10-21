namespace UangKu.Controls;

public partial class AmbilUangControl : UserControl
{
    public event EventHandler? DetailTargetRequested;

    public AmbilUangControl()
    {
        InitializeComponent();
        btnBatalAmbil.Click += (_, _) => DetailTargetRequested?.Invoke(this, EventArgs.Empty);
        btnKonfirmasiAmbil.Click += (_, _) => DetailTargetRequested?.Invoke(this, EventArgs.Empty);
    }
}
