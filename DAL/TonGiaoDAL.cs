using System.Collections.Generic;
using DAL;
using MySql.Data.MySqlClient;

public class DanTocDAL
{
    public List<KeyValuePair<string, string>> LayDanhSachDanToc()
    {
        List<KeyValuePair<string, string>> danTocList = new List<KeyValuePair<string, string>>();
        string query = "SELECT MaDanToc, TenDanToc FROM dantoc";

        using (MySqlConnection conn = DatabaseHelper.GetConnection())
        {
            DatabaseHelper.OpenConnection(conn);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string maDanToc = reader["MaDanToc"].ToString();
                string tenDanToc = reader["TenDanToc"].ToString();
                danTocList.Add(new KeyValuePair<string, string>(maDanToc, tenDanToc));
            }
        }

        return danTocList;
    }
}
