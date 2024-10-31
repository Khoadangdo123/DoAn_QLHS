using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class ThoiKhoaBieuDAL : DBConnect
    {
        //Lấy tất cả bản ghi từ bảng ThoiKhoaBieu
        public DataTable GetAllTKB()
        {
            DataTable dataTable = new DataTable();
            try
            {
                OpenConnection();
                string query = "SELECT * FROM ThoiKhoaBieu";
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

        public bool InsertTKB()
        {

        }
    }
}
