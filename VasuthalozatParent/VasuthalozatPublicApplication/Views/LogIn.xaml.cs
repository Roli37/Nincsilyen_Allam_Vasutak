using System.Windows;
using VasuthalozatPublicApplication.Models;

namespace VasuthalozatPublicApplication.Views
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            string name = tb_username.Text;
            string password = pb_password.Password;
            LogInViewModel.LogIn(name, password, this);
        }

        private void btn_signup_Click(object sender, RoutedEventArgs e)
        {
            LogInViewModel.SignUp(this);
        }
    }
}
