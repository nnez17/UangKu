#nullable enable
namespace UangKu.Controls;

partial class AmbilUangControl
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitleAmbilUang = null!;
    private Panel pnlOverlayAmbil = null!;
    private Panel cardKonfirmasi = null!;
    private Label lblJudulKonfirmasi = null!;
    private Label lblPesanKonfirmasi = null!;
    private Button btnBatalAmbil = null!;
    private Button btnKonfirmasiAmbil = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitleAmbilUang = new Label();
        pnlOverlayAmbil = new Panel();
        cardKonfirmasi = new Panel();
        lblJudulKonfirmasi = new Label();
        lblPesanKonfirmasi = new Label();
        btnBatalAmbil = new Button();
        btnKonfirmasiAmbil = new Button();
        pnlOverlayAmbil.SuspendLayout();
        cardKonfirmasi.SuspendLayout();
        SuspendLayout();
        //
        // lblTitleAmbilUang
        //
        lblTitleAmbilUang.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitleAmbilUang.ForeColor = Color.FromArgb(38, 73, 68);
        lblTitleAmbilUang.Location = new Point(40, 32);
        lblTitleAmbilUang.Name = "lblTitleAmbilUang";
        lblTitleAmbilUang.Size = new Size(800, 44);
        lblTitleAmbilUang.TabIndex = 0;
        lblTitleAmbilUang.Text = "Detail Target";
        lblTitleAmbilUang.TextAlign = ContentAlignment.MiddleLeft;
        //
        // pnlOverlayAmbil
        //
        pnlOverlayAmbil.BackColor = Color.FromArgb(240, 247, 244);
        pnlOverlayAmbil.Controls.Add(cardKonfirmasi);
        pnlOverlayAmbil.Location = new Point(40, 110);
        pnlOverlayAmbil.Name = "pnlOverlayAmbil";
        pnlOverlayAmbil.Size = new Size(800, 570);
        pnlOverlayAmbil.TabIndex = 1;
        //
        // cardKonfirmasi
        //
        cardKonfirmasi.BackColor = Color.White;
        cardKonfirmasi.BorderStyle = BorderStyle.FixedSingle;
        cardKonfirmasi.Controls.Add(lblJudulKonfirmasi);
        cardKonfirmasi.Controls.Add(lblPesanKonfirmasi);
        cardKonfirmasi.Controls.Add(btnBatalAmbil);
        cardKonfirmasi.Controls.Add(btnKonfirmasiAmbil);
        cardKonfirmasi.Location = new Point(120, 160);
        cardKonfirmasi.Name = "cardKonfirmasi";
        cardKonfirmasi.Size = new Size(558, 244);
        cardKonfirmasi.TabIndex = 0;
        //
        // lblJudulKonfirmasi
        //
        lblJudulKonfirmasi.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblJudulKonfirmasi.ForeColor = Color.FromArgb(38, 73, 68);
        lblJudulKonfirmasi.Location = new Point(24, 20);
        lblJudulKonfirmasi.Name = "lblJudulKonfirmasi";
        lblJudulKonfirmasi.Size = new Size(510, 32);
        lblJudulKonfirmasi.TabIndex = 0;
        lblJudulKonfirmasi.Text = "Ambil Uang";
        lblJudulKonfirmasi.TextAlign = ContentAlignment.MiddleLeft;
        //
        // lblPesanKonfirmasi
        //
        lblPesanKonfirmasi.Font = new Font("Segoe UI", 11F);
        lblPesanKonfirmasi.ForeColor = Color.FromArgb(38, 73, 68);
        lblPesanKonfirmasi.Location = new Point(24, 70);
        lblPesanKonfirmasi.Name = "lblPesanKonfirmasi";
        lblPesanKonfirmasi.Size = new Size(510, 86);
        lblPesanKonfirmasi.TabIndex = 1;
        lblPesanKonfirmasi.Text = "Belum ada target yang dapat diambil.";
        lblPesanKonfirmasi.TextAlign = ContentAlignment.MiddleLeft;
        //
        // btnBatalAmbil
        //
        btnBatalAmbil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnBatalAmbil.BackColor = Color.White;
        btnBatalAmbil.Cursor = Cursors.Hand;
        btnBatalAmbil.FlatAppearance.BorderColor = Color.FromArgb(229, 237, 232);
        btnBatalAmbil.FlatStyle = FlatStyle.Flat;
        btnBatalAmbil.ForeColor = Color.FromArgb(38, 73, 68);
        btnBatalAmbil.Location = new Point(330, 178);
        btnBatalAmbil.Name = "btnBatalAmbil";
        btnBatalAmbil.Size = new Size(88, 40);
        btnBatalAmbil.TabIndex = 138;
        btnBatalAmbil.Text = "Batal";
        btnBatalAmbil.UseVisualStyleBackColor = false;
        //
        // btnKonfirmasiAmbil
        //
        btnKonfirmasiAmbil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnKonfirmasiAmbil.BackColor = Color.FromArgb(21, 125, 104);
        btnKonfirmasiAmbil.Cursor = Cursors.Hand;
        btnKonfirmasiAmbil.Enabled = false;
        btnKonfirmasiAmbil.FlatAppearance.BorderColor = Color.FromArgb(229, 237, 232);
        btnKonfirmasiAmbil.FlatStyle = FlatStyle.Flat;
        btnKonfirmasiAmbil.ForeColor = Color.White;
        btnKonfirmasiAmbil.Location = new Point(430, 178);
        btnKonfirmasiAmbil.Name = "btnKonfirmasiAmbil";
        btnKonfirmasiAmbil.Size = new Size(100, 40);
        btnKonfirmasiAmbil.TabIndex = 139;
        btnKonfirmasiAmbil.Text = "Ambil";
        btnKonfirmasiAmbil.UseVisualStyleBackColor = false;
        //
        // AmbilUangControl
        //
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Font = new Font("Segoe UI", 9F);
        AutoScroll = true;
        BackColor = Color.White;
        Controls.Add(lblTitleAmbilUang);
        Controls.Add(pnlOverlayAmbil);
        Name = "AmbilUangControl";
        Size = new Size(880, 806);
        pnlOverlayAmbil.ResumeLayout(false);
        cardKonfirmasi.ResumeLayout(false);
        ResumeLayout(false);
    }
}
