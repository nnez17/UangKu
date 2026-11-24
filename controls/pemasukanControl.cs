using System.ComponentModel;
using System.Globalization;
using UangKu.Models;
using UangKu.Services;
using UangKu.Themes;

namespace UangKu.Controls;

public partial class PemasukanControl : UserControl
{
    private static readonly CultureInfo IdCulture = CultureInfo.GetCultureInfo("id-ID");

    public event EventHandler? DashboardRequested;
    public event EventHandler? IncomeSaved;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    internal Service? Service { get; set; }

    public PemasukanControl()
    {
        InitializeComponent();

        btnBatalPemasukan.Click += (_, _) =>
        {
            ResetForm();
            DashboardRequested?.Invoke(this, EventArgs.Empty);
        };

        btnSimpanPemasukan.Click += async (_, _) => await SaveIncomeAsync();

        radioTarget.CheckedChanged += async (_, _) => await ToggleTargetSelectionAsync();
        cmbTargetPemasukan.SelectedIndexChanged += (_, _) => UpdateTargetHelperText();

        txtJumlahPemasukan.KeyPress += (_, e) =>
        {
            if (e.KeyChar == '\r' || e.KeyChar == '\n')
            {
                e.Handled = true;
                return;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        };
    }

    public async Task LoadTargetsAsync(CancellationToken cancellationToken = default)
    {
        if (Service is null)
        {
            cmbTargetPemasukan.Items.Clear();
            cmbTargetPemasukan.Enabled = false;
            UpdateTargetHelperText();
            return;
        }

        try
        {
            var targets = await Service.GetActiveTargetsAsync(cancellationToken);
            if (IsDisposed) return;

            var previousId = (cmbTargetPemasukan.SelectedItem as Target)?.id;

            cmbTargetPemasukan.BeginUpdate();
            cmbTargetPemasukan.Items.Clear();
            foreach (var target in targets)
            {
                cmbTargetPemasukan.Items.Add(target);
            }
            cmbTargetPemasukan.EndUpdate();

            cmbTargetPemasukan.Enabled = targets.Count > 0;

            if (targets.Count > 0)
            {
                var restoreIndex = previousId.HasValue
                    ? targets.FindIndex(t => t.id == previousId.Value)
                    : -1;
                cmbTargetPemasukan.SelectedIndex = restoreIndex >= 0 ? restoreIndex : 0;
            }
        }
        catch (OperationCanceledException)
        {
            return;
        }
        catch (Exception ex)
        {
            cmbTargetPemasukan.Items.Clear();
            cmbTargetPemasukan.Enabled = false;
            lblBantuanTarget.Text = $"Gagal memuat target: {ex.Message}";
            lblBantuanTarget.ForeColor = Color.FromArgb(185, 28, 28);
            lblBantuanTarget.Visible = radioTarget.Checked;
            return;
        }

        UpdateTargetHelperText();
    }

    public void ResetForm()
    {
        txtJumlahPemasukan.Clear();
        txtCatatanPemasukan.Clear();
        radioTransaksi.Checked = true;
        if (cmbTargetPemasukan.Items.Count > 0)
        {
            cmbTargetPemasukan.SelectedIndex = 0;
        }
    }

    private async Task ToggleTargetSelectionAsync()
    {
        var showTarget = radioTarget.Checked;
        lblPilihTargetPemasukan.Visible = showTarget;
        cmbTargetPemasukan.Visible = showTarget;
        btnBatalPemasukan.Top = btnSimpanPemasukan.Top = showTarget ? 576 : 444;

        if (showTarget)
        {
            await LoadTargetsAsync();
        }
        else
        {
            lblBantuanTarget.Visible = false;
        }
    }

    private void UpdateTargetHelperText()
    {
        if (!radioTarget.Checked)
        {
            lblBantuanTarget.Visible = false;
            return;
        }

        if (cmbTargetPemasukan.Items.Count == 0)
        {
            lblBantuanTarget.Text = "Belum ada target aktif. Tambahkan melalui menu Target.";
            lblBantuanTarget.ForeColor = Color.FromArgb(38, 73, 68);
            lblBantuanTarget.Visible = true;
            return;
        }

        if (cmbTargetPemasukan.SelectedItem is Target selected)
        {
            lblBantuanTarget.Text = $"Sisa target: Rp {selected.Remaining.ToString("N0", IdCulture)} ({selected.ProgressPercentage}% tercapai)";
            lblBantuanTarget.ForeColor = Color.FromArgb(75, 114, 102);
            lblBantuanTarget.Visible = true;
        }
        else
        {
            lblBantuanTarget.Visible = false;
        }
    }

    private async Task SaveIncomeAsync()
    {
        var amount = CurrencyFormat.Parse(txtJumlahPemasukan.Text);
        if (amount <= 0)
        {
            MessageBox.Show(
                "Nominal pemasukan harus lebih dari Rp 0.",
                "Validasi Pemasukan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            txtJumlahPemasukan.Focus();
            return;
        }

        int? targetId = null;
        if (radioTarget.Checked)
        {
            if (cmbTargetPemasukan.SelectedItem is not Target selectedTarget)
            {
                MessageBox.Show(
                    "Pilih target tabungan yang valid terlebih dahulu.",
                    "Validasi Pemasukan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            targetId = selectedTarget.id;
        }

        if (Service is null)
        {
            ResetForm();
            DashboardRequested?.Invoke(this, EventArgs.Empty);
            return;
        }

        SetBusy(true);
        try
        {
            await Service.AddIncomeAsync(amount, txtCatatanPemasukan.Text, targetId);
            ResetForm();
            IncomeSaved?.Invoke(this, EventArgs.Empty);
            DashboardRequested?.Invoke(this, EventArgs.Empty);
        }
        catch (Exception ex) when (ex is ArgumentException or InvalidOperationException)
        {
            MessageBox.Show(
                ex.Message,
                "Validasi Pemasukan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            var detail = ex.InnerException?.Message ?? ex.Message;
            MessageBox.Show(
                $"Gagal menyimpan pemasukan:\n{detail}",
                "Error Database",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        finally
        {
            if (!IsDisposed)
            {
                SetBusy(false);
            }
        }
    }

    private void SetBusy(bool busy)
    {
        btnSimpanPemasukan.Enabled = !busy;
        btnBatalPemasukan.Enabled = !busy;
        btnSimpanPemasukan.Text = busy ? "Menyimpan..." : "Simpan";
        UseWaitCursor = busy;
    }
}
