#nullable enable
namespace UangKu.Controls;

partial class TargetControl
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblEmptyTargetHint = null!;
    private Label lblEmptyTarget = null!;
    private Label lblTitleTarget = null!;
    private Button btnTambahTarget = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblEmptyTargetHint = new Label();
        lblEmptyTarget = new Label();
        lblTitleTarget = new Label();
        btnTambahTarget = new Button();

        SuspendLayout();
        //
        // lblEmptyTargetHint
        //
        lblEmptyTargetHint.BackColor = Color.White;
        lblEmptyTargetHint.Font = new Font("Segoe UI", 10F);
        lblEmptyTargetHint.ForeColor = Color.FromArgb(112, 139, 132);
        lblEmptyTargetHint.Location = new Point(40, 314);
        lblEmptyTargetHint.Name = "lblEmptyTargetHint";
        lblEmptyTargetHint.Size = new Size(800, 32);
        lblEmptyTargetHint.TabIndex = 0;
        lblEmptyTargetHint.Text = "Klik + Tambah Target untuk membuat target baru.";
        lblEmptyTargetHint.TextAlign = ContentAlignment.MiddleCenter;
        //
        // lblEmptyTarget
        //
        lblEmptyTarget.BackColor = Color.White;
        lblEmptyTarget.Font = new Font("Segoe UI", 14F);
        lblEmptyTarget.ForeColor = Color.FromArgb(112, 139, 132);
        lblEmptyTarget.Location = new Point(40, 262);
        lblEmptyTarget.Name = "lblEmptyTarget";
        lblEmptyTarget.Size = new Size(800, 44);
        lblEmptyTarget.TabIndex = 1;
        lblEmptyTarget.Text = "Belum ada target keuangan.";
        lblEmptyTarget.TextAlign = ContentAlignment.MiddleCenter;
        //
        // lblTitleTarget
        //
        lblTitleTarget.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitleTarget.ForeColor = Color.FromArgb(38, 73, 68);
        lblTitleTarget.Location = new Point(40, 32);
        lblTitleTarget.Name = "lblTitleTarget";
        lblTitleTarget.Size = new Size(800, 44);
        lblTitleTarget.TabIndex = 0;
        lblTitleTarget.Text = "Target Keuangan";
        lblTitleTarget.TextAlign = ContentAlignment.MiddleLeft;
        //
        // btnTambahTarget
        //
        btnTambahTarget.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnTambahTarget.BackColor = Color.FromArgb(21, 125, 104);
        btnTambahTarget.Cursor = Cursors.Hand;
        btnTambahTarget.FlatAppearance.BorderColor = Color.FromArgb(229, 237, 232);
        btnTambahTarget.FlatStyle = FlatStyle.Flat;
        btnTambahTarget.ForeColor = Color.White;
        btnTambahTarget.Location = new Point(678, 100);
        btnTambahTarget.Name = "btnTambahTarget";
        btnTambahTarget.Size = new Size(160, 40);
        btnTambahTarget.TabIndex = 91;
        btnTambahTarget.Text = "+ Tambah Target";
        btnTambahTarget.UseVisualStyleBackColor = false;
        //
        // TargetControl
        //
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Font = new Font("Segoe UI", 9F);
        AutoScroll = true;
        BackColor = Color.White;
        Controls.Add(lblEmptyTargetHint);
        Controls.Add(lblEmptyTarget);
        Controls.Add(lblTitleTarget);
        Controls.Add(btnTambahTarget);
        Name = "TargetControl";
        Size = new Size(880, 806);

        ResumeLayout(false);
    }
}
