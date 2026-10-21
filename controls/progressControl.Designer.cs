#nullable enable
namespace UangKu.Controls;

partial class ProgressControl
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitleProgress = null!;
    private Label lblPilihProgress = null!;
    private ComboBox cmbProgressTarget = null!;
    private Panel cardProgress = null!;
    private Label lblNamaProgress = null!;
    private Label lblNominalProgress = null!;
    private Panel progressUtamaTrack = null!;
    private Panel progressUtamaFill = null!;
    private Label progressUtamaPercent = null!;
    private Label lblSisaProgress = null!;
    private Label lblBantuanProgress = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitleProgress = new Label();
        lblPilihProgress = new Label();
        cmbProgressTarget = new ComboBox();
        cardProgress = new Panel();
        lblNamaProgress = new Label();
        lblNominalProgress = new Label();
        progressUtamaTrack = new Panel();
        progressUtamaFill = new Panel();
        progressUtamaPercent = new Label();
        lblSisaProgress = new Label();
        lblBantuanProgress = new Label();
        cardProgress.SuspendLayout();
        progressUtamaTrack.SuspendLayout();
        SuspendLayout();
        //
        // lblTitleProgress
        //
        lblTitleProgress.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitleProgress.ForeColor = Color.FromArgb(38, 73, 68);
        lblTitleProgress.Location = new Point(40, 32);
        lblTitleProgress.Name = "lblTitleProgress";
        lblTitleProgress.Size = new Size(800, 44);
        lblTitleProgress.TabIndex = 0;
        lblTitleProgress.Text = "Progress Target";
        lblTitleProgress.TextAlign = ContentAlignment.MiddleLeft;
        //
        // lblPilihProgress
        //
        lblPilihProgress.Font = new Font("Segoe UI", 9F);
        lblPilihProgress.ForeColor = Color.FromArgb(38, 73, 68);
        lblPilihProgress.Location = new Point(40, 102);
        lblPilihProgress.Name = "lblPilihProgress";
        lblPilihProgress.Size = new Size(800, 24);
        lblPilihProgress.TabIndex = 1;
        lblPilihProgress.Text = "Pilih Target";
        lblPilihProgress.TextAlign = ContentAlignment.MiddleLeft;
        //
        // cmbProgressTarget
        //
        cmbProgressTarget.AccessibleName = "";
        cmbProgressTarget.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbProgressTarget.Enabled = false;
        cmbProgressTarget.Location = new Point(40, 132);
        cmbProgressTarget.Name = "cmbProgressTarget";
        cmbProgressTarget.Size = new Size(800, 27);
        cmbProgressTarget.TabIndex = 141;
        //
        // cardProgress
        //
        cardProgress.BorderStyle = BorderStyle.FixedSingle;
        cardProgress.Controls.Add(lblNamaProgress);
        cardProgress.Controls.Add(lblNominalProgress);
        cardProgress.Controls.Add(progressUtamaTrack);
        cardProgress.Controls.Add(progressUtamaPercent);
        cardProgress.Controls.Add(lblSisaProgress);
        cardProgress.Controls.Add(lblBantuanProgress);
        cardProgress.Location = new Point(40, 202);
        cardProgress.Name = "cardProgress";
        cardProgress.Size = new Size(800, 366);
        cardProgress.TabIndex = 142;
        //
        // lblNamaProgress
        //
        lblNamaProgress.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
        lblNamaProgress.ForeColor = Color.FromArgb(38, 73, 68);
        lblNamaProgress.Location = new Point(24, 28);
        lblNamaProgress.Name = "lblNamaProgress";
        lblNamaProgress.Size = new Size(750, 44);
        lblNamaProgress.TabIndex = 0;
        lblNamaProgress.Text = "Belum ada target keuangan.";
        lblNamaProgress.TextAlign = ContentAlignment.MiddleCenter;
        //
        // lblNominalProgress
        //
        lblNominalProgress.Font = new Font("Segoe UI", 15F);
        lblNominalProgress.ForeColor = Color.FromArgb(38, 73, 68);
        lblNominalProgress.Location = new Point(24, 100);
        lblNominalProgress.Name = "lblNominalProgress";
        lblNominalProgress.Size = new Size(750, 40);
        lblNominalProgress.TabIndex = 1;
        lblNominalProgress.Text = "Rp. 0 / Rp. 0";
        lblNominalProgress.TextAlign = ContentAlignment.MiddleCenter;
        //
        // progressUtamaTrack
        //
        progressUtamaTrack.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        progressUtamaTrack.BackColor = Color.FromArgb(201, 221, 213);
        progressUtamaTrack.Controls.Add(progressUtamaFill);
        progressUtamaTrack.Location = new Point(24, 186);
        progressUtamaTrack.Name = "progressUtamaTrack";
        progressUtamaTrack.Size = new Size(688, 9);
        progressUtamaTrack.TabIndex = 2;
        //
        // progressUtamaFill
        //
        progressUtamaFill.BackColor = Color.FromArgb(91, 128, 115);
        progressUtamaFill.Location = new Point(0, 0);
        progressUtamaFill.Name = "progressUtamaFill";
        progressUtamaFill.Size = new Size(0, 9);
        progressUtamaFill.TabIndex = 0;
        //
        // progressUtamaPercent
        //
        progressUtamaPercent.Font = new Font("Segoe UI", 8F);
        progressUtamaPercent.ForeColor = Color.FromArgb(38, 73, 68);
        progressUtamaPercent.Location = new Point(726, 177);
        progressUtamaPercent.Name = "progressUtamaPercent";
        progressUtamaPercent.Size = new Size(60, 26);
        progressUtamaPercent.TabIndex = 3;
        progressUtamaPercent.Text = "0%";
        progressUtamaPercent.TextAlign = ContentAlignment.MiddleLeft;
        //
        // lblSisaProgress
        //
        lblSisaProgress.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblSisaProgress.ForeColor = Color.FromArgb(38, 73, 68);
        lblSisaProgress.Location = new Point(24, 230);
        lblSisaProgress.Name = "lblSisaProgress";
        lblSisaProgress.Size = new Size(750, 44);
        lblSisaProgress.TabIndex = 4;
        lblSisaProgress.Text = "Belum ada progress.";
        lblSisaProgress.TextAlign = ContentAlignment.MiddleCenter;
        //
        // lblBantuanProgress
        //
        lblBantuanProgress.Font = new Font("Segoe UI", 10F);
        lblBantuanProgress.ForeColor = Color.FromArgb(38, 73, 68);
        lblBantuanProgress.Location = new Point(24, 292);
        lblBantuanProgress.Name = "lblBantuanProgress";
        lblBantuanProgress.Size = new Size(750, 30);
        lblBantuanProgress.TabIndex = 5;
        lblBantuanProgress.Text = "Tambahkan target melalui menu Target.";
        lblBantuanProgress.TextAlign = ContentAlignment.MiddleCenter;
        //
        // ProgressControl
        //
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Font = new Font("Segoe UI", 9F);
        AutoScroll = true;
        BackColor = Color.White;
        Controls.Add(lblTitleProgress);
        Controls.Add(lblPilihProgress);
        Controls.Add(cmbProgressTarget);
        Controls.Add(cardProgress);
        Name = "ProgressControl";
        Size = new Size(880, 806);
        cardProgress.ResumeLayout(false);
        progressUtamaTrack.ResumeLayout(false);
        ResumeLayout(false);
    }
}
