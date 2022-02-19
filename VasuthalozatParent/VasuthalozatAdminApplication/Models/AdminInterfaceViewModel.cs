using System.Collections.Generic;
using System.Data;
using System.Linq;
using VasuthalozatAdminApplication.Database;
using VasuthalozatAdminApplication.Entities;
using VasuthalozatAdminApplication.Views;

namespace VasuthalozatAdminApplication.Models
{
    public class AdminInterfaceViewModel
    {
        public static void PostVaros(string cityname)
        {
            var command = Connection.OpenConnection().CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO cities(Name) VALUES(@name)";

            var param = command.CreateParameter();
            param.ParameterName = "@name";
            param.Value = cityname;
            command.Parameters.Add(param);
            command.ExecuteNonQuery();
        }
        public static void UpdateVaros(string newcity, string oldcity)
        {
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
        public static void DeleteVaros(string city, IEnumerable<City> cities)
        {
            int cityid = cities.First(x => x.Name == city).ID;

            var command = Connection.OpenConnection().CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM railways WHERE (railways.FromID = @cityid OR railways.ToID = @cityid)";

            var param = command.CreateParameter();
            param.ParameterName = "@cityid";
            param.Value = cityid;
            command.Parameters.Add(param);
            command.ExecuteNonQuery();

            var command2 = Connection.OpenConnection().CreateCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "DELETE FROM cities WHERE cities.Name = @city";

            var param2 = command.CreateParameter();
            param2.ParameterName = "@city";
            param2.Value = city;
            command2.Parameters.Add(param2);
            command2.ExecuteNonQuery();
        }
        public static List<Railway> Kruskal(List<City> cities, List<Railway> railways)
        {
            List<Railway> MST = Algorithms.Kruskal.KruskalAlgSecondTry(cities, railways);
            return MST;
        }
        public static void PostJarat(string cityfrom, string cityto, int km, List<City> cities)
        {
            int fromid = cities.First(x => x.Name == cityfrom).ID;
            int toid = cities.First(x => x.Name == cityto).ID;
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
        public static void DeleteJarat(string cityfrom, string cityto, List<City> cities)
        {
            int fromid = cities.First(x => x.Name == cityfrom).ID;
            int toid = cities.First(x => x.Name == cityto).ID;
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
        public static void LogOut(AdminInterface adminInterface)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminInterface.Close();
            adminLogin.Show();
        }
    }
}
