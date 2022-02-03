using System.Data;
using System.Windows;
using VasuthalozatPublicApplication.Algorithms;
using VasuthalozatPublicApplication.Database;
using VasuthalozatPublicApplication.Views;

namespace VasuthalozatPublicApplication.Models
{
    public class LogInViewModel
    {
        public static void LogIn(string name, string password, LogIn logIn)
        {
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
                        password = PasswordHash.Hash(password);
                        if ((string)reader["Password"] == password)
                        {
                            UserInterface userInterface = new UserInterface();
                            logIn.Close();
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
        public static void SignUp(LogIn logIn)
        {
            SignUp signUp = new SignUp();
            logIn.Close();
            signUp.Show();
        }
    }
}
