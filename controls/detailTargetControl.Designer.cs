#nullable enable
namespace UangKu.Controls;

partial class DetailTargetControl
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitleDetailTarget = null!;
    private Button btnKembaliTarget = null!;
    private Panel cardDetailTarget = null!;
    private Label lblNamaDetail = null!;
    private Label lblTerkumpulDetail = null!;
    private Label lblNominalDetail = null!;
    private Panel progressDetailTrack = null!;
    private Panel progressDetailFill = null!;
    private Label progressDetailPercent = null!;
    private Label lblCaptionTerkumpul = null!;
    private Label lblNilaiTerkumpul = null!;
    private Label lblCaptionNominal = null!;
    private Label lblNilaiNominal = null!;
    private Button btnEditTarget = null!;
    private Button btnAmbilUang = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitleDetailTarget = new Label();
        btnKembaliTarget = new Button();
        cardDetailTarget = new Panel();
        lblNamaDetail = new Label();
        lblTerkumpulDetail = new Label();
        lblNominalDetail = new Label();
        progressDetailTrack = new Panel();
        progressDetailFill = new Panel();
        progressDetailPercent = new Label();
        lblCaptionTerkumpul = new Label();
        lblNilaiTerkumpul = new Label();
        lblCaptionNominal = new Label();
        lblNilaiNominal = new Label();
        btnEditTarget = new Button();
        btnAmbilUang = new Button();
        cardDetailTarget.SuspendLayout();
        progressDetailTrack.SuspendLayout();
        SuspendLayout();
        //
        // lblTitleDetailTarget
        //
        lblTitleDetailTarget.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitleDetailTarget.ForeColor = Color.FromArgb(38, 73, 68);
        lblTitleDetailTarget.Location = new Point(40, 32);
        lblTitleDetailTarget.Name = "lblTitleDetailTarget";
        lblTitleDetailTarget.Size = new Size(800, 44);
        lblTitleDetailTarget.TabIndex = 0;
        lblTitleDetailTarget.Text = "Detail Target";
        lblTitleDetailTarget.TextAlign = ContentAlignment.MiddleLeft;
        //
        // btnKembaliTarget
        //
        btnKembaliTarget.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnKembaliTarget.BackColor = Color.White;
        btnKembaliTarget.Cursor = Cursors.Hand;
        btnKembaliTarget.FlatAppearance.BorderColor = Color.FromArgb(229, 237, 232);
        btnKembaliTarget.FlatStyle = FlatStyle.Flat;
        btnKembaliTarget.ForeColor = Color.FromArgb(38, 73, 68);
        btnKembaliTarget.Location = new Point(40, 96);
        btnKembaliTarget.Name = "btnKembaliTarget";
        btnKembaliTarget.Size = new Size(112, 40);
        btnKembaliTarget.TabIndex = 120;
        btnKembaliTarget.Text = "‹ Kembali";
        btnKembaliTarget.UseVisualStyleBackColor = false;
        //
        // cardDetailTarget
        //
        cardDetailTarget.BorderStyle = BorderStyle.FixedSingle;
        cardDetailTarget.Controls.Add(lblNamaDetail);
        cardDetailTarget.Controls.Add(lblTerkumpulDetail);
        cardDetailTarget.Controls.Add(lblNominalDetail);
        cardDetailTarget.Controls.Add(progressDetailTrack);
        cardDetailTarget.Controls.Add(progressDetailPercent);
        cardDetailTarget.Controls.Add(lblCaptionTerkumpul);
        cardDetailTarget.Controls.Add(lblNilaiTerkumpul);
        cardDetailTarget.Controls.Add(lblCaptionNominal);
        cardDetailTarget.Controls.Add(lblNilaiNominal);
        cardDetailTarget.Controls.Add(btnEditTarget);
        cardDetailTarget.Controls.Add(btnAmbilUang);
        cardDetailTarget.Location = new Point(40, 158);
        cardDetailTarget.Name = "cardDetailTarget";
        cardDetailTarget.Size = new Size(800, 466);
        cardDetailTarget.TabIndex = 121;
        //
        // lblNamaDetail
        //
        lblNamaDetail.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
        lblNamaDetail.ForeColor = Color.FromArgb(38, 73, 68);
        lblNamaDetail.Location = new Point(24, 28);
        lblNamaDetail.Name = "lblNamaDetail";
        lblNamaDetail.Size = new Size(750, 44);
        lblNamaDetail.TabIndex = 0;
        lblNamaDetail.Text = "Belum ada target dipilih.";
        lblNamaDetail.TextAlign = ContentAlignment.MiddleCenter;
        //
        // lblTerkumpulDetail
        //
        lblTerkumpulDetail.Font = new Font("Segoe UI", 29F, FontStyle.Bold);
        lblTerkumpulDetail.ForeColor = Color.FromArgb(38, 73, 68);
        lblTerkumpulDetail.Location = new Point(24, 94);
        lblTerkumpulDetail.Name = "lblTerkumpulDetail";
        lblTerkumpulDetail.Size = new Size(750, 60);
        lblTerkumpulDetail.TabIndex = 1;
        lblTerkumpulDetail.Text = "Rp. 0";
        lblTerkumpulDetail.TextAlign = ContentAlignment.MiddleCenter;
        //
        // lblNominalDetail
        //
        lblNominalDetail.Font = new Font("Segoe UI", 18F);
        lblNominalDetail.ForeColor = Color.FromArgb(38, 73, 68);
        lblNominalDetail.Location = new Point(24, 168);
        lblNominalDetail.Name = "lblNominalDetail";
        lblNominalDetail.Size = new Size(750, 42);
        lblNominalDetail.TabIndex = 2;
        lblNominalDetail.Text = "/ Rp. 0";
        lblNominalDetail.TextAlign = ContentAlignment.MiddleCenter;
        //
        // progressDetailTrack
        //
        progressDetailTrack.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        progressDetailTrack.BackColor = Color.FromArgb(201, 221, 213);
        progressDetailTrack.Controls.Add(progressDetailFill);
        progressDetailTrack.Location = new Point(24, 244);
        progressDetailTrack.Name = "progressDetailTrack";
        progressDetailTrack.Size = new Size(688, 9);
        progressDetailTrack.TabIndex = 3;
        //
        // progressDetailFill
        //
        progressDetailFill.BackColor = Color.FromArgb(91, 128, 115);
        progressDetailFill.Location = new Point(0, 0);
        progressDetailFill.Name = "progressDetailFill";
        progressDetailFill.Size = new Size(0, 9);
        progressDetailFill.TabIndex = 0;
        //
        // progressDetailPercent
        //
        progressDetailPercent.Font = new Font("Segoe UI", 8F);
        progressDetailPercent.ForeColor = Color.FromArgb(38, 73, 68);
        progressDetailPercent.Location = new Point(726, 235);
        progressDetailPercent.Name = "progressDetailPercent";
        progressDetailPercent.Size = new Size(60, 26);
        progressDetailPercent.TabIndex = 4;
        progressDetailPercent.Text = "0%";
        progressDetailPercent.TextAlign = ContentAlignment.MiddleLeft;
        //
        // lblCaptionTerkumpul
        //
        lblCaptionTerkumpul.Font = new Font("Segoe UI", 10F);
        lblCaptionTerkumpul.ForeColor = Color.FromArgb(38, 73, 68);
        lblCaptionTerkumpul.Location = new Point(30, 282);
        lblCaptionTerkumpul.Name = "lblCaptionTerkumpul";
        lblCaptionTerkumpul.Size = new Size(330, 30);
        lblCaptionTerkumpul.TabIndex = 5;
        lblCaptionTerkumpul.Text = "Terkumpul";
        lblCaptionTerkumpul.TextAlign = ContentAlignment.MiddleLeft;
        //
        // lblNilaiTerkumpul
        //
        lblNilaiTerkumpul.Font = new Font("Segoe UI", 10F);
        lblNilaiTerkumpul.ForeColor = Color.FromArgb(38, 73, 68);
        lblNilaiTerkumpul.Location = new Point(410, 282);
        lblNilaiTerkumpul.Name = "lblNilaiTerkumpul";
        lblNilaiTerkumpul.Size = new Size(350, 30);
        lblNilaiTerkumpul.TabIndex = 6;
        lblNilaiTerkumpul.Text = "Rp. 0";
        lblNilaiTerkumpul.TextAlign = ContentAlignment.MiddleLeft;
        //
        // lblCaptionNominal
        //
        lblCaptionNominal.Font = new Font("Segoe UI", 10F);
        lblCaptionNominal.ForeColor = Color.FromArgb(38, 73, 68);
        lblCaptionNominal.Location = new Point(30, 334);
        lblCaptionNominal.Name = "lblCaptionNominal";
        lblCaptionNominal.Size = new Size(330, 30);
        lblCaptionNominal.TabIndex = 7;
        lblCaptionNominal.Text = "Target";
        lblCaptionNominal.TextAlign = ContentAlignment.MiddleLeft;
        //
        // lblNilaiNominal
        //
        lblNilaiNominal.Font = new Font("Segoe UI", 10F);
        lblNilaiNominal.ForeColor = Color.FromArgb(38, 73, 68);
        lblNilaiNominal.Location = new Point(410, 334);
        lblNilaiNominal.Name = "lblNilaiNominal";
        lblNilaiNominal.Size = new Size(350, 30);
        lblNilaiNominal.TabIndex = 8;
        lblNilaiNominal.Text = "Rp. 0";
        lblNilaiNominal.TextAlign = ContentAlignment.MiddleLeft;
        //
        // btnEditTarget
        //
        btnEditTarget.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnEditTarget.BackColor = Color.FromArgb(21, 125, 104);
        btnEditTarget.Cursor = Cursors.Hand;
        btnEditTarget.Enabled = false;
        btnEditTarget.FlatAppearance.BorderColor = Color.FromArgb(229, 237, 232);
        btnEditTarget.FlatStyle = FlatStyle.Flat;
        btnEditTarget.ForeColor = Color.White;
        btnEditTarget.Location = new Point(272, 396);
        btnEditTarget.Name = "btnEditTarget";
        btnEditTarget.Size = new Size(124, 40);
        btnEditTarget.TabIndex = 132;
        btnEditTarget.Text = "Edit Target";
        btnEditTarget.UseVisualStyleBackColor = false;
        //
        // btnAmbilUang
        //
        btnAmbilUang.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnAmbilUang.BackColor = Color.White;
        btnAmbilUang.Cursor = Cursors.Hand;
        btnAmbilUang.Enabled = false;
        btnAmbilUang.FlatAppearance.BorderColor = Color.FromArgb(229, 237, 232);
        btnAmbilUang.FlatStyle = FlatStyle.Flat;
        btnAmbilUang.ForeColor = Color.FromArgb(38, 73, 68);
        btnAmbilUang.Location = new Point(408, 396);
        btnAmbilUang.Name = "btnAmbilUang";
        btnAmbilUang.Size = new Size(124, 40);
        btnAmbilUang.TabIndex = 133;
        btnAmbilUang.Text = "Ambil Uang";
        btnAmbilUang.UseVisualStyleBackColor = false;
        //
        // DetailTargetControl
        //
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Font = new Font("Segoe UI", 9F);
        AutoScroll = true;
        BackColor = Color.White;
        Controls.Add(lblTitleDetailTarget);
        Controls.Add(btnKembaliTarget);
        Controls.Add(cardDetailTarget);
        Name = "DetailTargetControl";
        Size = new Size(880, 806);
        cardDetailTarget.ResumeLayout(false);
        progressDetailTrack.ResumeLayout(false);
        ResumeLayout(false);
    }
}
