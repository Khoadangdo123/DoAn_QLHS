using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI_CSharp.DTO;

namespace DAL
{
    public class ThoiKhoaBieuDAL : DBConnect
    {
        public ThoiKhoaBieuDAL() { }

        // Lấy tất cả bản ghi từ bảng ThoiKhoaBieu và trả về danh sách DTO
        public List<ThoiKhoaBieuDTO> GetAllTKB()
        {
            List<ThoiKhoaBieuDTO> list = new List<ThoiKhoaBieuDTO>();
            try
            {
                OpenConnection();
                string query = "SELECT * FROM thoikhoabieu";
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ThoiKhoaBieuDTO obj = new ThoiKhoaBieuDTO
                    {
                        STT = reader.GetInt32("STT"),
                        MaLop = reader.GetString("MaLop"),
                        MaNamHoc = reader.GetString("MaNamHoc"),
                        MaMonHoc = reader.GetString("MaMonHoc"),
                        MaHocKy = reader.GetString("MaHocKy"),
                        MaGiaoVien = reader.GetString("MaGiaoVien"),
                        Thu = reader.GetInt32("Thu"),
                        TietBD = reader.GetInt32("TietBD"),
                        SoTiet = reader.GetInt32("SoTiet")
                    };
                    list.Add(obj);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return list;
        }

        // Phương thức thêm một bản ghi vào bảng ThoiKhoaBieu
        public bool InsertTKB(ThoiKhoaBieuDTO obj)
        {
            try
            {
                OpenConnection();
                string query = "INSERT INTO thoikhoabieu (MaLop, MaNamHoc, MaMonHoc, MaHocKy, MaGiaoVien, Thu, TietBD, SoTiet) VALUES (@MaLop, @MaNamHoc, @MaMonHoc, @MaHocKy, @MaGiaoVien, @Thu, @TietBD, @SoTiet)";
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());

                // Chỉ cần thêm các tham số cho các trường cần thiết
                cmd.Parameters.AddWithValue("@MaLop", obj.MaLop);
                cmd.Parameters.AddWithValue("@MaNamHoc", obj.MaNamHoc);
                cmd.Parameters.AddWithValue("@MaMonHoc", obj.MaMonHoc);
                cmd.Parameters.AddWithValue("@MaHocKy", obj.MaHocKy);
                cmd.Parameters.AddWithValue("@MaGiaoVien", obj.MaGiaoVien);
                cmd.Parameters.AddWithValue("@Thu", obj.Thu);
                cmd.Parameters.AddWithValue("@TietBD", obj.TietBD);
                cmd.Parameters.AddWithValue("@SoTiet", obj.SoTiet);

                // Thực hiện câu lệnh INSERT
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        // Phương thức sửa một bản ghi trong bảng ThoiKhoaBieu
        public bool UpdateTKB(ThoiKhoaBieuDTO obj)
        {
            try
            {
                OpenConnection();
                string query = "UPDATE thoikhoabieu SET MaLop = @MaLop, MaNamHoc = @MaNamHoc, MaMonHoc = @MaMonHoc, MaHocKy = @MaHocKy, MaGiaoVien = @MaGiaoVien, Thu = @Thu, TietBD = @TietBD, SoTiet = @SoTiet WHERE STT = @STT";
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());
                cmd.Parameters.AddWithValue("@STT", obj.STT);
                cmd.Parameters.AddWithValue("@MaLop", obj.MaLop);
                cmd.Parameters.AddWithValue("@MaNamHoc", obj.MaNamHoc);
                cmd.Parameters.AddWithValue("@MaMonHoc", obj.MaMonHoc);
                cmd.Parameters.AddWithValue("@MaHocKy", obj.MaHocKy);
                cmd.Parameters.AddWithValue("@MaGiaoVien", obj.MaGiaoVien);
                cmd.Parameters.AddWithValue("@Thu", obj.Thu);
                cmd.Parameters.AddWithValue("@TietBD", obj.TietBD);
                cmd.Parameters.AddWithValue("@SoTiet", obj.SoTiet);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        // Phương thức xóa một bản ghi trong bảng ThoiKhoaBieu
        public bool DeleteTKB(ThoiKhoaBieuDTO obj)
        {
            try
            {
                OpenConnection();
                string query = "DELETE FROM thoikhoabieu WHERE STT = @STT";
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());
                cmd.Parameters.AddWithValue("@STT", obj.STT);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

    }
}
