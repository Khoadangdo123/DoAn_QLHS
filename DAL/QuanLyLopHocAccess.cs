using GUI_CSharp.DTO;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuanLyLopHocAccess
    {

        public bool checkMaLop(string malop)
        {
            using (MySqlConnection connection = SqlConnectionData.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM lop WHERE MaLop = @MaLop";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        command.Parameters.AddWithValue("@MaLop", malop);
                        int count = (int)command.ExecuteScalar();
                        return count > 0; // Trả về true nếu mã lớp đã tồn tại
                    }

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Lỗi MySQL: " + ex.Message);
                    return false;
                }
            }
        }

        public List<KhoiLopDTO> getKhoiLop()
        {
            List<KhoiLopDTO> khoilopList = new List<KhoiLopDTO>();
            using (MySqlConnection connection = SqlConnectionData.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "select * from khoilop;";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            KhoiLopDTO khoilop = new KhoiLopDTO(
                                reader["MaKhoiLop"].ToString(),
                                reader["TenKhoiLop"].ToString()
                            );

                            khoilopList.Add(khoilop); // Thêm đối tượng vào danh sách
                        }
                    }

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Lỗi MySQL: " + ex.Message);
                }
                return khoilopList;
            }
        }

        public List<HocKyDTO> getHocKy()
        {
            List<HocKyDTO> hockyList = new List<HocKyDTO>();
            using (MySqlConnection connection = SqlConnectionData.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "select * from hocky;";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            HocKyDTO hocky = new HocKyDTO(
                                reader["MaHocKy"].ToString(),
                                reader["TenHocKy"].ToString(),
                                Convert.ToInt32(reader["HeSo"].ToString())
                            );

                            hockyList.Add(hocky); // Thêm đối tượng vào danh sách
                        }
                    }

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Lỗi MySQL: " + ex.Message);
                }
                return hockyList;
            }
        }

        public List<GiaoVienDTO> getGiaoVien()
        {
            List<GiaoVienDTO> giaovienList = new List<GiaoVienDTO>();
            using (MySqlConnection connection = SqlConnectionData.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "select * from giaovien;";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GiaoVienDTO giaovien = new GiaoVienDTO(
                                reader["MaGiaoVien"].ToString(),
                                reader["TenGiaoVien"].ToString(),
                                reader["DiaChi"].ToString(),
                                reader["GioiTinh"].ToString(),
                                reader["DienThoai"].ToString(),
                                reader["MaMonHoc"].ToString()
                            );

                            giaovienList.Add(giaovien); // Thêm đối tượng vào danh sách
                        }
                    }

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Lỗi MySQL: " + ex.Message);
                }
                return giaovienList;
            }
        }

        public List<NamHocDTO> getNamHoc()
        {
            List<NamHocDTO> namhocList = new List<NamHocDTO>();
            using (MySqlConnection connection = SqlConnectionData.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "select * from namhoc;";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NamHocDTO namhoc = new NamHocDTO(
                                reader["MaNamHoc"].ToString(),
                                reader["TenNamHoc"].ToString()
                            );

                            namhocList.Add(namhoc); // Thêm đối tượng vào danh sách
                        }
                    }

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Lỗi MySQL: " + ex.Message);
                }
                return namhocList;
            }
        }

        public List<LopDTO> ReadQuanLyLopHocData()
        {
            List<LopDTO> lopList = new List<LopDTO>();
            using (MySqlConnection connection = SqlConnectionData.GetConnection()) {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT *
                        FROM lop
                        JOIN giaovien ON giaovien.MaGiaoVien = lop.MaGiaoVien
                        JOIN hocky ON hocky.MaHocKy = lop.MaHocKy
                        JOIN namhoc ON namhoc.MaNamHoc = lop.MaNamHoc
                        JOIN khoilop ON lop.MaKhoiLop = khoilop.MaKhoiLop;
                    ";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            LopDTO dbLopHocList = new LopDTO(
                                reader["MaHocKy"].ToString(),
                                reader["TenHocKy"].ToString(),
                                Convert.ToInt32(reader["HeSo"]),

                                reader["MaGiaoVien"].ToString(),
                                reader["TenGiaoVien"].ToString(),
                                reader["DiaChi"].ToString(),
                                reader["DienThoai"].ToString(),
                                reader["MaMonHoc"].ToString(),
                                reader["GioiTinh"].ToString(),

                                reader["MaKhoiLop"].ToString(),
                                reader["TenKhoiLop"].ToString(),

                                reader["MaNamHoc"].ToString(),
                                reader["TenNamHoc"].ToString(),

                                reader["MaLop"].ToString(),
                                reader["TenLop"].ToString(),
                                reader["MaKhoiLop"].ToString(),
                                reader["MaNamHoc"].ToString(),
                                Convert.ToInt32(reader["SiSo"]),
                                reader["MaGiaoVien"].ToString(),
                                reader["MaHocKy"].ToString()
                            );
                            lopList.Add(dbLopHocList); // Thêm đối tượng vào danh sách
                        }
                    }

                

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Lỗi MySQL: " + ex.Message);
                }
                return lopList;
            }
        }
    
        public void DeleteLop(string malop)
        {
            using (MySqlConnection connection = SqlConnectionData.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Lop WHERE MaLop = @MaLop";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaLop", malop);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Lỗi MySQL: " + ex.Message);
                }
            }
        }

        public void InsertLop(string malop, string tenlop, string makhoilop, string manamhoc, int siso, string magiaovien, string mahocky)
        {
            using (MySqlConnection connection = SqlConnectionData.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO LOP VALUES(@MaLop, @TenLop, @MaKhoiLop, @MaNamHoc, @SiSo, @MaGiaoVien, @MaHocKy);";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaLop", malop);
                    command.Parameters.AddWithValue("@TenLop", tenlop);
                    command.Parameters.AddWithValue("@MaKhoiLop", makhoilop);
                    command.Parameters.AddWithValue("@MaNamHoc", manamhoc);
                    command.Parameters.AddWithValue("@SiSo", siso);
                    command.Parameters.AddWithValue("@MaGiaoVien", magiaovien);
                    command.Parameters.AddWithValue("@MaHocKy", mahocky);
                    command.ExecuteNonQuery(); // Thực hiện lệnh thêm
                }
            }
        }

        public void UpdateLop(string malop, string tenlop, string makhoilop, string manamhoc, int siso, string magiaovien, string mahocky)
        {
            using (MySqlConnection connection = SqlConnectionData.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Lop SET TenLop = @TenLop, MaKhoiLop = @MaKhoiLop, MaNamHoc = @MaNamHoc, " +
                               "SiSo = @SiSo, MaGiaoVien = @MaGiaoVien, MaHocKy = @MaHocKy WHERE MaLop = @MaLop";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaLop", malop);
                    command.Parameters.AddWithValue("@TenLop", tenlop);
                    command.Parameters.AddWithValue("@MaKhoiLop", makhoilop);
                    command.Parameters.AddWithValue("@MaNamHoc", manamhoc);
                    command.Parameters.AddWithValue("@SiSo", siso);
                    command.Parameters.AddWithValue("@MaGiaoVien", magiaovien);
                    command.Parameters.AddWithValue("@MaHocKy", mahocky);
                    command.ExecuteNonQuery(); // Thực hiện lệnh thêm
                }
            }
        }
    }
}
