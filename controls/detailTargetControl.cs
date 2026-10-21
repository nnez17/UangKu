namespace UangKu.Controls;

public partial class DetailTargetControl : UserControl
{
    public event EventHandler? TargetRequested;
    public event EventHandler? EditTargetRequested;
    public event EventHandler? AmbilUangRequested;

    public DetailTargetControl()
    {
        InitializeComponent();
        btnKembaliTarget.Click += (_, _) => TargetRequested?.Invoke(this, EventArgs.Empty);
        btnEditTarget.Click += (_, _) => EditTargetRequested?.Invoke(this, EventArgs.Empty);
        btnAmbilUang.Click += (_, _) => AmbilUangRequested?.Invoke(this, EventArgs.Empty);
    }
}
