#nullable enable
namespace UangKu.Controls;

partial class PengeluaranControl
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitlePengeluaran = null!;
    private Label lblDompetPengeluaran = null!;
    private TextBox txtDompetPengeluaran = null!;
    private Panel cardSaldoPengeluaran = null!;
    private Label cardSaldoPengeluaranTitle = null!;
    private Label cardSaldoPengeluaranAmount = null!;
    private Label txtJumlahPengeluaranLabel = null!;
    private TextBox txtJumlahPengeluaran = null!;
    private Label txtCatatanPengeluaranLabel = null!;
    private TextBox txtCatatanPengeluaran = null!;
    private Button btnBatalPengeluaran = null!;
    private Button btnSimpanPengeluaran = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitlePengeluaran = new Label();
        lblDompetPengeluaran = new Label();
        txtDompetPengeluaran = new TextBox();
        cardSaldoPengeluaran = new Panel();
        cardSaldoPengeluaranTitle = new Label();
        cardSaldoPengeluaranAmount = new Label();
        txtJumlahPengeluaranLabel = new Label();
        txtJumlahPengeluaran = new TextBox();
        txtCatatanPengeluaranLabel = new Label();
        txtCatatanPengeluaran = new TextBox();
        btnBatalPengeluaran = new Button();
        btnSimpanPengeluaran = new Button();
        cardSaldoPengeluaran.SuspendLayout();
        SuspendLayout();
        //
        // lblTitlePengeluaran
        //
        lblTitlePengeluaran.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitlePengeluaran.ForeColor = Color.FromArgb(38, 73, 68);
        lblTitlePengeluaran.Location = new Point(40, 32);
        lblTitlePengeluaran.Name = "lblTitlePengeluaran";
        lblTitlePengeluaran.Size = new Size(800, 44);
        lblTitlePengeluaran.TabIndex = 0;
        lblTitlePengeluaran.Text = "Mencatat Pengeluaran";
        lblTitlePengeluaran.TextAlign = ContentAlignment.MiddleLeft;
        //
        // lblDompetPengeluaran
        //
        lblDompetPengeluaran.Font = new Font("Segoe UI", 9F);
        lblDompetPengeluaran.ForeColor = Color.FromArgb(38, 73, 68);
        lblDompetPengeluaran.Location = new Point(40, 100);
        lblDompetPengeluaran.Name = "lblDompetPengeluaran";
        lblDompetPengeluaran.Size = new Size(800, 24);
        lblDompetPengeluaran.TabIndex = 1;
        lblDompetPengeluaran.Text = "Dompet Dana";
        lblDompetPengeluaran.TextAlign = ContentAlignment.MiddleLeft;
        //
        // txtDompetPengeluaran
        //
        txtDompetPengeluaran.BackColor = Color.FromArgb(240, 247, 244);
        txtDompetPengeluaran.BorderStyle = BorderStyle.FixedSingle;
        txtDompetPengeluaran.Location = new Point(40, 130);
        txtDompetPengeluaran.Multiline = true;
        txtDompetPengeluaran.Name = "txtDompetPengeluaran";
        txtDompetPengeluaran.ReadOnly = true;
        txtDompetPengeluaran.Size = new Size(800, 40);
        txtDompetPengeluaran.TabIndex = 2;
        txtDompetPengeluaran.TabStop = false;
        txtDompetPengeluaran.Text = "Dompet Transaksi";
        //
        // cardSaldoPengeluaran
        //
        cardSaldoPengeluaran.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        cardSaldoPengeluaran.BackColor = Color.White;
        cardSaldoPengeluaran.BorderStyle = BorderStyle.FixedSingle;
        cardSaldoPengeluaran.Controls.Add(cardSaldoPengeluaranTitle);
        cardSaldoPengeluaran.Controls.Add(cardSaldoPengeluaranAmount);
        cardSaldoPengeluaran.Location = new Point(40, 196);
        cardSaldoPengeluaran.Name = "cardSaldoPengeluaran";
        cardSaldoPengeluaran.Size = new Size(800, 118);
        cardSaldoPengeluaran.TabIndex = 3;
        //
        // cardSaldoPengeluaranTitle
        //
        cardSaldoPengeluaranTitle.Font = new Font("Segoe UI", 8F);
        cardSaldoPengeluaranTitle.ForeColor = Color.FromArgb(38, 73, 68);
        cardSaldoPengeluaranTitle.Location = new Point(20, 12);
        cardSaldoPengeluaranTitle.Name = "cardSaldoPengeluaranTitle";
        cardSaldoPengeluaranTitle.Size = new Size(760, 22);
        cardSaldoPengeluaranTitle.TabIndex = 0;
        cardSaldoPengeluaranTitle.Text = "SALDO SAAT INI";
        cardSaldoPengeluaranTitle.TextAlign = ContentAlignment.MiddleLeft;
        //
        // cardSaldoPengeluaranAmount
        //
        cardSaldoPengeluaranAmount.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
        cardSaldoPengeluaranAmount.ForeColor = Color.FromArgb(38, 73, 68);
        cardSaldoPengeluaranAmount.Location = new Point(20, 40);
        cardSaldoPengeluaranAmount.Name = "cardSaldoPengeluaranAmount";
        cardSaldoPengeluaranAmount.Size = new Size(760, 40);
        cardSaldoPengeluaranAmount.TabIndex = 1;
        cardSaldoPengeluaranAmount.Text = "Rp. 0";
        cardSaldoPengeluaranAmount.TextAlign = ContentAlignment.MiddleLeft;
        //
        // txtJumlahPengeluaranLabel
        //
        txtJumlahPengeluaranLabel.Font = new Font("Segoe UI", 9F);
        txtJumlahPengeluaranLabel.ForeColor = Color.FromArgb(38, 73, 68);
        txtJumlahPengeluaranLabel.Location = new Point(40, 340);
        txtJumlahPengeluaranLabel.Name = "txtJumlahPengeluaranLabel";
        txtJumlahPengeluaranLabel.Size = new Size(800, 24);
        txtJumlahPengeluaranLabel.TabIndex = 4;
        txtJumlahPengeluaranLabel.Text = "Jumlah";
        txtJumlahPengeluaranLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // txtJumlahPengeluaran
        //
        txtJumlahPengeluaran.AccessibleName = "";
        txtJumlahPengeluaran.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtJumlahPengeluaran.BorderStyle = BorderStyle.FixedSingle;
        txtJumlahPengeluaran.Location = new Point(40, 370);
        txtJumlahPengeluaran.Multiline = true;
        txtJumlahPengeluaran.Name = "txtJumlahPengeluaran";
        txtJumlahPengeluaran.PlaceholderText = "Rp 0";
        txtJumlahPengeluaran.Size = new Size(800, 40);
        txtJumlahPengeluaran.TabIndex = 70;
        //
        // txtCatatanPengeluaranLabel
        //
        txtCatatanPengeluaranLabel.Font = new Font("Segoe UI", 9F);
        txtCatatanPengeluaranLabel.ForeColor = Color.FromArgb(38, 73, 68);
        txtCatatanPengeluaranLabel.Location = new Point(40, 430);
        txtCatatanPengeluaranLabel.Name = "txtCatatanPengeluaranLabel";
        txtCatatanPengeluaranLabel.Size = new Size(800, 24);
        txtCatatanPengeluaranLabel.TabIndex = 71;
        txtCatatanPengeluaranLabel.Text = "Catatan";
        txtCatatanPengeluaranLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // txtCatatanPengeluaran
        //
        txtCatatanPengeluaran.AccessibleName = "";
        txtCatatanPengeluaran.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtCatatanPengeluaran.BorderStyle = BorderStyle.FixedSingle;
        txtCatatanPengeluaran.Location = new Point(40, 460);
        txtCatatanPengeluaran.Multiline = true;
        txtCatatanPengeluaran.Name = "txtCatatanPengeluaran";
        txtCatatanPengeluaran.Size = new Size(800, 100);
        txtCatatanPengeluaran.TabIndex = 72;
        //
        // btnBatalPengeluaran
        //
        btnBatalPengeluaran.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnBatalPengeluaran.BackColor = Color.White;
        btnBatalPengeluaran.Cursor = Cursors.Hand;
        btnBatalPengeluaran.FlatAppearance.BorderColor = Color.FromArgb(229, 237, 232);
        btnBatalPengeluaran.FlatStyle = FlatStyle.Flat;
        btnBatalPengeluaran.ForeColor = Color.FromArgb(38, 73, 68);
        btnBatalPengeluaran.Location = new Point(634, 596);
        btnBatalPengeluaran.Name = "btnBatalPengeluaran";
        btnBatalPengeluaran.Size = new Size(92, 40);
        btnBatalPengeluaran.TabIndex = 73;
        btnBatalPengeluaran.Text = "Batal";
        btnBatalPengeluaran.UseVisualStyleBackColor = false;
        //
        // btnSimpanPengeluaran
        //
        btnSimpanPengeluaran.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnSimpanPengeluaran.BackColor = Color.FromArgb(21, 125, 104);
        btnSimpanPengeluaran.Cursor = Cursors.Hand;
        btnSimpanPengeluaran.FlatAppearance.BorderColor = Color.FromArgb(229, 237, 232);
        btnSimpanPengeluaran.FlatStyle = FlatStyle.Flat;
        btnSimpanPengeluaran.ForeColor = Color.White;
        btnSimpanPengeluaran.Location = new Point(738, 596);
        btnSimpanPengeluaran.Name = "btnSimpanPengeluaran";
        btnSimpanPengeluaran.Size = new Size(100, 40);
        btnSimpanPengeluaran.TabIndex = 74;
        btnSimpanPengeluaran.Text = "Simpan";
        btnSimpanPengeluaran.UseVisualStyleBackColor = false;
        //
        // PengeluaranControl
        //
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Font = new Font("Segoe UI", 9F);
        AutoScroll = true;
        BackColor = Color.White;
        Controls.Add(lblTitlePengeluaran);
        Controls.Add(lblDompetPengeluaran);
        Controls.Add(txtDompetPengeluaran);
        Controls.Add(cardSaldoPengeluaran);
        Controls.Add(txtJumlahPengeluaranLabel);
        Controls.Add(txtJumlahPengeluaran);
        Controls.Add(txtCatatanPengeluaranLabel);
        Controls.Add(txtCatatanPengeluaran);
        Controls.Add(btnBatalPengeluaran);
        Controls.Add(btnSimpanPengeluaran);
        Name = "PengeluaranControl";
        Size = new Size(880, 806);
        cardSaldoPengeluaran.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }
}
