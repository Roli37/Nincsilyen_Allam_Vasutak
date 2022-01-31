using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using VasuthalozatPublicApplication.Entities;

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
            string password = tb_password.Text;
            string passwordconf = tb_password_conf.Text;
            if (password == passwordconf)
            {
                using (var command = Connection.OpenConnection().CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT INTO users (Name, Password) VALUES (@name, @password)";

                    var param1 = command.CreateParameter();
                    param1.ParameterName = "@name";
                    param1.Value = name;

                    var param2 = command.CreateParameter();
                    param2.ParameterName = "@password";
                    param2.Value = password;

                    command.Parameters.Add(param1);
                    command.Parameters.Add(param2);
                    command.ExecuteNonQuery();
                    UserInterface userInterface = new UserInterface();
                    this.Close();
                    userInterface.Show();
                }
            }
            else
            {
                string message = "A jelszavak nem egyeznek!";
                string title = "Warning";
                MessageBox.Show(message, title);
            }
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Close();
            logIn.Show();
        }
    }
}
