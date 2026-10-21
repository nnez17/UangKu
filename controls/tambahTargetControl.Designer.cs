#nullable enable
namespace UangKu.Controls;

partial class TambahTargetControl
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitleTambahTarget = null!;
    private Panel cardTambahTarget = null!;
    private Label txtNamaTambahTargetLabel = null!;
    private TextBox txtNamaTambahTarget = null!;
    private Label txtNominalTambahTargetLabel = null!;
    private TextBox txtNominalTambahTarget = null!;
    private Button btnBatalTambahTarget = null!;
    private Button btnSimpanTambahTarget = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitleTambahTarget = new Label();
        cardTambahTarget = new Panel();
        txtNamaTambahTargetLabel = new Label();
        txtNamaTambahTarget = new TextBox();
        txtNominalTambahTargetLabel = new Label();
        txtNominalTambahTarget = new TextBox();
        btnBatalTambahTarget = new Button();
        btnSimpanTambahTarget = new Button();
        cardTambahTarget.SuspendLayout();
        SuspendLayout();
        //
        // lblTitleTambahTarget
        //
        lblTitleTambahTarget.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitleTambahTarget.ForeColor = Color.FromArgb(38, 73, 68);
        lblTitleTambahTarget.Location = new Point(40, 32);
        lblTitleTambahTarget.Name = "lblTitleTambahTarget";
        lblTitleTambahTarget.Size = new Size(800, 44);
        lblTitleTambahTarget.TabIndex = 0;
        lblTitleTambahTarget.Text = "Tambah Target";
        lblTitleTambahTarget.TextAlign = ContentAlignment.MiddleLeft;
        //
        // cardTambahTarget
        //
        cardTambahTarget.BorderStyle = BorderStyle.FixedSingle;
        cardTambahTarget.Controls.Add(txtNamaTambahTargetLabel);
        cardTambahTarget.Controls.Add(txtNamaTambahTarget);
        cardTambahTarget.Controls.Add(txtNominalTambahTargetLabel);
        cardTambahTarget.Controls.Add(txtNominalTambahTarget);
        cardTambahTarget.Controls.Add(btnBatalTambahTarget);
        cardTambahTarget.Controls.Add(btnSimpanTambahTarget);
        cardTambahTarget.Location = new Point(40, 110);
        cardTambahTarget.Name = "cardTambahTarget";
        cardTambahTarget.Size = new Size(800, 300);
        cardTambahTarget.TabIndex = 1;
        //
        // txtNamaTambahTargetLabel
        //
        txtNamaTambahTargetLabel.Font = new Font("Segoe UI", 9F);
        txtNamaTambahTargetLabel.ForeColor = Color.FromArgb(38, 73, 68);
        txtNamaTambahTargetLabel.Location = new Point(40, 22);
        txtNamaTambahTargetLabel.Name = "txtNamaTambahTargetLabel";
        txtNamaTambahTargetLabel.Size = new Size(716, 24);
        txtNamaTambahTargetLabel.TabIndex = 0;
        txtNamaTambahTargetLabel.Text = "Nama Target";
        txtNamaTambahTargetLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // txtNamaTambahTarget
        //
        txtNamaTambahTarget.AccessibleName = "Nama Target";
        txtNamaTambahTarget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtNamaTambahTarget.BorderStyle = BorderStyle.FixedSingle;
        txtNamaTambahTarget.Location = new Point(40, 52);
        txtNamaTambahTarget.Multiline = true;
        txtNamaTambahTarget.Name = "txtNamaTambahTarget";
        txtNamaTambahTarget.Size = new Size(716, 40);
        txtNamaTambahTarget.TabIndex = 108;
        //
        // txtNominalTambahTargetLabel
        //
        txtNominalTambahTargetLabel.Font = new Font("Segoe UI", 9F);
        txtNominalTambahTargetLabel.ForeColor = Color.FromArgb(38, 73, 68);
        txtNominalTambahTargetLabel.Location = new Point(40, 116);
        txtNominalTambahTargetLabel.Name = "txtNominalTambahTargetLabel";
        txtNominalTambahTargetLabel.Size = new Size(716, 24);
        txtNominalTambahTargetLabel.TabIndex = 109;
        txtNominalTambahTargetLabel.Text = "Nominal Target";
        txtNominalTambahTargetLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // txtNominalTambahTarget
        //
        txtNominalTambahTarget.AccessibleName = "Nominal Target";
        txtNominalTambahTarget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtNominalTambahTarget.BorderStyle = BorderStyle.FixedSingle;
        txtNominalTambahTarget.Location = new Point(40, 146);
        txtNominalTambahTarget.Multiline = true;
        txtNominalTambahTarget.Name = "txtNominalTambahTarget";
        txtNominalTambahTarget.PlaceholderText = "Rp 0";
        txtNominalTambahTarget.Size = new Size(716, 40);
        txtNominalTambahTarget.TabIndex = 110;
        //
        // btnBatalTambahTarget
        //
        btnBatalTambahTarget.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnBatalTambahTarget.BackColor = Color.White;
        btnBatalTambahTarget.Cursor = Cursors.Hand;
        btnBatalTambahTarget.FlatAppearance.BorderColor = Color.FromArgb(229, 237, 232);
        btnBatalTambahTarget.FlatStyle = FlatStyle.Flat;
        btnBatalTambahTarget.ForeColor = Color.FromArgb(38, 73, 68);
        btnBatalTambahTarget.Location = new Point(510, 228);
        btnBatalTambahTarget.Name = "btnBatalTambahTarget";
        btnBatalTambahTarget.Size = new Size(92, 40);
        btnBatalTambahTarget.TabIndex = 111;
        btnBatalTambahTarget.Text = "Batal";
        btnBatalTambahTarget.UseVisualStyleBackColor = false;
        //
        // btnSimpanTambahTarget
        //
        btnSimpanTambahTarget.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnSimpanTambahTarget.BackColor = Color.FromArgb(21, 125, 104);
        btnSimpanTambahTarget.Cursor = Cursors.Hand;
        btnSimpanTambahTarget.FlatAppearance.BorderColor = Color.FromArgb(229, 237, 232);
        btnSimpanTambahTarget.FlatStyle = FlatStyle.Flat;
        btnSimpanTambahTarget.ForeColor = Color.White;
        btnSimpanTambahTarget.Location = new Point(614, 228);
        btnSimpanTambahTarget.Name = "btnSimpanTambahTarget";
        btnSimpanTambahTarget.Size = new Size(144, 40);
        btnSimpanTambahTarget.TabIndex = 112;
        btnSimpanTambahTarget.Text = "Simpan";
        btnSimpanTambahTarget.UseVisualStyleBackColor = false;
        //
        // TambahTargetControl
        //
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Font = new Font("Segoe UI", 9F);
        AutoScroll = true;
        BackColor = Color.White;
        Controls.Add(lblTitleTambahTarget);
        Controls.Add(cardTambahTarget);
        Name = "TambahTargetControl";
        Size = new Size(880, 806);
        cardTambahTarget.ResumeLayout(false);
        cardTambahTarget.PerformLayout();
        ResumeLayout(false);
    }
}
