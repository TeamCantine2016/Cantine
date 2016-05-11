using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace ProjetCantine.Models
{
    class DbConnection
    {
        public static SqlConnection connection;
        public static string connectionString = ConfigurationManager.ConnectionStrings["cantineConnectionString"].ConnectionString;
   
        public static SqlConnection getConnection()
        {
            connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
