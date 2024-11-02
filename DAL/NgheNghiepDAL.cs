using System.Collections.Generic;
using DAL;
using MySql.Data.MySqlClient;

public class NgheNghiepDAL
{
    public List<KeyValuePair<string, string>> LayDanhSachNgheNghiep()
    {
        List<KeyValuePair<string, string>> nghenghiepList = new List<KeyValuePair<string, string>>();
        string query = "SELECT MaNghe, TenNghe FROM nghenghiep";

        using (MySqlConnection conn = DatabaseHelper.GetConnection())
        {
            DatabaseHelper.OpenConnection(conn);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string maNghe = reader["MaNghe"].ToString();
                string tenNghe = reader["TenNghe"].ToString();
                nghenghiepList.Add(new KeyValuePair<string, string>(maNghe, tenNghe));
            }
        }

        return nghenghiepList;
    }
}
