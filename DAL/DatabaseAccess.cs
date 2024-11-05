using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using GUI_CSharp.DTO;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace DAL
{
    public class SqlConnectionData
    {
        public static MySqlConnection GetConnection()
        {
            string connectionString = "Server=localhost;Database=qlhs;User ID=root;Password=tony123;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }
    }


    public class DatabaseAccess
    {
        public NguoiDungDTO Kiemtralogic(NguoiDungDTO taikhoan)
        {
            NguoiDungDTO result = new NguoiDungDTO("","","", "", "");
            using (MySqlConnection connection = SqlConnectionData.GetConnection())
            {
                try
                {
                    connection.Open();

                    // Ví dụ về câu truy vấn
                    string query = "SELECT MaNguoiDung, MaLoai, TenNguoiDung, TenDangNhap, MatKhau FROM Nguoidung WHERE TenDangNhap = @taikhoan and MatKhau=@matkhau";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@taikhoan", taikhoan.TenDangNhap);
                    command.Parameters.AddWithValue("@matkhau", taikhoan.MatKhau);

                    // Thực hiện truy vấn và lấy dữ liệu
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = new NguoiDungDTO
                            {
                                MaNguoiDung = reader["MaNguoiDung"].ToString(),
                                MaLoai = reader["MaLoai"].ToString(),
                                TenNguoiDung = reader["TenNguoiDung"].ToString(),
                                TenDangNhap = reader["TenDangNhap"].ToString(),
                                MatKhau = reader["MatKhau"].ToString()
                                
                            };
                            return result;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Lỗi MySQL: " + ex.Message);
                }
                
            }
            return result;
        }
    }


}
