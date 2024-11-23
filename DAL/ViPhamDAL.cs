using MySql.Data.MySqlClient;
using System;
using GUI_CSharp.DTO;
using System.Collections.Generic;

namespace DAL
{
    public class ViPhamDAL : DatabaseHelper
    {
        public string GenMaVP()
        {
            string maViPham_New = "";
            string query = "SELECT MaViPham FROM vipham ORDER BY MaViPham DESC LIMIT 1";
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    string maViPham_Max = result.ToString();
                    int soThuTu = int.Parse(maViPham_Max.Substring(2)) + 1;
                    maViPham_New = "VP" + soThuTu.ToString("D4");
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return maViPham_New;
        }
        public List<ViPhamDTO> GetAllViPham()
        {
            List<ViPhamDTO> listViPham = new List<ViPhamDTO>();
            string query = "SELECT * FROM vipham";
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ViPhamDTO viPham = new ViPhamDTO
                        {
                            MaViPham = reader["MaViPham"].ToString(),
                            MaHocSinh = reader["MaHocSinh"].ToString(),
                            MaNamHoc = reader["MaNamHoc"].ToString(),
                            MaLop = reader["MaLop"].ToString(),
                            MaHocKy = reader["MaHocKy"].ToString(),
                            NgayLap = Convert.ToDateTime(reader["NgayLap"]),
                            NoiDung = reader["NoiDung"].ToString(),
                            DiemTru = Convert.ToDouble(reader["DiemTru"])
                        };


                        listViPham.Add(viPham);
                    }
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return listViPham;
        }

        public bool InsertViPham(ViPhamDTO viPham)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    DatabaseHelper.OpenConnection(conn);
                    string query = "INSERT INTO ViPham (MaViPham, NoiDung, DiemTru) " +
                               "VALUES (@MaViPham, @NoiDung, @DiemTru)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaViPham", viPham.MaViPham);
                    //cmd.Parameters.AddWithValue("@MaNamHoc", viPham.MaNamHoc);
                    //cmd.Parameters.AddWithValue("@MaLop", viPham.MaLop);
                    //cmd.Parameters.AddWithValue("@MaHocKy", viPham.MaHocKy);
                    //cmd.Parameters.AddWithValue("@NgayLap", viPham.NgayLap);
                    cmd.Parameters.AddWithValue("@NoiDung", viPham.NoiDung);
                    cmd.Parameters.AddWithValue("@DiemTru", viPham.DiemTru);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
                finally
                {
                    DatabaseHelper.CloseConnection(conn);
                }
            }
        }
        public bool DeleteViPham(string viPham)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    DatabaseHelper.OpenConnection(conn);
                    string query = "DELETE FROM vipham WHERE MaViPham = @MaViPham";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaViPham", viPham);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
                finally
                {
                    DatabaseHelper.CloseConnection(conn);
                }
            }
        }
        public bool UpdateViPham(ViPhamDTO viPham)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    DatabaseHelper.OpenConnection(conn);
                    string query = "UPDATE ViPham SET MaHocSinh = @MaHocSinh, MaNamHoc = @MaNamHoc, MaLop = @MaLop, MaHocKy = @MaHocKy, NgayLap = @NgayLap, NoiDung = @NoiDung, DiemTru = @DiemTru WHERE STT = @STT";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaHocSinh", viPham.MaHocSinh);
                    cmd.Parameters.AddWithValue("@MaNamHoc", viPham.MaNamHoc);
                    cmd.Parameters.AddWithValue("@MaLop", viPham.MaLop);
                    cmd.Parameters.AddWithValue("@MaHocKy", viPham.MaHocKy);
                    cmd.Parameters.AddWithValue("@NgayLap", viPham.NgayLap);
                    cmd.Parameters.AddWithValue("@NoiDung", viPham.NoiDung);
                    cmd.Parameters.AddWithValue("@DiemTru", viPham.DiemTru);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
                finally
                {
                    DatabaseHelper.CloseConnection(conn);
                }
            }
           
        }
        public List<ViPhamDTO> SearchViPham(string searchTerm)
        {
            List<ViPhamDTO> listViPham = new List<ViPhamDTO>();
            string query = "SELECT * FROM vipham WHERE MaViPham LIKE @searchTerm OR NoiDung LIKE @searchTerm";
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ViPhamDTO viPham = new ViPhamDTO
                        {
                            MaViPham = reader["MaViPham"].ToString(),
                            MaHocSinh = reader["MaHocSinh"].ToString(),
                            MaNamHoc = reader["MaNamHoc"].ToString(),
                            MaLop = reader["MaLop"].ToString(),
                            MaHocKy = reader["MaHocKy"].ToString(),
                            NgayLap = Convert.ToDateTime(reader["NgayLap"]),
                            NoiDung = reader["NoiDung"].ToString(),
                            DiemTru = Convert.ToDouble(reader["DiemTru"])
                        };
                        listViPham.Add(viPham);
                    }
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return listViPham;
        }

        public ViPhamDTO GetViPhamByMa(string maViPham)
        {
            ViPhamDTO viPham = null;
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                string query = "SELECT * FROM vipham WHERE MaViPham = @MaViPham";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaViPham", maViPham);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    viPham = new ViPhamDTO
                    {
                        MaViPham = reader["MaHocSinh"].ToString(),
                        MaHocSinh = reader["MaHocSinh"].ToString(),
                        MaNamHoc = reader["MaNamHoc"].ToString(),
                        MaLop = reader["MaLop"].ToString(),
                        MaHocKy = reader["MaHocKy"].ToString(),
                        NgayLap = Convert.ToDateTime(reader["NgayLap"]),
                        NoiDung = reader["NoiDung"].ToString(),
                        DiemTru = Convert.ToDouble(reader["DiemTru"])
                    };
                }
            }
            return viPham;
        }
    }
}
