using System.Collections.Generic;
using System.Linq;
using System.Windows;
using VasuthalozatPublicApplication.Database;
using VasuthalozatPublicApplication.Entities;
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
            DataSources();
        }

        private readonly VasutContext _vasutContext = new VasutContext();

        private void btn_kereses_Click(object sender, RoutedEventArgs e)
        {
            if (cb_from.Text == cb_to.Text)
            {
                string message = "A 2 város nem egyezhet meg!";
                string title = "Warning";
                MessageBox.Show(message, title);
            }
            else
            {
                List<List<City>> BFS = UserInterfaceViewModel.Kereses(Cities(), Railways(), cb_from.Text, cb_to.Text);
                dataGrid1.Visibility = Visibility.Visible;
                dataGrid1.Items.Clear();
                List<City> first = BFS.First();
                string result = "";
                foreach (City city in first)
                {
                    result += city.Name + " -> ";
                }
                dataGrid1.Items.Add(result.Substring(0, result.Length - 4));
            }
        }

        private void btn_logout_Click(object sender, RoutedEventArgs e)
        {
            UserInterfaceViewModel.LogOut(this);
        }
        public List<City> Cities()
        {
            List<City> cities = _vasutContext.Cities.ToList();
            return cities;
        }
        public List<Railway> Railways()
        {
            List<Railway> railways = _vasutContext.Railways.ToList();
            return railways;
        }
        private void DataSources()
        {
            cb_from.ItemsSource = Cities().Select(x => x.Name);
            cb_to.ItemsSource = Cities().Select(x => x.Name);
        }
    }
}
