using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasuthalozatAdminApplication.Entities
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
