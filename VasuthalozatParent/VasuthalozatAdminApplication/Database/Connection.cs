using MySqlConnector;
using System.Data;

namespace VasuthalozatAdminApplication.Database
{
    public class Connection
    {
        public static IDbConnection OpenConnection()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Database = "railway_project";
            builder.Password = "";
            IDbConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();
            return connection;
        }
    }
}
