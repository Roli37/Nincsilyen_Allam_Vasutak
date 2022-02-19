using MySqlConnector;
using System.Data;

namespace VasuthalozatAdminApplication.Database
{
    public class Connection
    {
        public static IDbConnection OpenConnection()
        {
            MySqlConnectionStringBuilder builder = new()
            {
                Server = "localhost",
                UserID = "root",
                Database = "railway_project",
                Password = ""
            };
            IDbConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();
            return connection;
        }
    }
}
