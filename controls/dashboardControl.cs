using System.ComponentModel;
using System.Globalization;
using UangKu.Models;
using UangKu.Services;

namespace UangKu.Controls;

public partial class DashboardControl : UserControl
{
    private static readonly CultureInfo IdCulture = CultureInfo.GetCultureInfo("id-ID");

    public event EventHandler? RiwayatRequested;
    public event EventHandler<Target>? TargetSelected;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    internal Service? Service { get; set; }
    private Target? _primaryTarget;
    private CancellationTokenSource? _refreshCts;

    public DashboardControl()
    {
        InitializeComponent();
        ConfigureTransactionGrid();

        btnLihatSemua.Click += (_, _) => RiwayatRequested?.Invoke(this, EventArgs.Empty);
        progressDashboardTrack.Resize += (_, _) => UpdateTargetProgressBar();

        WireTargetClick(lblTargetDashboard);
        WireTargetClick(pnlProgressDashboard);
        WireTargetClick(progressDashboardTrack);
        WireTargetClick(progressDashboardFill);
        WireTargetClick(progressDashboardPercent);

        HandleDestroyed += (_, _) =>
        {
            _refreshCts?.Cancel();
            _refreshCts?.Dispose();
            _refreshCts = null;
        };
    }

    public void UpdateStats() => _ = UpdateStatsAsync();

    public async Task UpdateStatsAsync(CancellationToken cancellationToken = default)
    {
        if (Service is null)
            return;

        _refreshCts?.Cancel();
        _refreshCts?.Dispose();
        _refreshCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        var token = _refreshCts.Token;

        try
        {
            var statsTask = Service.GetStatsAsync(token);
            var recentTask = Service.GetTransactionsAsync(limit: 5, token);

            await Task.WhenAll(statsTask, recentTask);
            if (IsDisposed || token.IsCancellationRequested)
                return;

            var stats = statsTask.Result;
            var recentTransactions = recentTask.Result;

            _primaryTarget = stats.primaryTarget;

            cardPemasukanAmount.Text = FormatCurrency(stats.totalIncome);
            cardPengeluaranAmount.Text = FormatCurrency(stats.totalExpense);
            cardSaldoDashboardAmount.Text = FormatCurrency(stats.totalBalance);

            if (_primaryTarget != null)
            {
                lblTargetDashboard.Text = $"{_primaryTarget.name} - {FormatCurrency(_primaryTarget.currentAmount)}";
                pnlProgressDashboard.Visible = true;
                progressDashboardPercent.Text = $"{_primaryTarget.ProgressPercentage}%";
                UpdateTargetProgressBar();
            }
            else
            {
                lblTargetDashboard.Text = "Belum ada target keuangan.";
                pnlProgressDashboard.Visible = false;
            }

            dgvDashboard.DataSource = recentTransactions;
            dgvDashboard.ClearSelection();
            lblEmptyDashboardTransactions.Visible = recentTransactions.Count == 0;
        }
        catch (OperationCanceledException)
        {
            // Ignored when a newer refresh supersedes this request.
        }
        catch
        {
            if (IsDisposed) return;
            lblEmptyDashboardTransactions.Text = "Tidak dapat memuat transaksi. Periksa koneksi database.";
            lblEmptyDashboardTransactions.Visible = true;
        }
    }

    private void ConfigureTransactionGrid()
    {
        dgvDashboard.AutoGenerateColumns = false;
        dataGridViewTextBoxColumn5.DataPropertyName = nameof(TransactionsRecord.transactionAt);
        dataGridViewTextBoxColumn6.DataPropertyName = nameof(TransactionsRecord.type);
        dataGridViewTextBoxColumn7.DataPropertyName = nameof(TransactionsRecord.note);
        dataGridViewTextBoxColumn8.DataPropertyName = nameof(TransactionsRecord.amount);

        dgvDashboard.CellFormatting += DgvDashboard_CellFormatting;
    }

    private void DgvDashboard_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= dgvDashboard.Rows.Count)
            return;

        if (dgvDashboard.Rows[e.RowIndex].DataBoundItem is not TransactionsRecord record)
            return;

        var colName = dgvDashboard.Columns[e.ColumnIndex].Name;
        if (colName == nameof(dataGridViewTextBoxColumn5))
        {
            e.Value = record.transactionAt.ToString("dd MMM yyyy, HH:mm", IdCulture);
            e.FormattingApplied = true;
        }
        else if (colName == nameof(dataGridViewTextBoxColumn6))
        {
            var isIncome = string.Equals(record.type, "income", StringComparison.OrdinalIgnoreCase);
            e.Value = isIncome ? "Pemasukan" : "Pengeluaran";
            e.CellStyle!.ForeColor = isIncome
                ? Color.FromArgb(21, 125, 104)
                : Color.FromArgb(185, 64, 52);
            e.FormattingApplied = true;
        }
        else if (colName == nameof(dataGridViewTextBoxColumn7))
        {
            e.Value = !string.IsNullOrWhiteSpace(record.note)
                ? record.note
                : !string.IsNullOrWhiteSpace(record.targetName)
                    ? record.targetName
                    : record.walletName;
            e.FormattingApplied = true;
        }
        else if (colName == nameof(dataGridViewTextBoxColumn8))
        {
            var isIncome = string.Equals(record.type, "income", StringComparison.OrdinalIgnoreCase);
            var sign = isIncome ? "+" : "-";
            e.Value = $"{sign} {FormatCurrency(record.amount)}";
            e.CellStyle!.ForeColor = isIncome
                ? Color.FromArgb(21, 125, 104)
                : Color.FromArgb(185, 64, 52);
            e.FormattingApplied = true;
        }
    }

    private void UpdateTargetProgressBar()
    {
        if (_primaryTarget is null) return;
        var fillWidth = (int)Math.Round(progressDashboardTrack.Width * (_primaryTarget.ProgressPercentage / 100.0));
        progressDashboardFill.Width = Math.Max(0, Math.Min(progressDashboardTrack.Width, fillWidth));
    }

    private void WireTargetClick(Control control)
    {
        control.Cursor = Cursors.Hand;
        control.Click += (_, _) =>
        {
            if (_primaryTarget != null)
                TargetSelected?.Invoke(this, _primaryTarget);
        };
    }

    private static string FormatCurrency(decimal amount)
        => $"Rp {amount.ToString("N0", IdCulture)}";
}
