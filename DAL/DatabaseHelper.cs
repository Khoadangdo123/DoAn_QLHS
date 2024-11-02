using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DatabaseHelper
    {
        //private static string connectionString = "server=localhost;database=qlhs;user=root;password=123456;";
        private static string connectionString = "server=;database=;user=;password=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static void OpenConnection(MySqlConnection conn)
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public static void CloseConnection(MySqlConnection conn)
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
