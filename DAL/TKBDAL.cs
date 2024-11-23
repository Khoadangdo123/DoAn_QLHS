using GUI_CSharp.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TKBDAL
    {
        public List<ThoiKhoaBieuDTO> getAllTKB() 
        {
            List<ThoiKhoaBieuDTO> list = new List<ThoiKhoaBieuDTO> ();

            String query = "Select * from thoikhoabieu";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int STT = Convert.ToInt16(reader["STT"].ToString());
                    string MaLop = reader["MaLop"].ToString();
                    string MaNamHoc = reader["MaNamHoc"].ToString();
                    string MaMonHoc = reader["MaMonHoc"].ToString();
                    string MaHocKy = reader["MaHocKy"].ToString();
                    string MaGiaoVien = reader["MaGiaoVien"].ToString();
                    int Thu = Convert.ToInt16(reader["Thu"].ToString());
                    int TietBD = Convert.ToInt16(reader["TietBD"].ToString());
                    int SoTiet = Convert.ToInt16(reader["SoTiet"].ToString());

                    list.Add(new ThoiKhoaBieuDTO(STT,MaLop,MaNamHoc,MaMonHoc, MaHocKy,MaGiaoVien,Thu,TietBD,SoTiet));
                }
            }

            return list;
        }

        public List<NamHocDTO> getNamHoc()
        {
            List<NamHocDTO> list = new List<NamHocDTO> ();

            String query = "SELECT DISTINCT NamHoc.MaNamHoc, NamHoc.TenNamHoc FROM NamHoc INNER JOIN ThoiKhoaBieu ON NamHoc.MaNamHoc = ThoiKhoaBieu.MaNamHoc;";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string MaNH = reader["MaNamHoc"].ToString();
                    string TenNH = reader["TenNamHoc"].ToString();
                    

                    list.Add(new NamHocDTO(MaNH,TenNH));
                }
            }

            return list;

        }

        public List<HocKyDTO> getHocKy_NamHoc(string namhoc)
        {
            List<HocKyDTO> list = new List<HocKyDTO>();

            // Sử dụng tham số @namhoc thay vì giá trị trực tiếp trong query
            string query = @"SELECT DISTINCT HocKy.MaHocKy, HocKy.TenHocKy 
                     FROM HocKy 
                     INNER JOIN thoikhoabieu ON HocKy.MaHocKy = thoikhoabieu.MaHocKy 
                     WHERE thoikhoabieu.MaNamHoc = @namhoc;";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    DatabaseHelper.OpenConnection(conn); // Mở kết nối
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Thêm tham số @namhoc vào câu lệnh SQL
                    cmd.Parameters.AddWithValue("@namhoc", namhoc);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string MaHK = reader["MaHocKy"].ToString();
                            string TenHK = reader["TenHocKy"].ToString();

                            // Nếu cột HeSo tồn tại, xử lý thêm, nếu không thì bỏ qua
                            int heso = reader["HeSo"] != DBNull.Value ? Convert.ToInt32(reader["HeSo"]) : 0;

                            // Tạo đối tượng HocKyDTO và thêm vào danh sách
                            list.Add(new HocKyDTO(MaHK, TenHK, heso));
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log lỗi nếu có
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    // Đảm bảo đóng kết nối
                    DatabaseHelper.CloseConnection(conn);
                }
            }

            return list;
        }


    }
}
