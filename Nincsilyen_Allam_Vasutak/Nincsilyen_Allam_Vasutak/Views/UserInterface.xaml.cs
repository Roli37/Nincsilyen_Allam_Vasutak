﻿using System;
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
using Nincsilyen_Allam_Vasutak.Views;

namespace Nincsilyen_Allam_Vasutak.Views
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

        private void btn_adminfelulet_Click(object sender, RoutedEventArgs e)
        {
            AdminRedirect adminRedirect = new AdminRedirect();
            adminRedirect.Show();
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
