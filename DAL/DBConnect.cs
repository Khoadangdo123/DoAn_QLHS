using System;
using MySql.Data.MySqlClient; // Thêm thư viện MySQL

namespace DAL
{
    public class DBConnect
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;database=qlhs;uid=root;pwd=hwxu;";

        public DBConnect()
        {
            connection = new MySqlConnection(connectionString);
        }

        // Phương thức mở kết nối
        public void OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    Console.WriteLine("Kết nối thành công!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }

        // Phương thức đóng kết nối
        public void CloseConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    Console.WriteLine("Đã đóng kết nối!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }

        // Phương thức để lấy kết nối hiện tại
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
