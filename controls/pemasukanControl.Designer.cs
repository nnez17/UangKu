#nullable enable
namespace UangKu.Controls;

partial class PemasukanControl
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitlePemasukan = null!;
    private Label txtJumlahPemasukanLabel = null!;
    private TextBox txtJumlahPemasukan = null!;
    private Label txtCatatanPemasukanLabel = null!;
    private TextBox txtCatatanPemasukan = null!;
    private Label lblDompetPemasukan = null!;
    private RadioButton radioTransaksi = null!;
    private RadioButton radioTarget = null!;
    private Label lblPilihTargetPemasukan = null!;
    private ComboBox cmbTargetPemasukan = null!;
    private Label lblBantuanTarget = null!;
    private Button btnBatalPemasukan = null!;
    private Button btnSimpanPemasukan = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitlePemasukan = new Label();
        txtJumlahPemasukanLabel = new Label();
        txtJumlahPemasukan = new TextBox();
        txtCatatanPemasukanLabel = new Label();
        txtCatatanPemasukan = new TextBox();
        lblDompetPemasukan = new Label();
        radioTransaksi = new RadioButton();
        radioTarget = new RadioButton();
        lblPilihTargetPemasukan = new Label();
        cmbTargetPemasukan = new ComboBox();
        lblBantuanTarget = new Label();
        btnBatalPemasukan = new Button();
        btnSimpanPemasukan = new Button();

        SuspendLayout();
        //
        // lblTitlePemasukan
        //
        lblTitlePemasukan.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitlePemasukan.ForeColor = Color.FromArgb(38, 73, 68);
        lblTitlePemasukan.Location = new Point(40, 32);
        lblTitlePemasukan.Name = "lblTitlePemasukan";
        lblTitlePemasukan.Size = new Size(800, 44);
        lblTitlePemasukan.TabIndex = 0;
        lblTitlePemasukan.Text = "Mencatat Pemasukan";
        lblTitlePemasukan.TextAlign = ContentAlignment.MiddleLeft;
        //
        // txtJumlahPemasukanLabel
        //
        txtJumlahPemasukanLabel.Font = new Font("Segoe UI", 9F);
        txtJumlahPemasukanLabel.ForeColor = Color.FromArgb(38, 73, 68);
        txtJumlahPemasukanLabel.Location = new Point(40, 100);
        txtJumlahPemasukanLabel.Name = "txtJumlahPemasukanLabel";
        txtJumlahPemasukanLabel.Size = new Size(800, 24);
        txtJumlahPemasukanLabel.TabIndex = 1;
        txtJumlahPemasukanLabel.Text = "Jumlah";
        txtJumlahPemasukanLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // txtJumlahPemasukan
        //
        txtJumlahPemasukan.AccessibleName = "";
        txtJumlahPemasukan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtJumlahPemasukan.BorderStyle = BorderStyle.FixedSingle;
        txtJumlahPemasukan.Location = new Point(40, 130);
        txtJumlahPemasukan.Multiline = true;
        txtJumlahPemasukan.Name = "txtJumlahPemasukan";
        txtJumlahPemasukan.PlaceholderText = "Rp 0";
        txtJumlahPemasukan.Size = new Size(800, 40);
        txtJumlahPemasukan.TabIndex = 53;
        //
        // txtCatatanPemasukanLabel
        //
        txtCatatanPemasukanLabel.Font = new Font("Segoe UI", 9F);
        txtCatatanPemasukanLabel.ForeColor = Color.FromArgb(38, 73, 68);
        txtCatatanPemasukanLabel.Location = new Point(40, 190);
        txtCatatanPemasukanLabel.Name = "txtCatatanPemasukanLabel";
        txtCatatanPemasukanLabel.Size = new Size(800, 24);
        txtCatatanPemasukanLabel.TabIndex = 54;
        txtCatatanPemasukanLabel.Text = "Catatan";
        txtCatatanPemasukanLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // txtCatatanPemasukan
        //
        txtCatatanPemasukan.AccessibleName = "";
        txtCatatanPemasukan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtCatatanPemasukan.BorderStyle = BorderStyle.FixedSingle;
        txtCatatanPemasukan.Location = new Point(40, 220);
        txtCatatanPemasukan.Multiline = true;
        txtCatatanPemasukan.Name = "txtCatatanPemasukan";
        txtCatatanPemasukan.Size = new Size(800, 100);
        txtCatatanPemasukan.TabIndex = 55;
        //
        // lblDompetPemasukan
        //
        lblDompetPemasukan.Font = new Font("Segoe UI", 9F);
        lblDompetPemasukan.ForeColor = Color.FromArgb(38, 73, 68);
        lblDompetPemasukan.Location = new Point(40, 348);
        lblDompetPemasukan.Name = "lblDompetPemasukan";
        lblDompetPemasukan.Size = new Size(800, 24);
        lblDompetPemasukan.TabIndex = 56;
        lblDompetPemasukan.Text = "Dompet Dana";
        lblDompetPemasukan.TextAlign = ContentAlignment.MiddleLeft;
        //
        // radioTransaksi
        //
        radioTransaksi.Checked = true;
        radioTransaksi.Location = new Point(40, 382);
        radioTransaksi.Name = "radioTransaksi";
        radioTransaksi.Size = new Size(210, 32);
        radioTransaksi.TabIndex = 4;
        radioTransaksi.TabStop = true;
        radioTransaksi.Text = "Dompet Transaksi";
        //
        // radioTarget
        //
        radioTarget.Location = new Point(260, 382);
        radioTarget.Name = "radioTarget";
        radioTarget.Size = new Size(210, 32);
        radioTarget.TabIndex = 5;
        radioTarget.Text = "Dompet Target";
        //
        // lblPilihTargetPemasukan
        //
        lblPilihTargetPemasukan.Font = new Font("Segoe UI", 9F);
        lblPilihTargetPemasukan.ForeColor = Color.FromArgb(38, 73, 68);
        lblPilihTargetPemasukan.Location = new Point(40, 436);
        lblPilihTargetPemasukan.Name = "lblPilihTargetPemasukan";
        lblPilihTargetPemasukan.Size = new Size(800, 24);
        lblPilihTargetPemasukan.TabIndex = 57;
        lblPilihTargetPemasukan.Text = "Target";
        lblPilihTargetPemasukan.TextAlign = ContentAlignment.MiddleLeft;
        lblPilihTargetPemasukan.Visible = false;
        //
        // cmbTargetPemasukan
        //
        cmbTargetPemasukan.AccessibleName = "";
        cmbTargetPemasukan.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbTargetPemasukan.Location = new Point(40, 466);
        cmbTargetPemasukan.Name = "cmbTargetPemasukan";
        cmbTargetPemasukan.Size = new Size(800, 27);
        cmbTargetPemasukan.TabIndex = 60;
        cmbTargetPemasukan.Visible = false;
        //
        // lblBantuanTarget
        //
        lblBantuanTarget.Font = new Font("Segoe UI", 9F);
        lblBantuanTarget.ForeColor = Color.FromArgb(38, 73, 68);
        lblBantuanTarget.Location = new Point(40, 512);
        lblBantuanTarget.Name = "lblBantuanTarget";
        lblBantuanTarget.Size = new Size(800, 24);
        lblBantuanTarget.TabIndex = 61;
        lblBantuanTarget.Text = "Belum ada target. Tambahkan melalui menu Target.";
        lblBantuanTarget.TextAlign = ContentAlignment.MiddleLeft;
        lblBantuanTarget.Visible = false;
        //
        // btnBatalPemasukan
        //
        btnBatalPemasukan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnBatalPemasukan.BackColor = Color.White;
        btnBatalPemasukan.Cursor = Cursors.Hand;
        btnBatalPemasukan.FlatAppearance.BorderColor = Color.FromArgb(229, 237, 232);
        btnBatalPemasukan.FlatStyle = FlatStyle.Flat;
        btnBatalPemasukan.ForeColor = Color.FromArgb(38, 73, 68);
        btnBatalPemasukan.Location = new Point(636, 444);
        btnBatalPemasukan.Name = "btnBatalPemasukan";
        btnBatalPemasukan.Size = new Size(92, 40);
        btnBatalPemasukan.TabIndex = 62;
        btnBatalPemasukan.Text = "Batal";
        btnBatalPemasukan.UseVisualStyleBackColor = false;
        //
        // btnSimpanPemasukan
        //
        btnSimpanPemasukan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnSimpanPemasukan.BackColor = Color.FromArgb(21, 125, 104);
        btnSimpanPemasukan.Cursor = Cursors.Hand;
        btnSimpanPemasukan.FlatAppearance.BorderColor = Color.FromArgb(229, 237, 232);
        btnSimpanPemasukan.FlatStyle = FlatStyle.Flat;
        btnSimpanPemasukan.ForeColor = Color.White;
        btnSimpanPemasukan.Location = new Point(740, 444);
        btnSimpanPemasukan.Name = "btnSimpanPemasukan";
        btnSimpanPemasukan.Size = new Size(100, 40);
        btnSimpanPemasukan.TabIndex = 63;
        btnSimpanPemasukan.Text = "Simpan";
        btnSimpanPemasukan.UseVisualStyleBackColor = false;
        //
        // PemasukanControl
        //
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Font = new Font("Segoe UI", 9F);
        AutoScroll = true;
        BackColor = Color.White;
        Controls.Add(lblTitlePemasukan);
        Controls.Add(txtJumlahPemasukanLabel);
        Controls.Add(txtJumlahPemasukan);
        Controls.Add(txtCatatanPemasukanLabel);
        Controls.Add(txtCatatanPemasukan);
        Controls.Add(lblDompetPemasukan);
        Controls.Add(radioTransaksi);
        Controls.Add(radioTarget);
        Controls.Add(lblPilihTargetPemasukan);
        Controls.Add(cmbTargetPemasukan);
        Controls.Add(lblBantuanTarget);
        Controls.Add(btnBatalPemasukan);
        Controls.Add(btnSimpanPemasukan);
        Name = "PemasukanControl";
        Size = new Size(880, 806);

        ResumeLayout(false);
        PerformLayout();
    }
}
