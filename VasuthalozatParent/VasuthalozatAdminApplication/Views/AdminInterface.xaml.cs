using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using VasuthalozatAdminApplication.Entities;
using VasuthalozatAdminApplication.Database;
using VasuthalozatAdminApplication.Models;

namespace VasuthalozatAdminApplication.Views
{
    /// <summary>
    /// Interaction logic for AdminInterface.xaml
    /// </summary>
    public partial class AdminInterface : Window
    {
        public AdminInterface()
        {
            InitializeComponent();
            DataSources();
        }
        public AdminInterface(VasutContext vasutContext)
        {
            _vasutContext = vasutContext;
        }

        private readonly VasutContext _vasutContext = new VasutContext();

        private void btn_varosmegjelenit_Click(object sender, RoutedEventArgs e)
        {
            dataGridVarosok.ItemsSource = Cities();
            dataGridVarosok.Visibility = Visibility.Visible;
            dataGridJaratok.Visibility = Visibility.Hidden;
        }
        private void btn_varoshozzaad_Click(object sender, RoutedEventArgs e)
        {
            string cityname = tb_varosfelvetel.Text;
            AdminInterfaceViewModel.PostVaros(cityname);
        }
        private void btn_varosmodosit_Click(object sender, RoutedEventArgs e)
        {
            string oldcity = cb_varosreginev.Text;
            string newcity = tb_varosujnev.Text;
            AdminInterfaceViewModel.UpdateVaros(newcity, oldcity);
        }
        private void btn_varostorles_Click(object sender, RoutedEventArgs e)
        {
            string city = cb_varostorles.Text;
            AdminInterfaceViewModel.DeleteVaros(city, Cities());
        }

        private void btn_jaratokmegjelenit_Click(object sender, RoutedEventArgs e)
        {
            List<Railway> railways = Railways();
            dataGridJaratok.ItemsSource = railways;
            dataGridJaratok.Visibility = Visibility.Visible;
            dataGridVarosok.Visibility = Visibility.Hidden;

        }
        private void btn_jarathozzaad_Click(object sender, RoutedEventArgs e)
        {
            string cityfrom = cb_ujjaratfrom.Text;
            string cityto = cb_ujjaratto.Text;
            int km = int.Parse(tb_ujjaratkm.Text);
            AdminInterfaceViewModel.PostJarat(cityfrom, cityto, km, Cities());
        }
        private void btn_jarattorles_Click(object sender, RoutedEventArgs e)
        {
            string cityfrom = cb_jarattorlesfrom.Text;
            string cityto = cb_jarattorlesto.Text;
            AdminInterfaceViewModel.DeleteJarat(cityfrom, cityto, Cities());
        }

        private void btn_kilep_Click(object sender, RoutedEventArgs e)
        {
            AdminInterfaceViewModel.LogOut(this);
        }
        public void DataSources()
        {
            cb_varosreginev.ItemsSource = Cities().Select(x => x.Name);
            cb_varostorles.ItemsSource = Cities().Select(x => x.Name);
            cb_ujjaratfrom.ItemsSource = Cities().Select(x => x.Name);
            cb_ujjaratto.ItemsSource = Cities().Select(x => x.Name);
            cb_jarattorlesfrom.ItemsSource = Cities().Select(x => x.Name);
            cb_jarattorlesto.ItemsSource = Cities().Select(x => x.Name);
        }

        public List<City> Cities()
        {
            //var command = Connection.OpenConnection().CreateCommand();
            //command.CommandType = CommandType.Text;
            //command.CommandText = "SELECT * FROM `cities`";
            //var reader = command.ExecuteReader();
            //List<City> cities = new List<City>();
            //while (reader.Read())
            //{
            //    City city = new City()
            //    {
            //        ID = int.Parse(reader["ID"].ToString()),
            //        Name = (string)reader["Name"]
            //    };
            //    cities.Add(city);
            //}
            List<City> cities = _vasutContext.Cities.ToList();
            return cities;
        }
        public List<Railway> Railways()
        {
            //var command = Connection.OpenConnection().CreateCommand();
            //command.CommandType = CommandType.Text;
            //command.CommandText = "SELECT * FROM `railways`";
            //var reader = command.ExecuteReader();
            //List<Railway> railways = new List<Railway>();
            //while (reader.Read())
            //{
            //    Railway railway = new Railway()
            //    {
            //        ID = int.Parse(reader["ID"].ToString()),
            //        //FromID = int.Parse(reader["FromID"].ToString()),
            //        From = Cities().First(x => x.ID == int.Parse(reader["FromID"].ToString())),
            //        To = Cities().First(x => x.ID == int.Parse(reader["ToID"].ToString())),
            //        Km = int.Parse(reader["Km"].ToString())
            //    };
            //    railways.Add(railway);
            //}
            List<Railway> railways = _vasutContext.Railways.ToList();
            return railways;
        }
    }
}
