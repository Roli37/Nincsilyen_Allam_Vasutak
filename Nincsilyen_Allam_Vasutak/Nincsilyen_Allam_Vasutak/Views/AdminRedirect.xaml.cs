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
    /// Interaction logic for AdminRedirect.xaml
    /// </summary>
    public partial class AdminRedirect : Window
    {
        public AdminRedirect()
        {
            InitializeComponent();
        }

        private void btn_go_Click(object sender, RoutedEventArgs e)
        {
            if (tb_code.Text == "yQy^<YGkq{42b>}v")
            {
                AdminLogin adminLogin = new AdminLogin();
                this.Close();
                adminLogin.Show();
            }
            else
            {
                //Wrong code
            }
        }
    }
}
