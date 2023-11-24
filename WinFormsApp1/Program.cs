using Avia.DB;
using DB;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

namespace WinFormsApp1
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

            //using (DBContext db = new DBContext())
            //{
            //    db.Users.Add(new User {
            //        age = 18,
            //        dpi = "3881171170101",
            //        name = "AdminUser",
            //        password = "Password_1",
            //        rol = "admin",
            //    });
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();

            LoginForm frmMain = new LoginForm();
            frmMain.Show();

            Application.Run();
        }
    }
}