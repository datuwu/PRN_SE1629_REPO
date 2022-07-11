using MyStoreWinApp;
using System;
using System.Windows.Forms;

namespace SalesWinApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin loginForm = new frmLogin();
            Application.Run(loginForm);
            if (loginForm.UserSuccessfullyAuthenticated)
            {
                if (loginForm.isAdmin == true)
                {
                    Application.Run(new frmMain() { isAdmin = true });
                }
                else
                {
                    Application.Run(new frmMain() { isAdmin = false, id = loginForm.id });
                }
            }
        }
    }
}
