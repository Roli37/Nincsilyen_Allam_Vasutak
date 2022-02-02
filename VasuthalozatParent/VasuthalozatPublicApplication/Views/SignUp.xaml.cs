using System.Windows;
using VasuthalozatPublicApplication.Models;

namespace VasuthalozatPublicApplication.Views
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, RoutedEventArgs e)
        {
            string name = tb_username.Text;
            string password = pb_password.Password;
            string passwordconf = pb_password_conf.Password;
            SignUpViewModel.SignUp(name, password, passwordconf, this);
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            SignUpViewModel.LogIn(this);
        }
    }
}
