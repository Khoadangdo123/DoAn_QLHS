using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LopDAL
    {
        public List<string> GetKhoiList()
        {
            List<string> khoiList = new List<string>();
            string query = "SELECT TenKhoiLop FROM khoilop";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        khoiList.Add(reader.GetString(0));
                    }
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return khoiList;
        }

        public List<string> GetLopList()
        {
            List<string> lopList = new List<string>();
            string query = "SELECT TenLop FROM lop";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lopList.Add(reader.GetString(0));
                    }
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return lopList;
        }

        public List<string> GetNamhocList()
        {
            List<string> namhocList = new List<string>();
            string query = "SELECT TenNamHoc FROM namhoc";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        namhocList.Add(reader.GetString(0));
                    }
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return namhocList;
        }
    }
}
