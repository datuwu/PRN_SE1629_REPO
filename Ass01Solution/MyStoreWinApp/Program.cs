using BusinessObject;

namespace MyStoreWinApp
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
            frmLogin loginForm = new frmLogin();
            Application.Run(loginForm);
            if (loginForm.UserSuccessfullyAuthenticated)
            {
                if (loginForm.isAdmin == true)
                {
                    Application.Run(new frmMemberManagement()
                    {
                        isAdmin = true,
                        loginMember = new Member
                        {
                            Email = loginForm.loginMember.Email,
                            Password = loginForm.loginMember.Password,
                        }
                    });
                }
                else
                {
                    Application.Run(new frmMemberManagement()
                    {
                        isAdmin = false,
                        id = loginForm.id,
                        loginMember = new Member
                        {
                            Email = loginForm.loginMember.Email,
                            Password = loginForm.loginMember.Password,
                        }
                    });
                }
            }
        }
    }
}