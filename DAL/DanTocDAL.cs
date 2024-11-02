using System.Collections.Generic;
using DAL;
using MySql.Data.MySqlClient;

public class TonGiaoDAL
{
    public List<KeyValuePair<string, string>> LayDanhSachTonGiao()
    {
        List<KeyValuePair<string, string>> tongiaoList = new List<KeyValuePair<string, string>>();
        string query = "SELECT MaTonGiao, TenTonGiao FROM tongiao";

        using (MySqlConnection conn = DatabaseHelper.GetConnection())
        {
            DatabaseHelper.OpenConnection(conn);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string maTonGiao = reader["MaTonGiao"].ToString();
                string tenTonGiao = reader["TenTonGiao"].ToString();
                tongiaoList.Add(new KeyValuePair<string, string>(maTonGiao, tenTonGiao));
            }
        }

        return tongiaoList;
    }
}
