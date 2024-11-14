using MySql.Data.MySqlClient;
using System.Collections.Generic;
using GUI_CSharp.DTO;

namespace DAL
{
    public class GiaoVienDAL
    {
        public List<GiaoVienDTO> GetAllGiaoVien()
        {
            List<GiaoVienDTO> list = new List<GiaoVienDTO>();
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                string query = "SELECT * FROM GiaoVien";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GiaoVienDTO gv = new GiaoVienDTO
                        {
                            MaGiaoVien = reader["MaGiaoVien"].ToString(),
                            TenGiaoVien = reader["TenGiaoVien"].ToString(),
                            DiaChi = reader["DiaChi"].ToString(),
                            MaMonHoc = reader["MaMonHoc"].ToString(),
                            DienThoai = reader["DienThoai"].ToString()
                        };
                        list.Add(gv);
                    }
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return list;
        }
        public string GenMaGV()
        {
            string maGiaoVien_New = "";
            string query = "SELECT MaGiaoVien FROM GiaoVien ORDER BY MaGiaoVien DESC LIMIT 1";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string maGiaoVien_Max = result.ToString();
                    int soThuTu = int.Parse(maGiaoVien_Max.Substring(2)) + 1;
                    maGiaoVien_New = "GV" + soThuTu.ToString("D4");
                }

                DatabaseHelper.CloseConnection(conn);
            }
            return maGiaoVien_New;
        }
        public GiaoVienDTO GetGiaoVienByMaGiaoVien(string maGiaoVien)
        {
            GiaoVienDTO gv = null;
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                string query = "SELECT * FROM GiaoVien WHERE MaGiaoVien = @MaGiaoVien";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaGiaoVien", maGiaoVien);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        gv = new GiaoVienDTO
                        {
                            MaGiaoVien = reader["MaGiaoVien"].ToString(),
                            TenGiaoVien = reader["TenGiaoVien"].ToString(),
                            DiaChi = reader["DiaChi"].ToString(),
                            DienThoai = reader["DienThoai"].ToString(),
                            MaMonHoc = reader["MaMonHoc"].ToString()
                        };
                    }
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return gv;
        }

        public List<GiaoVienDTO> GetGiaoVienByMaMonHoc(string maMonHoc)
        {
            List<GiaoVienDTO> list = new List<GiaoVienDTO>();
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                string query = "SELECT * FROM GiaoVien WHERE MaMonHoc = @MaMonHoc";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GiaoVienDTO gv = new GiaoVienDTO
                        {
                            MaGiaoVien = reader["MaGiaoVien"].ToString(),
                            TenGiaoVien = reader["TenGiaoVien"].ToString(),
                            DiaChi = reader["DiaChi"].ToString(),
                            DienThoai = reader["DienThoai"].ToString(),
                            MaMonHoc = reader["MaMonHoc"].ToString()
                        };
                        list.Add(gv);
                    }
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return list;
        }

        public List<GiaoVienDTO> SearchGiaoVien(string searchTerm)
        {
            List<GiaoVienDTO> results = new List<GiaoVienDTO>();

            // Truy vấn tìm kiếm cho mã giáo viên, họ tên, hoặc email
            string query = "SELECT * FROM giaovien WHERE MaGiaoVien LIKE @search OR TenGiaoVien LIKE @search";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GiaoVienDTO giaoVien = new GiaoVienDTO
                        {
                            MaGiaoVien = reader["MaGiaoVien"].ToString(),
                            TenGiaoVien = reader["TenGiaoVien"].ToString(),
                            DiaChi = reader["DiaChi"].ToString(),
                            DienThoai = reader["DienThoai"].ToString(),
                            MaMonHoc = reader["MaMonHoc"].ToString()
                        };
                        results.Add(giaoVien);
                    }
                }
            }

            return results;
        }

    public bool InsertGiaoVien(GiaoVienDTO gv)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                string query = "INSERT INTO GiaoVien (MaGiaoVien, TenGiaoVien, DiaChi, DienThoai, MaMonHoc) VALUES (@MaGiaoVien, @TenGiaoVien, @DiaChi, @DienThoai, @MaMonHoc)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaGiaoVien", gv.MaGiaoVien);
                cmd.Parameters.AddWithValue("@TenGiaoVien", gv.TenGiaoVien);
                cmd.Parameters.AddWithValue("@DiaChi", gv.DiaChi);
                cmd.Parameters.AddWithValue("@DienThoai", gv.DienThoai);
                cmd.Parameters.AddWithValue("@MaMonHoc", gv.MaMonHoc);
                int result = cmd.ExecuteNonQuery();
                DatabaseHelper.CloseConnection(conn);
                return result > 0;
            }
        }

        public bool UpdateGiaoVien(GiaoVienDTO gv)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                string query = "UPDATE GiaoVien SET TenGiaoVien = @TenGiaoVien, DiaChi = @DiaChi, DienThoai = @DienThoai, MaMonHoc = @MaMonHoc WHERE MaGiaoVien = @MaGiaoVien";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaGiaoVien", gv.MaGiaoVien);
                cmd.Parameters.AddWithValue("@TenGiaoVien", gv.TenGiaoVien);
                cmd.Parameters.AddWithValue("@DiaChi", gv.DiaChi);
                cmd.Parameters.AddWithValue("@DienThoai", gv.DienThoai);
                cmd.Parameters.AddWithValue("@MaMonHoc", gv.MaMonHoc);
                int result = cmd.ExecuteNonQuery();
                DatabaseHelper.CloseConnection(conn);
                return result > 0;
            }
        }

        public bool DeleteGiaoVien(string maGiaoVien)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                string query = "DELETE FROM GiaoVien WHERE MaGiaoVien = @MaGiaoVien";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaGiaoVien", maGiaoVien);
                int result = cmd.ExecuteNonQuery();
                DatabaseHelper.CloseConnection(conn);
                return result > 0;
            }
        }
    }
}
