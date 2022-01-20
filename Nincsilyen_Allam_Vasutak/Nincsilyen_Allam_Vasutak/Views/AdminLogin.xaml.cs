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
using Nincsilyen_Allam_Vasutak.Views;

namespace Nincsilyen_Allam_Vasutak.Views
{
    /// <summary>
    /// Interaction logic for AdminLogin.xaml
    /// </summary>
    public partial class AdminLogin : Window
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btn_adminlogin_Click(object sender, RoutedEventArgs e)
        {
            if (tb_adminname.Text == "Admin1" && tb_password.Text == "Admin1PW")
            {
                AdminInterface adminInterface = new AdminInterface();
                this.Close();
                adminInterface.Show();
            }
        }
    }
}
