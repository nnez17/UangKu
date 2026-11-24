using UangKu.Forms;
using UangKu.Data;

namespace UangKu
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            try
            {
                Db.Initialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Gagal memanggil databse: \n{ex.Message}\n\nPastikan database PostgreSQL berjalan dan konfigurasi di .env sudah benar.",
                    "Koneksi Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
            Application.Run(new MainForm());
        }
    }
}