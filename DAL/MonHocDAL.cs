using MySql.Data.MySqlClient;
using System.Collections.Generic;
using GUI_CSharp.DTO;

namespace DAL
{
    public class MonHocDAL
    {
        public List<MonHocDTO> GetAllMonHoc()
        {
            List<MonHocDTO> list = new List<MonHocDTO>();
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                string query = "SELECT * FROM MonHoc";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MonHocDTO mh = new MonHocDTO
                        {
                            MaMonHoc = reader["MaMonHoc"].ToString(),
                            TenMonHoc = reader["TenMonHoc"].ToString(),
                            SoTiet = int.Parse(reader["SoTiet"].ToString()),
                            HeSo = int.Parse(reader["HeSo"].ToString())
                        };
                        list.Add(mh);
                    }
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return list;
        }
    }
}
