using System.Windows;
using VasuthalozatPublicApplication.Models;

namespace VasuthalozatPublicApplication.Views
{
    /// <summary>
    /// Interaction logic for UserInterface.xaml
    /// </summary>
    public partial class UserInterface : Window
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        private void btn_kereses_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_logout_Click(object sender, RoutedEventArgs e)
        {
            UserInterfaceViewModel.LogOut(this);
        }
    }
}
