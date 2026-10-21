#nullable enable
namespace UangKu.Controls;

partial class DashboardControl
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblEmptyDashboardTransactions = null!;
    private Label lblTitleDashboard = null!;
    private Label lblRingkasan = null!;
    private Panel cardPemasukan = null!;
    private Label cardPemasukanTitle = null!;
    private Label cardPemasukanAmount = null!;
    private Panel cardPengeluaran = null!;
    private Label cardPengeluaranTitle = null!;
    private Label cardPengeluaranAmount = null!;
    private Panel cardSaldoDashboard = null!;
    private Label cardSaldoDashboardTitle = null!;
    private Label cardSaldoDashboardAmount = null!;
    private Label lblTransaksiTerbaru = null!;
    private Button btnLihatSemua = null!;
    private DataGridView gridDashboard = null!;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5 = null!;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6 = null!;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7 = null!;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8 = null!;
    private Label lblTargetDashboard = null!;
    private Panel pnlProgressDashboard = null!;
    private Panel progressDashboardTrack = null!;
    private Panel progressDashboardFill = null!;
    private Label progressDashboardPercent = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        lblEmptyDashboardTransactions = new Label();
        lblTitleDashboard = new Label();
        lblRingkasan = new Label();
        cardPemasukan = new Panel();
        cardPemasukanTitle = new Label();
        cardPemasukanAmount = new Label();
        cardPengeluaran = new Panel();
        cardPengeluaranTitle = new Label();
        cardPengeluaranAmount = new Label();
        cardSaldoDashboard = new Panel();
        cardSaldoDashboardTitle = new Label();
        cardSaldoDashboardAmount = new Label();
        lblTransaksiTerbaru = new Label();
        btnLihatSemua = new Button();
        gridDashboard = new DataGridView();
        dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
        lblTargetDashboard = new Label();
        pnlProgressDashboard = new Panel();
        progressDashboardTrack = new Panel();
        progressDashboardFill = new Panel();
        progressDashboardPercent = new Label();
        cardPemasukan.SuspendLayout();
        cardPengeluaran.SuspendLayout();
        cardSaldoDashboard.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridDashboard).BeginInit();
        pnlProgressDashboard.SuspendLayout();
        progressDashboardTrack.SuspendLayout();
        SuspendLayout();
        //
        // lblEmptyDashboardTransactions
        //
        lblEmptyDashboardTransactions.BackColor = Color.White;
        lblEmptyDashboardTransactions.Font = new Font("Segoe UI", 10F);
        lblEmptyDashboardTransactions.ForeColor = Color.FromArgb(112, 139, 132);
        lblEmptyDashboardTransactions.Location = new Point(64, 532);
        lblEmptyDashboardTransactions.Name = "lblEmptyDashboardTransactions";
        lblEmptyDashboardTransactions.Size = new Size(752, 40);
        lblEmptyDashboardTransactions.TabIndex = 0;
        lblEmptyDashboardTransactions.Text = "Belum ada transaksi.";
        lblEmptyDashboardTransactions.TextAlign = ContentAlignment.MiddleCenter;
        //
        // lblTitleDashboard
        //
        lblTitleDashboard.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitleDashboard.ForeColor = Color.FromArgb(38, 73, 68);
        lblTitleDashboard.Location = new Point(40, 35);
        lblTitleDashboard.Name = "lblTitleDashboard";
        lblTitleDashboard.Size = new Size(800, 44);
        lblTitleDashboard.TabIndex = 0;
        lblTitleDashboard.Text = "Dashboard";
        lblTitleDashboard.TextAlign = ContentAlignment.MiddleLeft;
        //
        // lblRingkasan
        //
        lblRingkasan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblRingkasan.ForeColor = Color.FromArgb(38, 73, 68);
        lblRingkasan.Location = new Point(40, 88);
        lblRingkasan.Name = "lblRingkasan";
        lblRingkasan.Size = new Size(800, 24);
        lblRingkasan.TabIndex = 1;
        lblRingkasan.Text = "Ringkasan Keuangan";
        lblRingkasan.TextAlign = ContentAlignment.MiddleLeft;
        //
        // cardPemasukan
        //
        cardPemasukan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        cardPemasukan.BackColor = Color.FromArgb(234, 246, 238);
        cardPemasukan.BorderStyle = BorderStyle.FixedSingle;
        cardPemasukan.Controls.Add(cardPemasukanTitle);
        cardPemasukan.Controls.Add(cardPemasukanAmount);
        cardPemasukan.Location = new Point(40, 126);
        cardPemasukan.Name = "cardPemasukan";
        cardPemasukan.Size = new Size(390, 118);
        cardPemasukan.TabIndex = 2;
        //
        // cardPemasukanTitle
        //
        cardPemasukanTitle.Font = new Font("Segoe UI", 8F);
        cardPemasukanTitle.ForeColor = Color.FromArgb(38, 73, 68);
        cardPemasukanTitle.Location = new Point(20, 12);
        cardPemasukanTitle.Name = "cardPemasukanTitle";
        cardPemasukanTitle.Size = new Size(350, 22);
        cardPemasukanTitle.TabIndex = 0;
        cardPemasukanTitle.Text = "TOTAL PEMASUKAN";
        cardPemasukanTitle.TextAlign = ContentAlignment.MiddleLeft;
        //
        // cardPemasukanAmount
        //
        cardPemasukanAmount.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
        cardPemasukanAmount.ForeColor = Color.FromArgb(38, 73, 68);
        cardPemasukanAmount.Location = new Point(20, 40);
        cardPemasukanAmount.Name = "cardPemasukanAmount";
        cardPemasukanAmount.Size = new Size(350, 40);
        cardPemasukanAmount.TabIndex = 1;
        cardPemasukanAmount.Text = "Rp. 0";
        cardPemasukanAmount.TextAlign = ContentAlignment.MiddleLeft;
        //
        // cardPengeluaran
        //
        cardPengeluaran.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        cardPengeluaran.BackColor = Color.FromArgb(255, 243, 233);
        cardPengeluaran.BorderStyle = BorderStyle.FixedSingle;
        cardPengeluaran.Controls.Add(cardPengeluaranTitle);
        cardPengeluaran.Controls.Add(cardPengeluaranAmount);
        cardPengeluaran.Location = new Point(450, 126);
        cardPengeluaran.Name = "cardPengeluaran";
        cardPengeluaran.Size = new Size(390, 118);
        cardPengeluaran.TabIndex = 3;
        //
        // cardPengeluaranTitle
        //
        cardPengeluaranTitle.Font = new Font("Segoe UI", 8F);
        cardPengeluaranTitle.ForeColor = Color.FromArgb(38, 73, 68);
        cardPengeluaranTitle.Location = new Point(20, 12);
        cardPengeluaranTitle.Name = "cardPengeluaranTitle";
        cardPengeluaranTitle.Size = new Size(350, 22);
        cardPengeluaranTitle.TabIndex = 0;
        cardPengeluaranTitle.Text = "TOTAL PENGELUARAN";
        cardPengeluaranTitle.TextAlign = ContentAlignment.MiddleLeft;
        //
        // cardPengeluaranAmount
        //
        cardPengeluaranAmount.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
        cardPengeluaranAmount.ForeColor = Color.FromArgb(38, 73, 68);
        cardPengeluaranAmount.Location = new Point(20, 40);
        cardPengeluaranAmount.Name = "cardPengeluaranAmount";
        cardPengeluaranAmount.Size = new Size(350, 40);
        cardPengeluaranAmount.TabIndex = 1;
        cardPengeluaranAmount.Text = "Rp. 0";
        cardPengeluaranAmount.TextAlign = ContentAlignment.MiddleLeft;
        //
        // cardSaldoDashboard
        //
        cardSaldoDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        cardSaldoDashboard.BackColor = Color.FromArgb(21, 125, 104);
        cardSaldoDashboard.BorderStyle = BorderStyle.FixedSingle;
        cardSaldoDashboard.Controls.Add(cardSaldoDashboardTitle);
        cardSaldoDashboard.Controls.Add(cardSaldoDashboardAmount);
        cardSaldoDashboard.Location = new Point(40, 262);
        cardSaldoDashboard.Name = "cardSaldoDashboard";
        cardSaldoDashboard.Size = new Size(800, 118);
        cardSaldoDashboard.TabIndex = 4;
        //
        // cardSaldoDashboardTitle
        //
        cardSaldoDashboardTitle.Font = new Font("Segoe UI", 8F);
        cardSaldoDashboardTitle.ForeColor = Color.White;
        cardSaldoDashboardTitle.Location = new Point(20, 12);
        cardSaldoDashboardTitle.Name = "cardSaldoDashboardTitle";
        cardSaldoDashboardTitle.Size = new Size(760, 22);
        cardSaldoDashboardTitle.TabIndex = 0;
        cardSaldoDashboardTitle.Text = "SALDO SAAT INI";
        cardSaldoDashboardTitle.TextAlign = ContentAlignment.MiddleLeft;
        //
        // cardSaldoDashboardAmount
        //
        cardSaldoDashboardAmount.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
        cardSaldoDashboardAmount.ForeColor = Color.White;
        cardSaldoDashboardAmount.Location = new Point(20, 40);
        cardSaldoDashboardAmount.Name = "cardSaldoDashboardAmount";
        cardSaldoDashboardAmount.Size = new Size(760, 40);
        cardSaldoDashboardAmount.TabIndex = 1;
        cardSaldoDashboardAmount.Text = "Rp. 0";
        cardSaldoDashboardAmount.TextAlign = ContentAlignment.MiddleLeft;
        //
        // lblTransaksiTerbaru
        //
        lblTransaksiTerbaru.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblTransaksiTerbaru.ForeColor = Color.FromArgb(38, 73, 68);
        lblTransaksiTerbaru.Location = new Point(40, 402);
        lblTransaksiTerbaru.Name = "lblTransaksiTerbaru";
        lblTransaksiTerbaru.Size = new Size(560, 38);
        lblTransaksiTerbaru.TabIndex = 5;
        lblTransaksiTerbaru.Text = "Transaksi Terbaru";
        lblTransaksiTerbaru.TextAlign = ContentAlignment.MiddleLeft;
        //
        // btnLihatSemua
        //
        btnLihatSemua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnLihatSemua.BackColor = Color.White;
        btnLihatSemua.Cursor = Cursors.Hand;
        btnLihatSemua.FlatAppearance.BorderColor = Color.FromArgb(229, 237, 232);
        btnLihatSemua.FlatStyle = FlatStyle.Flat;
        btnLihatSemua.ForeColor = Color.FromArgb(38, 73, 68);
        btnLihatSemua.Location = new Point(708, 402);
        btnLihatSemua.Name = "btnLihatSemua";
        btnLihatSemua.Size = new Size(130, 38);
        btnLihatSemua.TabIndex = 45;
        btnLihatSemua.Text = "Lihat Semua";
        btnLihatSemua.UseVisualStyleBackColor = false;
        //
        // gridDashboard
        //
        gridDashboard.AccessibleName = "";
        gridDashboard.AllowUserToAddRows = false;
        gridDashboard.AllowUserToDeleteRows = false;
        gridDashboard.AllowUserToResizeRows = false;
        gridDashboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridDashboard.BackgroundColor = Color.White;
        gridDashboard.CellBorderStyle = DataGridViewCellBorderStyle.None;
        gridDashboard.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 247, 244);
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(38, 73, 68);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(240, 247, 244);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(38, 73, 68);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        gridDashboard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        gridDashboard.ColumnHeadersHeight = 42;
        gridDashboard.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = SystemColors.Window;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle2.Padding = new Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(197, 232, 218);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(38, 73, 68);
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        gridDashboard.DefaultCellStyle = dataGridViewCellStyle2;
        gridDashboard.EnableHeadersVisualStyles = false;
        gridDashboard.Location = new Point(40, 456);
        gridDashboard.MultiSelect = false;
        gridDashboard.Name = "gridDashboard";
        gridDashboard.ReadOnly = true;
        gridDashboard.RowHeadersVisible = false;
        gridDashboard.RowHeadersWidth = 47;
        gridDashboard.RowTemplate.Height = 46;
        gridDashboard.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        gridDashboard.Size = new Size(800, 210);
        gridDashboard.TabIndex = 46;
        //
        // dataGridViewTextBoxColumn5
        //
        dataGridViewTextBoxColumn5.HeaderText = "Tanggal";
        dataGridViewTextBoxColumn5.MinimumWidth = 6;
        dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
        dataGridViewTextBoxColumn5.ReadOnly = true;
        //
        // dataGridViewTextBoxColumn6
        //
        dataGridViewTextBoxColumn6.HeaderText = "Jenis";
        dataGridViewTextBoxColumn6.MinimumWidth = 6;
        dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
        dataGridViewTextBoxColumn6.ReadOnly = true;
        //
        // dataGridViewTextBoxColumn7
        //
        dataGridViewTextBoxColumn7.HeaderText = "Catatan";
        dataGridViewTextBoxColumn7.MinimumWidth = 6;
        dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
        dataGridViewTextBoxColumn7.ReadOnly = true;
        //
        // dataGridViewTextBoxColumn8
        //
        dataGridViewTextBoxColumn8.HeaderText = "Jumlah";
        dataGridViewTextBoxColumn8.MinimumWidth = 6;
        dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
        dataGridViewTextBoxColumn8.ReadOnly = true;
        //
        // lblTargetDashboard
        //
        lblTargetDashboard.Font = new Font("Segoe UI", 9F);
        lblTargetDashboard.ForeColor = Color.FromArgb(38, 73, 68);
        lblTargetDashboard.Location = new Point(40, 688);
        lblTargetDashboard.Name = "lblTargetDashboard";
        lblTargetDashboard.Size = new Size(800, 26);
        lblTargetDashboard.TabIndex = 47;
        lblTargetDashboard.Text = "Belum ada target keuangan.";
        lblTargetDashboard.TextAlign = ContentAlignment.MiddleLeft;
        //
        // pnlProgressDashboard
        //
        pnlProgressDashboard.Controls.Add(progressDashboardTrack);
        pnlProgressDashboard.Controls.Add(progressDashboardPercent);
        pnlProgressDashboard.Location = new Point(40, 730);
        pnlProgressDashboard.Name = "pnlProgressDashboard";
        pnlProgressDashboard.Size = new Size(800, 40);
        pnlProgressDashboard.TabIndex = 48;
        pnlProgressDashboard.Visible = false;
        //
        // progressDashboardTrack
        //
        progressDashboardTrack.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        progressDashboardTrack.BackColor = Color.FromArgb(201, 221, 213);
        progressDashboardTrack.Controls.Add(progressDashboardFill);
        progressDashboardTrack.Location = new Point(24, 10);
        progressDashboardTrack.Name = "progressDashboardTrack";
        progressDashboardTrack.Size = new Size(688, 9);
        progressDashboardTrack.TabIndex = 0;
        //
        // progressDashboardFill
        //
        progressDashboardFill.BackColor = Color.FromArgb(91, 128, 115);
        progressDashboardFill.Location = new Point(0, 0);
        progressDashboardFill.Name = "progressDashboardFill";
        progressDashboardFill.Size = new Size(0, 9);
        progressDashboardFill.TabIndex = 0;
        //
        // progressDashboardPercent
        //
        progressDashboardPercent.Font = new Font("Segoe UI", 8F);
        progressDashboardPercent.ForeColor = Color.FromArgb(38, 73, 68);
        progressDashboardPercent.Location = new Point(726, 1);
        progressDashboardPercent.Name = "progressDashboardPercent";
        progressDashboardPercent.Size = new Size(60, 26);
        progressDashboardPercent.TabIndex = 1;
        progressDashboardPercent.Text = "0%";
        progressDashboardPercent.TextAlign = ContentAlignment.MiddleLeft;
        //
        // DashboardControl
        //
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Font = new Font("Segoe UI", 9F);
        AutoScroll = true;
        BackColor = Color.White;
        Controls.Add(lblEmptyDashboardTransactions);
        Controls.Add(lblTitleDashboard);
        Controls.Add(lblRingkasan);
        Controls.Add(cardPemasukan);
        Controls.Add(cardPengeluaran);
        Controls.Add(cardSaldoDashboard);
        Controls.Add(lblTransaksiTerbaru);
        Controls.Add(btnLihatSemua);
        Controls.Add(gridDashboard);
        Controls.Add(lblTargetDashboard);
        Controls.Add(pnlProgressDashboard);
        Name = "DashboardControl";
        Size = new Size(880, 806);
        cardPemasukan.ResumeLayout(false);
        cardPengeluaran.ResumeLayout(false);
        cardSaldoDashboard.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridDashboard).EndInit();
        pnlProgressDashboard.ResumeLayout(false);
        progressDashboardTrack.ResumeLayout(false);
        ResumeLayout(false);
    }
}
