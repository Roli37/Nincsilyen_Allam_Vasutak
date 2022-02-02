using System;
using System.Collections.Generic;
using System.Data;
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
using VasuthalozatAdminApplication.Entities;

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
            cb_varosreginev.ItemsSource = Cities().Select(x => x.Name);
            cb_varostorles.ItemsSource = Cities().Select(x => x.Name);
            cb_ujjaratfrom.ItemsSource = Cities().Select(x => x.Name);
            cb_ujjaratto.ItemsSource = Cities().Select(x => x.Name);
            cb_jarattorlesfrom.ItemsSource = Cities().Select(x => x.Name);
            cb_jarattorlesto.ItemsSource = Cities().Select(x => x.Name);
        }
        private readonly VasutContext _vasutContext = new VasutContext();
        public AdminInterface(VasutContext vasutContext)
        {
            _vasutContext = vasutContext;
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
        private void btn_varosmegjelenit_Click(object sender, RoutedEventArgs e)
        {
            
            dataGridVarosok.ItemsSource = Cities();
            dataGridVarosok.Visibility = Visibility.Visible;
        }
        private void btn_varoshozzaad_Click(object sender, RoutedEventArgs e)
        {
            string cityname = tb_varosfelvetel.Text;
            var command = Connection.OpenConnection().CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO cities(Name) VALUES(@name)";

            var param = command.CreateParameter();
            param.ParameterName = "@name";
            param.Value = cityname;
            command.Parameters.Add(param);
            command.ExecuteNonQuery();
        }
        private void btn_varosmodosit_Click(object sender, RoutedEventArgs e)
        {
            string oldcity = cb_varosreginev.Text;
            string newcity = tb_varosujnev.Text;
            var command = Connection.OpenConnection().CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE cities SET Name = @new WHERE Name = @old";

            var param1 = command.CreateParameter();
            param1.ParameterName = "@new";
            param1.Value = newcity;
            command.Parameters.Add(param1);

            var param2 = command.CreateParameter();
            param2.ParameterName = "@old";
            param2.Value = oldcity;
            command.Parameters.Add(param2);

            command.ExecuteNonQuery();
        }
        private void btn_varostorles_Click(object sender, RoutedEventArgs e)
        {
            string city = cb_varostorles.Text;
            var command = Connection.OpenConnection().CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM cities WHERE cities.Name = @name";

            var param = command.CreateParameter();
            param.ParameterName = "@name";
            param.Value = city;
            command.Parameters.Add(param);
            command.ExecuteNonQuery();
        }

        private void btn_jaratokmegjelenit_Click(object sender, RoutedEventArgs e)
        {
            List<Railway> railways = Railways();
            dataGridJaratok.ItemsSource = railways;
            dataGridJaratok.Visibility = Visibility.Visible;

        }
        private void btn_jarathozzaad_Click(object sender, RoutedEventArgs e)
        {
            string cityfrom = cb_ujjaratfrom.Text;
            string cityto = cb_ujjaratto.Text;
            int fromid = Cities().First(x => x.Name == cityfrom).ID;
            int toid = Cities().First(x => x.Name == cityto).ID;
            int km = int.Parse(tb_ujjaratkm.Text);
            var command = Connection.OpenConnection().CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO railways(FromID, ToID, Km) VALUES(@from, @to, @km)";

            var param1 = command.CreateParameter();
            param1.ParameterName = "@from";
            param1.Value = fromid;
            command.Parameters.Add(param1);

            var param2 = command.CreateParameter();
            param2.ParameterName = "@to";
            param2.Value = toid;
            command.Parameters.Add(param2);

            var param3 = command.CreateParameter();
            param3.ParameterName = "@km";
            param3.Value = km;
            command.Parameters.Add(param3);

            command.ExecuteNonQuery();
        }
        private void btn_jarattorles_Click(object sender, RoutedEventArgs e)
        {
            string cityfrom = cb_jarattorlesfrom.Text;
            string cityto = cb_jarattorlesto.Text;
            int fromid = Cities().First(x => x.Name == cityfrom).ID;
            int toid = Cities().First(x => x.Name == cityto).ID;
            var command = Connection.OpenConnection().CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM railways WHERE (railways.FromID = @from AND railways.ToID = @to)";

            var param1 = command.CreateParameter();
            param1.ParameterName = "@from";
            param1.Value = fromid;
            command.Parameters.Add(param1);

            var param2 = command.CreateParameter();
            param2.ParameterName = "@to";
            param2.Value = toid;
            command.Parameters.Add(param2);

            command.ExecuteNonQuery();
        }
        private void btn_kilep_Click(object sender, RoutedEventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            this.Close();
            adminLogin.Show();
        }
    }
}
