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
            string password = tb_password.Text;
            using (var command = Connection.OpenConnection().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM users WHERE users.Name = @name";

                var param = command.CreateParameter();
                param.ParameterName = "@name";
                param.Value = name;
                command.Parameters.Add(param);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if ((string)reader["Password"] == password)
                        {
                            UserInterface userInterface = new UserInterface();
                            this.Close();
                            userInterface.Show();
                        }
                        else
                        {
                            string message = "Hibás jelszó!";
                            string title = "Warning";
                            MessageBox.Show(message, title);
                        }
                    }
                    else
                    {
                        string message = "Nincs ilyen felhasználó!";
                        string title = "Warning";
                        MessageBox.Show(message, title);
                    }
                }
            }
        }

        private void btn_signup_Click(object sender, RoutedEventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Close();
            signUp.Show();
        }
    }
}
