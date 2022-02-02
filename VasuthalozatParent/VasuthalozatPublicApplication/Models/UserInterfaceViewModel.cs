using VasuthalozatPublicApplication.Views;

namespace VasuthalozatPublicApplication.Models
{
    public class UserInterfaceViewModel
    {
        public static void LogOut(UserInterface userInterface)
        {
            LogIn logIn = new LogIn();
            userInterface.Close();
            logIn.Show();
        }
    }
}
