using System.Data;
using System.Windows;
using VasuthalozatPublicApplication.Database;
using VasuthalozatPublicApplication.Views;

namespace VasuthalozatPublicApplication.Models
{
    public class SignUpViewModel
    {
        public static void SignUp(string name, string password, string passwordconf, SignUp signUp)
        {
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
                    signUp.Close();
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
        public static void LogIn(SignUp signUp)
        {
            LogIn logIn = new LogIn();
            signUp.Close();
            logIn.Show();
        }
    }
}
