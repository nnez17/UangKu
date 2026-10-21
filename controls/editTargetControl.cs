namespace UangKu.Controls;

public partial class EditTargetControl : UserControl
{
    public event EventHandler? DetailTargetRequested;

    public EditTargetControl()
    {
        InitializeComponent();
        btnBatalEditTarget.Click += (_, _) => DetailTargetRequested?.Invoke(this, EventArgs.Empty);
        btnSimpanEditTarget.Click += (_, _) => DetailTargetRequested?.Invoke(this, EventArgs.Empty);
    }
}
