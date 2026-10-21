#nullable enable
namespace UangKu.Controls;

partial class SaldoControl
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitleSaldo = null!;
    private Panel cardSaldo0 = null!;
    private Label cardSaldo0Title = null!;
    private Label cardSaldo0Amount = null!;
    private Panel cardSaldo1 = null!;
    private Label cardSaldo1Title = null!;
    private Label cardSaldo1Amount = null!;
    private Panel cardSaldo2 = null!;
    private Label cardSaldo2Title = null!;
    private Label cardSaldo2Amount = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitleSaldo = new Label();
        cardSaldo0 = new Panel();
        cardSaldo0Title = new Label();
        cardSaldo0Amount = new Label();
        cardSaldo1 = new Panel();
        cardSaldo1Title = new Label();
        cardSaldo1Amount = new Label();
        cardSaldo2 = new Panel();
        cardSaldo2Title = new Label();
        cardSaldo2Amount = new Label();
        cardSaldo0.SuspendLayout();
        cardSaldo1.SuspendLayout();
        cardSaldo2.SuspendLayout();
        SuspendLayout();
        //
        // lblTitleSaldo
        //
        lblTitleSaldo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitleSaldo.ForeColor = Color.FromArgb(38, 73, 68);
        lblTitleSaldo.Location = new Point(40, 32);
        lblTitleSaldo.Name = "lblTitleSaldo";
        lblTitleSaldo.Size = new Size(800, 44);
        lblTitleSaldo.TabIndex = 0;
        lblTitleSaldo.Text = "Saldo";
        lblTitleSaldo.TextAlign = ContentAlignment.MiddleLeft;
        //
        // cardSaldo0
        //
        cardSaldo0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        cardSaldo0.BackColor = Color.FromArgb(21, 125, 104);
        cardSaldo0.BorderStyle = BorderStyle.FixedSingle;
        cardSaldo0.Controls.Add(cardSaldo0Title);
        cardSaldo0.Controls.Add(cardSaldo0Amount);
        cardSaldo0.Location = new Point(40, 108);
        cardSaldo0.Name = "cardSaldo0";
        cardSaldo0.Size = new Size(800, 118);
        cardSaldo0.TabIndex = 1;
        //
        // cardSaldo0Title
        //
        cardSaldo0Title.Font = new Font("Segoe UI", 8F);
        cardSaldo0Title.ForeColor = Color.White;
        cardSaldo0Title.Location = new Point(20, 12);
        cardSaldo0Title.Name = "cardSaldo0Title";
        cardSaldo0Title.Size = new Size(760, 22);
        cardSaldo0Title.TabIndex = 0;
        cardSaldo0Title.Text = "SALDO SAAT INI";
        cardSaldo0Title.TextAlign = ContentAlignment.MiddleLeft;
        //
        // cardSaldo0Amount
        //
        cardSaldo0Amount.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
        cardSaldo0Amount.ForeColor = Color.White;
        cardSaldo0Amount.Location = new Point(20, 40);
        cardSaldo0Amount.Name = "cardSaldo0Amount";
        cardSaldo0Amount.Size = new Size(760, 40);
        cardSaldo0Amount.TabIndex = 1;
        cardSaldo0Amount.Text = "Rp. 0";
        cardSaldo0Amount.TextAlign = ContentAlignment.MiddleLeft;
        //
        // cardSaldo1
        //
        cardSaldo1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        cardSaldo1.BackColor = Color.FromArgb(234, 246, 238);
        cardSaldo1.BorderStyle = BorderStyle.FixedSingle;
        cardSaldo1.Controls.Add(cardSaldo1Title);
        cardSaldo1.Controls.Add(cardSaldo1Amount);
        cardSaldo1.Location = new Point(40, 250);
        cardSaldo1.Name = "cardSaldo1";
        cardSaldo1.Size = new Size(800, 118);
        cardSaldo1.TabIndex = 2;
        //
        // cardSaldo1Title
        //
        cardSaldo1Title.Font = new Font("Segoe UI", 8F);
        cardSaldo1Title.ForeColor = Color.FromArgb(38, 73, 68);
        cardSaldo1Title.Location = new Point(20, 12);
        cardSaldo1Title.Name = "cardSaldo1Title";
        cardSaldo1Title.Size = new Size(760, 22);
        cardSaldo1Title.TabIndex = 0;
        cardSaldo1Title.Text = "DOMPET TRANSAKSI";
        cardSaldo1Title.TextAlign = ContentAlignment.MiddleLeft;
        //
        // cardSaldo1Amount
        //
        cardSaldo1Amount.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
        cardSaldo1Amount.ForeColor = Color.FromArgb(38, 73, 68);
        cardSaldo1Amount.Location = new Point(20, 40);
        cardSaldo1Amount.Name = "cardSaldo1Amount";
        cardSaldo1Amount.Size = new Size(760, 40);
        cardSaldo1Amount.TabIndex = 1;
        cardSaldo1Amount.Text = "Rp. 0";
        cardSaldo1Amount.TextAlign = ContentAlignment.MiddleLeft;
        //
        // cardSaldo2
        //
        cardSaldo2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        cardSaldo2.BackColor = Color.FromArgb(237, 242, 255);
        cardSaldo2.BorderStyle = BorderStyle.FixedSingle;
        cardSaldo2.Controls.Add(cardSaldo2Title);
        cardSaldo2.Controls.Add(cardSaldo2Amount);
        cardSaldo2.Location = new Point(40, 392);
        cardSaldo2.Name = "cardSaldo2";
        cardSaldo2.Size = new Size(800, 118);
        cardSaldo2.TabIndex = 3;
        //
        // cardSaldo2Title
        //
        cardSaldo2Title.Font = new Font("Segoe UI", 8F);
        cardSaldo2Title.ForeColor = Color.FromArgb(38, 73, 68);
        cardSaldo2Title.Location = new Point(20, 12);
        cardSaldo2Title.Name = "cardSaldo2Title";
        cardSaldo2Title.Size = new Size(760, 22);
        cardSaldo2Title.TabIndex = 0;
        cardSaldo2Title.Text = "DOMPET TARGET";
        cardSaldo2Title.TextAlign = ContentAlignment.MiddleLeft;
        //
        // cardSaldo2Amount
        //
        cardSaldo2Amount.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
        cardSaldo2Amount.ForeColor = Color.FromArgb(38, 73, 68);
        cardSaldo2Amount.Location = new Point(20, 40);
        cardSaldo2Amount.Name = "cardSaldo2Amount";
        cardSaldo2Amount.Size = new Size(760, 40);
        cardSaldo2Amount.TabIndex = 1;
        cardSaldo2Amount.Text = "Rp. 0";
        cardSaldo2Amount.TextAlign = ContentAlignment.MiddleLeft;
        //
        // SaldoControl
        //
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Font = new Font("Segoe UI", 9F);
        AutoScroll = true;
        BackColor = Color.White;
        Controls.Add(lblTitleSaldo);
        Controls.Add(cardSaldo0);
        Controls.Add(cardSaldo1);
        Controls.Add(cardSaldo2);
        Name = "SaldoControl";
        Size = new Size(880, 806);
        cardSaldo0.ResumeLayout(false);
        cardSaldo1.ResumeLayout(false);
        cardSaldo2.ResumeLayout(false);
        ResumeLayout(false);
    }
}
