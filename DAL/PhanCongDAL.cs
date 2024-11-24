using MySql.Data.MySqlClient;
using System.Collections.Generic;
using GUI_CSharp.DTO;
using System;

namespace DAL
{
    public class PhanCongDAL
    {
        public List<PhanCongDTO> GetAllPhanCong()
        {
            List<PhanCongDTO> list = new List<PhanCongDTO>();
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                string query = "SELECT * FROM PhanCong";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PhanCongDTO pc = new PhanCongDTO
                        {
                            STT = int.Parse(reader["STT"].ToString()),
                            MaGiaoVien = reader["MaGiaoVien"].ToString(),
                            MaLop = reader["MaLop"].ToString(),
                            MaMonHoc = reader["MaMonHoc"].ToString(),
                            MaNamHoc = reader["MaNamHoc"].ToString(),
                            SoTiet = int.Parse(reader["SoTiet"].ToString()),
                            NgayPhanCong = DateTime.Parse(reader["NgayPhanCong"].ToString())
                        };
                        list.Add(pc);
                    }
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return list;
        }

        public int GenSTT()
        {
            int newSTT = 1;
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                string query = "SELECT MAX(STT) FROM PhanCong";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    newSTT = Convert.ToInt32(result) + 1;
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return newSTT;
        }

        public PhanCongDTO GetPhanCongBySTT(int stt)
        {
            PhanCongDTO pc = null;
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                string query = "SELECT * FROM PhanCong WHERE STT = @STT";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@STT", stt);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        pc = new PhanCongDTO
                        {
                            STT = int.Parse(reader["STT"].ToString()),
                            MaGiaoVien = reader["MaGiaoVien"].ToString(),
                            MaLop = reader["MaLop"].ToString(),
                            MaMonHoc = reader["MaMonHoc"].ToString(),
                            MaNamHoc = reader["MaNamHoc"].ToString(),
                            SoTiet = int.Parse(reader["SoTiet"].ToString())
                        };
                    }
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return pc;
        }

        public bool InsertPhanCong(PhanCongDTO pc)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                string query = "INSERT INTO PhanCong (MaGiaoVien, MaLop, MaMonHoc, MaNamHoc, SoTiet,NgayPhanCong) VALUES (@MaGiaoVien, @MaLop, @MaMonHoc, @MaNamHoc, @SoTiet,@NgayPhanCong)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaGiaoVien", pc.MaGiaoVien);
                cmd.Parameters.AddWithValue("@MaLop", pc.MaLop);
                cmd.Parameters.AddWithValue("@MaMonHoc", pc.MaMonHoc);
                cmd.Parameters.AddWithValue("@MaNamHoc", pc.MaNamHoc);
                cmd.Parameters.AddWithValue("@SoTiet", pc.SoTiet);
                cmd.Parameters.AddWithValue("@NgayPhanCong", pc.NgayPhanCong);
                int result = cmd.ExecuteNonQuery();
                DatabaseHelper.CloseConnection(conn);
                return result > 0;
            }
        }

        public bool UpdatePhanCong(PhanCongDTO pc)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                string query = "UPDATE PhanCong SET MaGiaoVien = @MaGiaoVien, MaLop = @MaLop, MaMonHoc = @MaMonHoc, MaNamHoc = @MaNamHoc, SoTiet = @SoTiet, NgayPhanCong = @NgayPhanCong WHERE STT = @STT";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@STT", pc.STT);
                cmd.Parameters.AddWithValue("@MaGiaoVien", pc.MaGiaoVien);
                cmd.Parameters.AddWithValue("@MaLop", pc.MaLop);
                cmd.Parameters.AddWithValue("@MaMonHoc", pc.MaMonHoc);
                cmd.Parameters.AddWithValue("@MaNamHoc", pc.MaNamHoc);
                cmd.Parameters.AddWithValue("@SoTiet", pc.SoTiet);
                cmd.Parameters.AddWithValue("@NgayPhanCong", pc.NgayPhanCong);
                int result = cmd.ExecuteNonQuery();
                DatabaseHelper.CloseConnection(conn);
                return result > 0;
            }
        }

        public bool DeletePhanCong(int stt)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                string query = "DELETE FROM PhanCong WHERE STT = @STT";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@STT", stt);
                int result = cmd.ExecuteNonQuery();
                DatabaseHelper.CloseConnection(conn);
                return result > 0;
            }
        }

        public List<KeyValuePair<string, string>> LayDanhSachNamHoc()
        {
            List<KeyValuePair<string, string>> namHocList = new List<KeyValuePair<string, string>>();
            string query = "SELECT MaNamHoc, TenNamHoc FROM namhoc";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string maNamHoc = reader["MaNamHoc"].ToString();
                    string tenNamHoc = reader["TenNamHoc"].ToString();
                    namHocList.Add(new KeyValuePair<string, string>(maNamHoc, tenNamHoc));
                }
            }

            return namHocList;
        }

        public List<KeyValuePair<string, string>> LayDanhSachLop()
        {
            List<KeyValuePair<string, string>> lopList = new List<KeyValuePair<string, string>>();
            string query = "SELECT MaLop, TenLop FROM lop";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string maLop = reader["MaLop"].ToString();
                    string tenLop = reader["TenLop"].ToString();
                    lopList.Add(new KeyValuePair<string, string>(maLop, tenLop));
                }
            }

            return lopList;
        }

        public List<PhanCongDTO> SearchPhanCong(string searchTerm)
        {
            List<PhanCongDTO> results = new List<PhanCongDTO>();

            string query = "SELECT * FROM PhanCong WHERE MaGiaoVien LIKE @search OR MaLop LIKE @search OR MaMonHoc LIKE @search";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PhanCongDTO phanCong = new PhanCongDTO
                        {
                            STT = int.Parse(reader["STT"].ToString()),
                            MaGiaoVien = reader["MaGiaoVien"].ToString(),
                            MaLop = reader["MaLop"].ToString(),
                            MaMonHoc = reader["MaMonHoc"].ToString(),
                            MaNamHoc = reader["MaNamHoc"].ToString(),
                            SoTiet = int.Parse(reader["SoTiet"].ToString())
                        };
                        results.Add(phanCong);
                    }
                }
            }

            return results;
        }
    }
}
