using System.Windows;
using VasuthalozatAdminApplication.Views;

namespace VasuthalozatAdminApplication.Models
{
    public class AdminLoginViewModel
    {
        public static void LogIn(string name, string password, AdminLogin adminLogin)
        {
            if (name == "Admin1" && password == "Admin1PW")
            {
                AdminInterface adminInterface = new AdminInterface();
                adminLogin.Close();
                adminInterface.Show();
            }
            else
            {
                string message = "Ellenőrizd az adatokat!";
                string title = "Warning";
                MessageBox.Show(message, title);
            }
        }
    }
}
