#nullable enable
namespace UangKu.Controls;

partial class RiwayatControl
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblEmptyRiwayat = null!;
    private Label lblTitleRiwayat = null!;
    private Label lblFilterJenis = null!;
    private ComboBox cmbFilterJenis = null!;
    private Label lblFilterDompet = null!;
    private ComboBox cmbFilterDompet = null!;
    private Label lblFilterPeriode = null!;
    private ComboBox cmbFilterPeriode = null!;
    private DataGridView gridRiwayat = null!;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1 = null!;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = null!;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3 = null!;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4 = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        lblEmptyRiwayat = new Label();
        lblTitleRiwayat = new Label();
        lblFilterJenis = new Label();
        cmbFilterJenis = new ComboBox();
        lblFilterDompet = new Label();
        cmbFilterDompet = new ComboBox();
        lblFilterPeriode = new Label();
        cmbFilterPeriode = new ComboBox();
        gridRiwayat = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)gridRiwayat).BeginInit();
        SuspendLayout();
        //
        // lblEmptyRiwayat
        //
        lblEmptyRiwayat.BackColor = Color.White;
        lblEmptyRiwayat.Font = new Font("Segoe UI", 10F);
        lblEmptyRiwayat.ForeColor = Color.FromArgb(112, 139, 132);
        lblEmptyRiwayat.Location = new Point(64, 278);
        lblEmptyRiwayat.Name = "lblEmptyRiwayat";
        lblEmptyRiwayat.Size = new Size(752, 40);
        lblEmptyRiwayat.TabIndex = 0;
        lblEmptyRiwayat.Text = "Belum ada riwayat transaksi.";
        lblEmptyRiwayat.TextAlign = ContentAlignment.MiddleCenter;
        //
        // lblTitleRiwayat
        //
        lblTitleRiwayat.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitleRiwayat.ForeColor = Color.FromArgb(38, 73, 68);
        lblTitleRiwayat.Location = new Point(40, 32);
        lblTitleRiwayat.Name = "lblTitleRiwayat";
        lblTitleRiwayat.Size = new Size(800, 44);
        lblTitleRiwayat.TabIndex = 0;
        lblTitleRiwayat.Text = "Riwayat Transaksi";
        lblTitleRiwayat.TextAlign = ContentAlignment.MiddleLeft;
        //
        // lblFilterJenis
        //
        lblFilterJenis.Font = new Font("Segoe UI", 9F);
        lblFilterJenis.ForeColor = Color.FromArgb(38, 73, 68);
        lblFilterJenis.Location = new Point(40, 104);
        lblFilterJenis.Name = "lblFilterJenis";
        lblFilterJenis.Size = new Size(254, 24);
        lblFilterJenis.TabIndex = 1;
        lblFilterJenis.Text = "Jenis";
        lblFilterJenis.TextAlign = ContentAlignment.MiddleLeft;
        //
        // cmbFilterJenis
        //
        cmbFilterJenis.AccessibleName = "";
        cmbFilterJenis.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbFilterJenis.Items.AddRange(new object[] { "Semua Jenis", "Pemasukan", "Pengeluaran" });
        cmbFilterJenis.Location = new Point(40, 134);
        cmbFilterJenis.Name = "cmbFilterJenis";
        cmbFilterJenis.Size = new Size(254, 27);
        cmbFilterJenis.TabIndex = 85;
        //
        // lblFilterDompet
        //
        lblFilterDompet.Font = new Font("Segoe UI", 9F);
        lblFilterDompet.ForeColor = Color.FromArgb(38, 73, 68);
        lblFilterDompet.Location = new Point(312, 104);
        lblFilterDompet.Name = "lblFilterDompet";
        lblFilterDompet.Size = new Size(254, 24);
        lblFilterDompet.TabIndex = 86;
        lblFilterDompet.Text = "Dompet";
        lblFilterDompet.TextAlign = ContentAlignment.MiddleLeft;
        //
        // cmbFilterDompet
        //
        cmbFilterDompet.AccessibleName = "";
        cmbFilterDompet.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbFilterDompet.Items.AddRange(new object[] { "Semua Dompet", "Dompet Transaksi", "Dompet Target" });
        cmbFilterDompet.Location = new Point(312, 134);
        cmbFilterDompet.Name = "cmbFilterDompet";
        cmbFilterDompet.Size = new Size(254, 27);
        cmbFilterDompet.TabIndex = 87;
        //
        // lblFilterPeriode
        //
        lblFilterPeriode.Font = new Font("Segoe UI", 9F);
        lblFilterPeriode.ForeColor = Color.FromArgb(38, 73, 68);
        lblFilterPeriode.Location = new Point(584, 104);
        lblFilterPeriode.Name = "lblFilterPeriode";
        lblFilterPeriode.Size = new Size(254, 24);
        lblFilterPeriode.TabIndex = 88;
        lblFilterPeriode.Text = "Periode";
        lblFilterPeriode.TextAlign = ContentAlignment.MiddleLeft;
        //
        // cmbFilterPeriode
        //
        cmbFilterPeriode.AccessibleName = "";
        cmbFilterPeriode.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbFilterPeriode.Items.AddRange(new object[] { "Bulan", "Minggu", "Tahun" });
        cmbFilterPeriode.Location = new Point(584, 134);
        cmbFilterPeriode.Name = "cmbFilterPeriode";
        cmbFilterPeriode.Size = new Size(254, 27);
        cmbFilterPeriode.TabIndex = 89;
        //
        // gridRiwayat
        //
        gridRiwayat.AccessibleName = "";
        gridRiwayat.AllowUserToAddRows = false;
        gridRiwayat.AllowUserToDeleteRows = false;
        gridRiwayat.AllowUserToResizeRows = false;
        gridRiwayat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        gridRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridRiwayat.BackgroundColor = Color.White;
        gridRiwayat.CellBorderStyle = DataGridViewCellBorderStyle.None;
        gridRiwayat.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.FromArgb(240, 247, 244);
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(38, 73, 68);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(240, 247, 244);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(38, 73, 68);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        gridRiwayat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
        gridRiwayat.ColumnHeadersHeight = 42;
        gridRiwayat.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = SystemColors.Window;
        dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle4.Padding = new Padding(12, 0, 0, 0);
        dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(197, 232, 218);
        dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(38, 73, 68);
        dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
        gridRiwayat.DefaultCellStyle = dataGridViewCellStyle4;
        gridRiwayat.EnableHeadersVisualStyles = false;
        gridRiwayat.Location = new Point(40, 202);
        gridRiwayat.MultiSelect = false;
        gridRiwayat.Name = "gridRiwayat";
        gridRiwayat.ReadOnly = true;
        gridRiwayat.RowHeadersVisible = false;
        gridRiwayat.RowHeadersWidth = 47;
        gridRiwayat.RowTemplate.Height = 46;
        gridRiwayat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        gridRiwayat.Size = new Size(800, 210);
        gridRiwayat.TabIndex = 90;
        //
        // dataGridViewTextBoxColumn1
        //
        dataGridViewTextBoxColumn1.HeaderText = "Tanggal";
        dataGridViewTextBoxColumn1.MinimumWidth = 6;
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        //
        // dataGridViewTextBoxColumn2
        //
        dataGridViewTextBoxColumn2.HeaderText = "Jenis";
        dataGridViewTextBoxColumn2.MinimumWidth = 6;
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.ReadOnly = true;
        //
        // dataGridViewTextBoxColumn3
        //
        dataGridViewTextBoxColumn3.HeaderText = "Catatan";
        dataGridViewTextBoxColumn3.MinimumWidth = 6;
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        dataGridViewTextBoxColumn3.ReadOnly = true;
        //
        // dataGridViewTextBoxColumn4
        //
        dataGridViewTextBoxColumn4.HeaderText = "Jumlah";
        dataGridViewTextBoxColumn4.MinimumWidth = 6;
        dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
        dataGridViewTextBoxColumn4.ReadOnly = true;
        //
        // RiwayatControl
        //
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Font = new Font("Segoe UI", 9F);
        AutoScroll = true;
        BackColor = Color.White;
        Controls.Add(lblEmptyRiwayat);
        Controls.Add(lblTitleRiwayat);
        Controls.Add(lblFilterJenis);
        Controls.Add(cmbFilterJenis);
        Controls.Add(lblFilterDompet);
        Controls.Add(cmbFilterDompet);
        Controls.Add(lblFilterPeriode);
        Controls.Add(cmbFilterPeriode);
        Controls.Add(gridRiwayat);
        Name = "RiwayatControl";
        Size = new Size(880, 806);
        ((System.ComponentModel.ISupportInitialize)gridRiwayat).EndInit();
        ResumeLayout(false);
    }
}
