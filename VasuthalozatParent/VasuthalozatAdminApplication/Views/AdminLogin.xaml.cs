using System.Windows;
using VasuthalozatAdminApplication.Models;

namespace VasuthalozatAdminApplication.Views
{
    /// <summary>
    /// Interaction logic for AdminLogin.xaml
    /// </summary>
    public partial class AdminLogin : Window
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btn_adminlogin_Click(object sender, RoutedEventArgs e)
        {
            string name = tb_adminname.Text;
            string password = pb_password.Password;
            AdminLoginViewModel.LogIn(name, password, this);
        }
    }
}
