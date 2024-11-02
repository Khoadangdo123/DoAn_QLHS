using MySql.Data.MySqlClient;
using System;
using GUI_CSharp.DTO;
using System.Collections.Generic;



namespace DAL
{
    public class HocSinhDAL
    {
        public string GenMaHS()
        {
            string maHocSinh_New = "";
            string query = "SELECT MaHocSinh FROM hocsinh ORDER BY MaHocSinh DESC LIMIT 1";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {

                DatabaseHelper.OpenConnection(conn);


                MySqlCommand cmd = new MySqlCommand(query, conn);
                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string maHocSinh_Max = result.ToString();
                    int soThuTu = int.Parse(maHocSinh_Max.Substring(2)) + 1;
                    maHocSinh_New = "HS" + soThuTu.ToString("D4");
                }

                DatabaseHelper.CloseConnection(conn);

            }
            return maHocSinh_New;
        }
        public List<HocSinhDTO> GetAllHocSinh()
        {
            List<HocSinhDTO> listHocSinh = new List<HocSinhDTO>();
            string query = "SELECT * FROM hocsinh";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        HocSinhDTO hocSinh = new HocSinhDTO
                        {
                            MaHocSinh = reader["MaHocSinh"].ToString(),
                            HoTen = reader["HoTen"].ToString(),
                            GioiTinh = Convert.ToInt32(reader["GioiTinh"]),
                            NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                            DiaChi = reader["DiaChi"].ToString(),
                            MaDanToc = reader["MaDanToc"].ToString(),
                            MaTonGiao = reader["MaTonGiao"].ToString(),
                            HoTenCha = reader["HoTenCha"].ToString(),
                            MaNgheCha = reader["MaNgheCha"].ToString(),
                            HoTenMe = reader["HoTenMe"].ToString(),
                            MaNgheMe = reader["MaNgheMe"].ToString(),
                            Email = reader["Email"].ToString()
                        };

                        hocSinh.TenDanToc = GetTenDanToc(hocSinh.MaDanToc);
                        hocSinh.TenTonGiao = GetTenTonGiao(hocSinh.MaTonGiao);
                        hocSinh.TenNgheCha = GetTenNghe(hocSinh.MaNgheCha);
                        hocSinh.TenNgheMe = GetTenNghe(hocSinh.MaNgheMe);

                        listHocSinh.Add(hocSinh);
                    }
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return listHocSinh;
        }

        public bool AddHocSinh(HocSinhDTO hocSinh)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    DatabaseHelper.OpenConnection(conn);
                    string query = "INSERT INTO hocsinh (MaHocSinh, HoTen, GioiTinh, NgaySinh, DiaChi, MaDanToc, MaTonGiao, HoTenCha, MaNgheCha, HoTenMe, MaNgheMe, Email) " +
                   "VALUES (@MaHocSinh, @HoTen, @GioiTinh, @NgaySinh, @DiaChi, @MaDanToc, @MaTonGiao, @HoTenCha, @MaNgheCha, @HoTenMe, @MaNgheMe, @Email)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaHocSinh", hocSinh.MaHocSinh);
                    cmd.Parameters.AddWithValue("@HoTen", hocSinh.HoTen);
                    cmd.Parameters.AddWithValue("@GioiTinh", hocSinh.GioiTinh);
                    cmd.Parameters.AddWithValue("@NgaySinh", hocSinh.NgaySinh);
                    cmd.Parameters.AddWithValue("@DiaChi", hocSinh.DiaChi);
                    cmd.Parameters.AddWithValue("@MaDanToc", hocSinh.MaDanToc);
                    cmd.Parameters.AddWithValue("@MaTonGiao", hocSinh.MaTonGiao);
                    cmd.Parameters.AddWithValue("@HoTenCha", hocSinh.HoTenCha);
                    cmd.Parameters.AddWithValue("@MaNgheCha", hocSinh.MaNgheCha);
                    cmd.Parameters.AddWithValue("@HoTenMe", hocSinh.HoTenMe);
                    cmd.Parameters.AddWithValue("@MaNgheMe", hocSinh.MaNgheMe);
                    cmd.Parameters.AddWithValue("@Email", hocSinh.Email);

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

        public bool UpdateHocSinh(HocSinhDTO hocSinh)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    DatabaseHelper.OpenConnection(conn);
                    string query = "UPDATE hocsinh SET HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DiaChi = @DiaChi, MaDanToc = @MaDanToc, MaTonGiao = @MaTonGiao, HoTenCha = @HoTenCha, MaNgheCha = @MaNgheCha, HoTenMe = @HoTenMe, MaNgheMe = @MaNgheMe, Email = @Email WHERE MaHocSinh = @MaHocSinh";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@MaHocSinh", hocSinh.MaHocSinh);
                    cmd.Parameters.AddWithValue("@HoTen", hocSinh.HoTen);
                    cmd.Parameters.AddWithValue("@GioiTinh", hocSinh.GioiTinh);
                    cmd.Parameters.AddWithValue("@NgaySinh", hocSinh.NgaySinh);
                    cmd.Parameters.AddWithValue("@DiaChi", hocSinh.DiaChi);
                    cmd.Parameters.AddWithValue("@MaDanToc", hocSinh.MaDanToc);
                    cmd.Parameters.AddWithValue("@MaTonGiao", hocSinh.MaTonGiao);
                    cmd.Parameters.AddWithValue("@HoTenCha", hocSinh.HoTenCha);
                    cmd.Parameters.AddWithValue("@MaNgheCha", hocSinh.MaNgheCha);
                    cmd.Parameters.AddWithValue("@HoTenMe", hocSinh.HoTenMe);
                    cmd.Parameters.AddWithValue("@MaNgheMe", hocSinh.MaNgheMe);
                    cmd.Parameters.AddWithValue("@Email", hocSinh.Email);

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

        public bool DeleteHocSinh(string hocSinh)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    DatabaseHelper.OpenConnection(conn);
                    string query = "DELETE FROM hocsinh WHERE MaHocSinh = @MaHocSinh";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@MaHocSinh", hocSinh);


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

        public List<HocSinhDTO> SearchHocSinh(string searchTerm)
        {
            List<HocSinhDTO> results = new List<HocSinhDTO>();

            // Truy vấn tìm kiếm cho mã học sinh, họ tên, hoặc email
            string query = "SELECT * FROM hocsinh WHERE MaHocSinh LIKE @search OR HoTen LIKE @search OR Email LIKE @search";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        HocSinhDTO hocSinh = new HocSinhDTO
                        {
                            MaHocSinh = reader["MaHocSinh"].ToString(),
                            HoTen = reader["HoTen"].ToString(),
                            GioiTinh = Convert.ToInt32(reader["GioiTinh"]),
                            NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                            DiaChi = reader["DiaChi"].ToString(),
                            MaDanToc = reader["MaDanToc"].ToString(),
                            MaTonGiao = reader["MaTonGiao"].ToString(),
                            HoTenCha = reader["HoTenCha"].ToString(),
                            MaNgheCha = reader["MaNgheCha"].ToString(),
                            HoTenMe = reader["HoTenMe"].ToString(),
                            MaNgheMe = reader["MaNgheMe"].ToString(),
                            Email = reader["Email"].ToString()
                        };
                        results.Add(hocSinh);
                    }
                }
            }

            return results;
        }


        public HocSinhDTO GetHocSinhByMa(string maHocSinh)
        {
            HocSinhDTO hocSinh = null;

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                string query = "SELECT * FROM hocsinh WHERE MaHocSinh = @MaHocSinh";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MaHocSinh", maHocSinh);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    hocSinh = new HocSinhDTO
                    {
                        MaHocSinh = reader["MaHocSinh"].ToString(),
                        HoTen = reader["HoTen"].ToString(),
                        GioiTinh = Convert.ToInt32(reader["GioiTinh"]),
                        NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                        DiaChi = reader["DiaChi"].ToString(),
                        MaDanToc = reader["MaDanToc"].ToString(),
                        MaTonGiao = reader["MaTonGiao"].ToString(),
                        HoTenCha = reader["HoTenCha"].ToString(),
                        MaNgheCha = reader["MaNgheCha"].ToString(),
                        HoTenMe = reader["HoTenMe"].ToString(),
                        MaNgheMe = reader["MaNgheMe"].ToString(),
                        Email = reader["Email"].ToString()
                    };
                }
            }

            return hocSinh;
        }


        public string GetTenDanToc(string maDanToc)
        {
            string tenDanToc = "";
            string query = "SELECT TenDanToc FROM dantoc WHERE MaDanToc = @MaDanToc";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDanToc", maDanToc);

                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    tenDanToc = result.ToString();
                }

                DatabaseHelper.CloseConnection(conn);
            }
            return tenDanToc;
        }

        public string GetTenTonGiao(string maTonGiao)
        {
            string tenTonGiao = "";
            string query = "SELECT TenTonGiao FROM tongiao WHERE MaTonGiao = @MaTonGiao";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaTonGiao", maTonGiao);

                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    tenTonGiao = result.ToString();
                }

                DatabaseHelper.CloseConnection(conn);
            }
            return tenTonGiao;
        }

        public string GetTenNghe(string maNghe)
        {
            string tenNghe = "";
            string query = "SELECT TenNghe FROM nghenghiep WHERE MaNghe = @MaNghe";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNghe", maNghe);

                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    tenNghe = result.ToString();
                }

                DatabaseHelper.CloseConnection(conn);
            }
            return tenNghe;
        }


    }
}
