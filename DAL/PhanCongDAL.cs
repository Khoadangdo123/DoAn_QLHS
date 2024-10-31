using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class PhanCongDAL : DBConnect
    {
        // Phương thức lấy tất cả bản ghi từ bảng PhanCong
        public DataTable GetAllPhanCong()
        {
            DataTable dataTable = new DataTable();
            try
            {
                OpenConnection();
                string query = "SELECT * FROM PhanCong";
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return dataTable;
        }

        // Phương thức thêm một bản ghi vào bảng PhanCong
        public bool InsertPhanCong(int maNhanVien, int maDuAn, DateTime ngayPhanCong)
        {
            try
            {
                OpenConnection();
                string query = "INSERT INTO PhanCong (MaNhanVien, MaDuAn, NgayPhanCong) VALUES (@maNhanVien, @maDuAn, @ngayPhanCong)";
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());
                cmd.Parameters.AddWithValue("@maNhanVien", maNhanVien);
                cmd.Parameters.AddWithValue("@maDuAn", maDuAn);
                cmd.Parameters.AddWithValue("@ngayPhanCong", ngayPhanCong);
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

        // Phương thức cập nhật thông tin trong bảng PhanCong
        public bool UpdatePhanCong(int id, int maNhanVien, int maDuAn, DateTime ngayPhanCong)
        {
            try
            {
                OpenConnection();
                string query = "UPDATE PhanCong SET MaNhanVien = @maNhanVien, MaDuAn = @maDuAn, NgayPhanCong = @ngayPhanCong WHERE Id = @id";
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@maNhanVien", maNhanVien);
                cmd.Parameters.AddWithValue("@maDuAn", maDuAn);
                cmd.Parameters.AddWithValue("@ngayPhanCong", ngayPhanCong);
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

        // Phương thức xóa một bản ghi trong bảng PhanCong
        public bool DeletePhanCong(int id)
        {
            try
            {
                OpenConnection();
                string query = "DELETE FROM PhanCong WHERE Id = @id";
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());
                cmd.Parameters.AddWithValue("@id", id);
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

