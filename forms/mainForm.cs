using UangKu.Controls;
using UangKu.Services;
using UangKu.Models;

namespace UangKu.Forms;

public partial class MainForm : Form
{
    // ponytail: cache 11 pages to retain input; create lazily if startup cost grows.
    private UserControl[] pages = [];
    private Button[] menu = [];
    private Font activeMenuFont = null!;

    public MainForm()
    {
        InitializeComponent();
        activeMenuFont = btnDashboard.Font;
        pages = [pageDashboard, pagePemasukan, pagePengeluaran, pageSaldo, pageRiwayat,
            pageTarget, pageTambahTarget, pageDetailTarget, pageEditTarget, pageAmbilUang, pageProgress];
        menu = [btnDashboard, btnPemasukan, btnPengeluaran, btnSaldo, btnRiwayat, btnTarget, btnProgress];
        AppTheme.Apply(sidebar, menu);
        foreach (var page in pages) AppTheme.Apply(page);
        Navigate(btnDashboard, pageDashboard);
        Navigate(btnPemasukan, pagePemasukan);
        Navigate(btnPengeluaran, pagePengeluaran);
        Navigate(btnSaldo, pageSaldo);
        Navigate(btnRiwayat, pageRiwayat);
        Navigate(btnTarget, pageTarget);
        Navigate(btnProgress, pageProgress);
        pageDashboard.RiwayatRequested += (_, _) => ShowPage(pageRiwayat);
        pagePemasukan.DashboardRequested += (_, _) => ShowPage(pageDashboard);
        pagePengeluaran.DashboardRequested += (_, _) => ShowPage(pageDashboard);
        pageTarget.TambahTargetRequested += (_, _) => ShowPage(pageTambahTarget);
        pageTambahTarget.TargetRequested += (_, _) => ShowPage(pageTarget);
        pageDetailTarget.TargetRequested += (_, _) => ShowPage(pageTarget);
        pageDetailTarget.EditTargetRequested += (_, _) => ShowPage(pageEditTarget);
        pageDetailTarget.AmbilUangRequested += (_, _) => ShowPage(pageAmbilUang);
        pageEditTarget.DetailTargetRequested += (_, _) => ShowPage(pageDetailTarget);
        pageAmbilUang.DetailTargetRequested += (_, _) => ShowPage(pageDetailTarget);
        ShowPage(pageDashboard);
    }

    private void Navigate(Button button, UserControl page) => button.Click += (_, _) => ShowPage(page);

    private void ShowPage(UserControl page)
    {
        if (!pages.Contains(page)) throw new ArgumentException("Unknown page", nameof(page));
        contentHost.SuspendLayout();
        contentHost.Controls.Clear();
        contentHost.Controls.Add(page);
        var active = page == pageProgress ? btnProgress :
            page == pagePemasukan ? btnPemasukan : page == pagePengeluaran ? btnPengeluaran :
            page == pageSaldo ? btnSaldo : page == pageRiwayat ? btnRiwayat :
            page == pageDashboard ? btnDashboard : btnTarget;
        foreach (var item in menu)
        {
            item.BackColor = item == active ? Color.FromArgb(197, 232, 218) : Color.FromArgb(232, 243, 238);
            item.Font = item == active ? activeMenuFont : sidebar.Font;
            item.AccessibleDescription = item == active ? "Halaman aktif" : "Buka " + item.Text;
        }
        contentHost.ResumeLayout(true);
        page.SelectNextControl(null, true, true, true, false);
    }
}
