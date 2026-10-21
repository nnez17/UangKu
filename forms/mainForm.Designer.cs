#nullable enable
using UangKu.Controls;

namespace UangKu.Forms;

partial class MainForm
{
    private System.ComponentModel.IContainer? components = null;
    private UserControl sidebar = null!;
    private PictureBox picBrand = null!;
    private Label lblBrand = null!;
    private Button btnDashboard = null!;
    private Label lblTransaksi = null!;
    private Button btnPemasukan = null!;
    private Button btnPengeluaran = null!;
    private Label lblInformasi = null!;
    private Button btnSaldo = null!;
    private Button btnRiwayat = null!;
    private Label lblTarget = null!;
    private Button btnTarget = null!;
    private Button btnProgress = null!;
    private UserControl contentHost = null!;
    private DashboardControl pageDashboard = null!;
    private PemasukanControl pagePemasukan = null!;
    private PengeluaranControl pagePengeluaran = null!;
    private SaldoControl pageSaldo = null!;
    private RiwayatControl pageRiwayat = null!;
    private TargetControl pageTarget = null!;
    private TambahTargetControl pageTambahTarget = null!;
    private DetailTargetControl pageDetailTarget = null!;
    private EditTargetControl pageEditTarget = null!;
    private AmbilUangControl pageAmbilUang = null!;
    private ProgressControl pageProgress = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            foreach (var page in pages) page.Dispose();
            components?.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        sidebar = new UserControl();
        picBrand = new PictureBox();
        lblBrand = new Label();
        btnDashboard = new Button();
        lblTransaksi = new Label();
        btnPemasukan = new Button();
        btnPengeluaran = new Button();
        lblInformasi = new Label();
        btnSaldo = new Button();
        btnRiwayat = new Button();
        lblTarget = new Label();
        btnTarget = new Button();
        btnProgress = new Button();
        contentHost = new UserControl();
        pageDashboard = new DashboardControl();
        pagePemasukan = new PemasukanControl();
        pagePengeluaran = new PengeluaranControl();
        pageSaldo = new SaldoControl();
        pageRiwayat = new RiwayatControl();
        pageTarget = new TargetControl();
        pageTambahTarget = new TambahTargetControl();
        pageDetailTarget = new DetailTargetControl();
        pageEditTarget = new EditTargetControl();
        pageAmbilUang = new AmbilUangControl();
        pageProgress = new ProgressControl();
        sidebar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picBrand).BeginInit();
        contentHost.SuspendLayout();
        SuspendLayout();
        //
        // sidebar
        //
        sidebar.BackColor = Color.FromArgb(232, 243, 238);
        sidebar.Controls.Add(picBrand);
        sidebar.Controls.Add(lblBrand);
        sidebar.Controls.Add(btnDashboard);
        sidebar.Controls.Add(lblTransaksi);
        sidebar.Controls.Add(btnPemasukan);
        sidebar.Controls.Add(btnPengeluaran);
        sidebar.Controls.Add(lblInformasi);
        sidebar.Controls.Add(btnSaldo);
        sidebar.Controls.Add(btnRiwayat);
        sidebar.Controls.Add(lblTarget);
        sidebar.Controls.Add(btnTarget);
        sidebar.Controls.Add(btnProgress);
        sidebar.Dock = DockStyle.Left;
        sidebar.Font = new Font("Segoe UI", 12F);
        sidebar.Location = new Point(0, 0);
        sidebar.Name = "sidebar";
        sidebar.Size = new Size(222, 806);
        sidebar.TabIndex = 1;
        //
        // picBrand
        //
        picBrand.AccessibleName = "Logo UangKu";
        picBrand.Image = (Image?)resources.GetObject("picBrand.Image");
        picBrand.Location = new Point(14, 28);
        picBrand.Name = "picBrand";
        picBrand.Size = new Size(40, 40);
        picBrand.SizeMode = PictureBoxSizeMode.Zoom;
        picBrand.TabStop = false;
        //
        // lblBrand
        //
        lblBrand.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblBrand.ForeColor = Color.FromArgb(38, 73, 68);
        lblBrand.Location = new Point(54, 28);
        lblBrand.Name = "lblBrand";
        lblBrand.Size = new Size(154, 40);
        lblBrand.TabIndex = 0;
        lblBrand.Text = "UangKu";
        lblBrand.TextAlign = ContentAlignment.MiddleLeft;
        //
        // btnDashboard
        //
        btnDashboard.BackColor = Color.Transparent;
        btnDashboard.Cursor = Cursors.Hand;
        btnDashboard.FlatAppearance.BorderColor = Color.FromArgb(229, 237, 232);
        btnDashboard.FlatAppearance.BorderSize = 0;
        btnDashboard.FlatStyle = FlatStyle.Flat;
        btnDashboard.Font = new Font("Segoe UI", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnDashboard.ForeColor = Color.FromArgb(38, 73, 68);
        btnDashboard.Location = new Point(12, 76);
        btnDashboard.Name = "btnDashboard";
        btnDashboard.Padding = new Padding(12, 0, 0, 0);
        btnDashboard.Size = new Size(194, 44);
        btnDashboard.TabIndex = 1;
        btnDashboard.Text = "Dashboard";
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
        btnDashboard.UseMnemonic = false;
        btnDashboard.UseVisualStyleBackColor = false;
        //
        // lblTransaksi
        //
        lblTransaksi.Font = new Font("Segoe UI", 8F);
        lblTransaksi.ForeColor = Color.FromArgb(112, 139, 132);
        lblTransaksi.Location = new Point(14, 132);
        lblTransaksi.Name = "lblTransaksi";
        lblTransaksi.Size = new Size(174, 24);
        lblTransaksi.TabIndex = 2;
        lblTransaksi.Text = "TRANSAKSI";
        lblTransaksi.TextAlign = ContentAlignment.MiddleLeft;
        //
        // btnPemasukan
        //
        btnPemasukan.BackColor = Color.FromArgb(232, 243, 238);
        btnPemasukan.Cursor = Cursors.Hand;
        btnPemasukan.FlatAppearance.BorderColor = Color.FromArgb(229, 237, 232);
        btnPemasukan.FlatAppearance.BorderSize = 0;
        btnPemasukan.FlatStyle = FlatStyle.Flat;
        btnPemasukan.Font = new Font("Segoe UI", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnPemasukan.ForeColor = Color.FromArgb(38, 73, 68);
        btnPemasukan.Location = new Point(14, 158);
        btnPemasukan.Name = "btnPemasukan";
        btnPemasukan.Padding = new Padding(12, 0, 0, 0);
        btnPemasukan.Size = new Size(194, 44);
        btnPemasukan.TabIndex = 3;
        btnPemasukan.Text = "Pemasukan";
        btnPemasukan.TextAlign = ContentAlignment.MiddleLeft;
        btnPemasukan.UseVisualStyleBackColor = false;
        //
        // btnPengeluaran
        //
        btnPengeluaran.BackColor = Color.FromArgb(232, 243, 238);
        btnPengeluaran.Cursor = Cursors.Hand;
        btnPengeluaran.FlatAppearance.BorderColor = Color.FromArgb(229, 237, 232);
        btnPengeluaran.FlatAppearance.BorderSize = 0;
        btnPengeluaran.FlatStyle = FlatStyle.Flat;
        btnPengeluaran.Font = new Font("Segoe UI", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnPengeluaran.ForeColor = Color.FromArgb(38, 73, 68);
        btnPengeluaran.Location = new Point(14, 206);
        btnPengeluaran.Name = "btnPengeluaran";
        btnPengeluaran.Padding = new Padding(12, 0, 0, 0);
        btnPengeluaran.Size = new Size(194, 44);
        btnPengeluaran.TabIndex = 4;
        btnPengeluaran.Text = "Pengeluaran";
        btnPengeluaran.TextAlign = ContentAlignment.MiddleLeft;
        btnPengeluaran.UseVisualStyleBackColor = false;
        //
        // lblInformasi
        //
        lblInformasi.Font = new Font("Segoe UI", 8F);
        lblInformasi.ForeColor = Color.FromArgb(112, 139, 132);
        lblInformasi.Location = new Point(14, 268);
        lblInformasi.Name = "lblInformasi";
        lblInformasi.Size = new Size(174, 24);
        lblInformasi.TabIndex = 5;
        lblInformasi.Text = "INFORMASI";
        lblInformasi.TextAlign = ContentAlignment.MiddleLeft;
        //
        // btnSaldo
        //
        btnSaldo.BackColor = Color.FromArgb(232, 243, 238);
        btnSaldo.Cursor = Cursors.Hand;
        btnSaldo.FlatAppearance.BorderColor = Color.FromArgb(229, 237, 232);
        btnSaldo.FlatAppearance.BorderSize = 0;
        btnSaldo.FlatStyle = FlatStyle.Flat;
        btnSaldo.Font = new Font("Segoe UI", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnSaldo.ForeColor = Color.FromArgb(38, 73, 68);
        btnSaldo.Location = new Point(14, 294);
        btnSaldo.Name = "btnSaldo";
        btnSaldo.Padding = new Padding(12, 0, 0, 0);
        btnSaldo.Size = new Size(194, 44);
        btnSaldo.TabIndex = 6;
        btnSaldo.Text = "Saldo";
        btnSaldo.TextAlign = ContentAlignment.MiddleLeft;
        btnSaldo.UseVisualStyleBackColor = false;
        //
        // btnRiwayat
        //
        btnRiwayat.BackColor = Color.FromArgb(232, 243, 238);
        btnRiwayat.Cursor = Cursors.Hand;
        btnRiwayat.FlatAppearance.BorderColor = Color.FromArgb(229, 237, 232);
        btnRiwayat.FlatAppearance.BorderSize = 0;
        btnRiwayat.FlatStyle = FlatStyle.Flat;
        btnRiwayat.Font = new Font("Segoe UI", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnRiwayat.ForeColor = Color.FromArgb(38, 73, 68);
        btnRiwayat.Location = new Point(14, 342);
        btnRiwayat.Name = "btnRiwayat";
        btnRiwayat.Padding = new Padding(12, 0, 0, 0);
        btnRiwayat.Size = new Size(194, 44);
        btnRiwayat.TabIndex = 7;
        btnRiwayat.Text = "Riwayat";
        btnRiwayat.TextAlign = ContentAlignment.MiddleLeft;
        btnRiwayat.UseVisualStyleBackColor = false;
        //
        // lblTarget
        //
        lblTarget.Font = new Font("Segoe UI", 8F);
        lblTarget.ForeColor = Color.FromArgb(112, 139, 132);
        lblTarget.Location = new Point(14, 404);
        lblTarget.Name = "lblTarget";
        lblTarget.Size = new Size(174, 24);
        lblTarget.TabIndex = 8;
        lblTarget.Text = "TARGET";
        lblTarget.TextAlign = ContentAlignment.MiddleLeft;
        //
        // btnTarget
        //
        btnTarget.BackColor = Color.FromArgb(232, 243, 238);
        btnTarget.Cursor = Cursors.Hand;
        btnTarget.FlatAppearance.BorderColor = Color.FromArgb(229, 237, 232);
        btnTarget.FlatAppearance.BorderSize = 0;
        btnTarget.FlatStyle = FlatStyle.Flat;
        btnTarget.Font = new Font("Segoe UI", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnTarget.ForeColor = Color.FromArgb(38, 73, 68);
        btnTarget.Location = new Point(14, 430);
        btnTarget.Name = "btnTarget";
        btnTarget.Padding = new Padding(12, 0, 0, 0);
        btnTarget.Size = new Size(194, 44);
        btnTarget.TabIndex = 9;
        btnTarget.Text = "Target";
        btnTarget.TextAlign = ContentAlignment.MiddleLeft;
        btnTarget.UseVisualStyleBackColor = false;
        //
        // btnProgress
        //
        btnProgress.BackColor = Color.FromArgb(232, 243, 238);
        btnProgress.Cursor = Cursors.Hand;
        btnProgress.FlatAppearance.BorderColor = Color.FromArgb(229, 237, 232);
        btnProgress.FlatAppearance.BorderSize = 0;
        btnProgress.FlatStyle = FlatStyle.Flat;
        btnProgress.Font = new Font("Segoe UI", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnProgress.ForeColor = Color.FromArgb(38, 73, 68);
        btnProgress.Location = new Point(14, 478);
        btnProgress.Name = "btnProgress";
        btnProgress.Padding = new Padding(12, 0, 0, 0);
        btnProgress.Size = new Size(194, 44);
        btnProgress.TabIndex = 10;
        btnProgress.Text = "Progress";
        btnProgress.TextAlign = ContentAlignment.MiddleLeft;
        btnProgress.UseVisualStyleBackColor = false;
        //
        // contentHost
        //
        contentHost.BackColor = Color.White;
        contentHost.Controls.Add(pageDashboard);
        contentHost.Dock = DockStyle.Fill;
        contentHost.Location = new Point(222, 0);
        contentHost.Name = "contentHost";
        contentHost.Size = new Size(880, 806);
        contentHost.TabIndex = 0;
        pageDashboard.Dock = DockStyle.Fill;
        pageDashboard.Name = "pageDashboard";
        pagePemasukan.Dock = DockStyle.Fill;
        pagePemasukan.Name = "pagePemasukan";
        pagePengeluaran.Dock = DockStyle.Fill;
        pagePengeluaran.Name = "pagePengeluaran";
        pageSaldo.Dock = DockStyle.Fill;
        pageSaldo.Name = "pageSaldo";
        pageRiwayat.Dock = DockStyle.Fill;
        pageRiwayat.Name = "pageRiwayat";
        pageTarget.Dock = DockStyle.Fill;
        pageTarget.Name = "pageTarget";
        pageTambahTarget.Dock = DockStyle.Fill;
        pageTambahTarget.Name = "pageTambahTarget";
        pageDetailTarget.Dock = DockStyle.Fill;
        pageDetailTarget.Name = "pageDetailTarget";
        pageEditTarget.Dock = DockStyle.Fill;
        pageEditTarget.Name = "pageEditTarget";
        pageAmbilUang.Dock = DockStyle.Fill;
        pageAmbilUang.Name = "pageAmbilUang";
        pageProgress.Dock = DockStyle.Fill;
        pageProgress.Name = "pageProgress";
        //
        // MainForm
        //
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1102, 806);
        Controls.Add(contentHost);
        Controls.Add(sidebar);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon?)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "UangKu";
        sidebar.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)picBrand).EndInit();
        contentHost.ResumeLayout(false);
        ResumeLayout(false);
    }
}
