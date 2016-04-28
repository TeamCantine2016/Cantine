using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace ProjetCantine.DbAccess
{
    class DbConnection
    {
        public static SqlConnection connection;
        public static string connectionString = ConfigurationManager.ConnectionStrings["cantineEntities"].ConnectionString;
   
        public static SqlConnection getConnection()
        {
            connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
