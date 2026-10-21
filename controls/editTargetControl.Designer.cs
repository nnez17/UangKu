#nullable enable
namespace UangKu.Controls;

partial class EditTargetControl
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitleEditTarget = null!;
    private Panel cardEditTarget = null!;
    private Label txtNamaEditTargetLabel = null!;
    private TextBox txtNamaEditTarget = null!;
    private Label txtNominalEditTargetLabel = null!;
    private TextBox txtNominalEditTarget = null!;
    private Button btnBatalEditTarget = null!;
    private Button btnSimpanEditTarget = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitleEditTarget = new Label();
        cardEditTarget = new Panel();
        txtNamaEditTargetLabel = new Label();
        txtNamaEditTarget = new TextBox();
        txtNominalEditTargetLabel = new Label();
        txtNominalEditTarget = new TextBox();
        btnBatalEditTarget = new Button();
        btnSimpanEditTarget = new Button();
        cardEditTarget.SuspendLayout();
        SuspendLayout();
        //
        // lblTitleEditTarget
        //
        lblTitleEditTarget.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitleEditTarget.ForeColor = Color.FromArgb(38, 73, 68);
        lblTitleEditTarget.Location = new Point(40, 32);
        lblTitleEditTarget.Name = "lblTitleEditTarget";
        lblTitleEditTarget.Size = new Size(800, 44);
        lblTitleEditTarget.TabIndex = 0;
        lblTitleEditTarget.Text = "Edit Target";
        lblTitleEditTarget.TextAlign = ContentAlignment.MiddleLeft;
        //
        // cardEditTarget
        //
        cardEditTarget.BorderStyle = BorderStyle.FixedSingle;
        cardEditTarget.Controls.Add(txtNamaEditTargetLabel);
        cardEditTarget.Controls.Add(txtNamaEditTarget);
        cardEditTarget.Controls.Add(txtNominalEditTargetLabel);
        cardEditTarget.Controls.Add(txtNominalEditTarget);
        cardEditTarget.Controls.Add(btnBatalEditTarget);
        cardEditTarget.Controls.Add(btnSimpanEditTarget);
        cardEditTarget.Location = new Point(40, 110);
        cardEditTarget.Name = "cardEditTarget";
        cardEditTarget.Size = new Size(800, 300);
        cardEditTarget.TabIndex = 1;
        //
        // txtNamaEditTargetLabel
        //
        txtNamaEditTargetLabel.Font = new Font("Segoe UI", 9F);
        txtNamaEditTargetLabel.ForeColor = Color.FromArgb(38, 73, 68);
        txtNamaEditTargetLabel.Location = new Point(40, 22);
        txtNamaEditTargetLabel.Name = "txtNamaEditTargetLabel";
        txtNamaEditTargetLabel.Size = new Size(716, 24);
        txtNamaEditTargetLabel.TabIndex = 0;
        txtNamaEditTargetLabel.Text = "Nama Target";
        txtNamaEditTargetLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // txtNamaEditTarget
        //
        txtNamaEditTarget.AccessibleName = "Nama Target";
        txtNamaEditTarget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtNamaEditTarget.BorderStyle = BorderStyle.FixedSingle;
        txtNamaEditTarget.Location = new Point(40, 52);
        txtNamaEditTarget.Multiline = true;
        txtNamaEditTarget.Name = "txtNamaEditTarget";
        txtNamaEditTarget.Size = new Size(716, 40);
        txtNamaEditTarget.TabIndex = 115;
        //
        // txtNominalEditTargetLabel
        //
        txtNominalEditTargetLabel.Font = new Font("Segoe UI", 9F);
        txtNominalEditTargetLabel.ForeColor = Color.FromArgb(38, 73, 68);
        txtNominalEditTargetLabel.Location = new Point(40, 116);
        txtNominalEditTargetLabel.Name = "txtNominalEditTargetLabel";
        txtNominalEditTargetLabel.Size = new Size(716, 24);
        txtNominalEditTargetLabel.TabIndex = 116;
        txtNominalEditTargetLabel.Text = "Nominal Target";
        txtNominalEditTargetLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // txtNominalEditTarget
        //
        txtNominalEditTarget.AccessibleName = "Nominal Target";
        txtNominalEditTarget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtNominalEditTarget.BorderStyle = BorderStyle.FixedSingle;
        txtNominalEditTarget.Location = new Point(40, 146);
        txtNominalEditTarget.Multiline = true;
        txtNominalEditTarget.Name = "txtNominalEditTarget";
        txtNominalEditTarget.PlaceholderText = "Rp 0";
        txtNominalEditTarget.Size = new Size(716, 40);
        txtNominalEditTarget.TabIndex = 117;
        //
        // btnBatalEditTarget
        //
        btnBatalEditTarget.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnBatalEditTarget.BackColor = Color.White;
        btnBatalEditTarget.Cursor = Cursors.Hand;
        btnBatalEditTarget.FlatAppearance.BorderColor = Color.FromArgb(229, 237, 232);
        btnBatalEditTarget.FlatStyle = FlatStyle.Flat;
        btnBatalEditTarget.ForeColor = Color.FromArgb(38, 73, 68);
        btnBatalEditTarget.Location = new Point(510, 228);
        btnBatalEditTarget.Name = "btnBatalEditTarget";
        btnBatalEditTarget.Size = new Size(92, 40);
        btnBatalEditTarget.TabIndex = 118;
        btnBatalEditTarget.Text = "Batal";
        btnBatalEditTarget.UseVisualStyleBackColor = false;
        //
        // btnSimpanEditTarget
        //
        btnSimpanEditTarget.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnSimpanEditTarget.BackColor = Color.FromArgb(21, 125, 104);
        btnSimpanEditTarget.Cursor = Cursors.Hand;
        btnSimpanEditTarget.FlatAppearance.BorderColor = Color.FromArgb(229, 237, 232);
        btnSimpanEditTarget.FlatStyle = FlatStyle.Flat;
        btnSimpanEditTarget.ForeColor = Color.White;
        btnSimpanEditTarget.Location = new Point(614, 228);
        btnSimpanEditTarget.Name = "btnSimpanEditTarget";
        btnSimpanEditTarget.Size = new Size(144, 40);
        btnSimpanEditTarget.TabIndex = 119;
        btnSimpanEditTarget.Text = "Simpan Perubahan";
        btnSimpanEditTarget.UseVisualStyleBackColor = false;
        //
        // EditTargetControl
        //
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Font = new Font("Segoe UI", 9F);
        AutoScroll = true;
        BackColor = Color.White;
        Controls.Add(lblTitleEditTarget);
        Controls.Add(cardEditTarget);
        Name = "EditTargetControl";
        Size = new Size(880, 806);
        cardEditTarget.ResumeLayout(false);
        cardEditTarget.PerformLayout();
        ResumeLayout(false);
    }
}
