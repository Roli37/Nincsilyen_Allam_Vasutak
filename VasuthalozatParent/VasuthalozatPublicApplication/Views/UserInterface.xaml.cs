using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
            LogIn logIn = new LogIn();
            this.Close();
            logIn.Show();
        }
    }
}
