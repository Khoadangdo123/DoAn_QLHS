using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using GUI_CSharp.DTO;

namespace DAL
{
    public class HanhKiemDAL : DatabaseHelper
    {
        public string GenMaHK()
        {
            string maHanhKiem_New = "";
            string query = "SELECT MaHanhKiem FROM hanhkiem ORDER BY MaHanhKiem DESC LIMIT 1";
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    string maHanhKiem_Max = result.ToString();
                    int soThuTu = int.Parse(maHanhKiem_Max.Substring(2)) + 1;
                    maHanhKiem_New = "HK" + soThuTu.ToString("D4");
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return maHanhKiem_New;
        }
        public List<HanhKiemDTO> GetAllHanhKiem()
        {
            List<HanhKiemDTO> listHanhKiem = new List<HanhKiemDTO>();

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM HanhKiem";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        HanhKiemDTO hanhKiem = new HanhKiemDTO
                        {
                            MaHanhKiem = reader["MaHanhKiem"].ToString(),
                            TenHanhKiem = reader["TenHanhKiem"].ToString(),
                            //DiemCanTren = Convert.ToDouble(reader["DiemCanTren"]),
                            //DiemCanDuoi = Convert.ToDouble(reader["DiemCanDuoi"]),
                        };
                        listHanhKiem.Add(hanhKiem);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return listHanhKiem;
        }

        // Thêm hạnh kiểm mới
        public bool AddHanhKiem(HanhKiemDTO hanhKiem)
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO HanhKiem (MaHanhKiem, TenHanhKiem) VALUES (@MaHanhKiem, @TenHanhKiem)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaHanhKiem", hanhKiem.MaHanhKiem);
                    cmd.Parameters.AddWithValue("@TenHanhKiem", hanhKiem.TenHanhKiem);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        // Sửa thông tin hạnh kiểm
        public bool UpdateHanhKiem(HanhKiemDTO hanhKiem)
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE HanhKiem SET TenHanhKiem = @TenHanhKiem WHERE MaHanhKiem = @MaHanhKiem";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaHanhKiem", hanhKiem.MaHanhKiem);
                    cmd.Parameters.AddWithValue("@TenHanhKiem", hanhKiem.TenHanhKiem);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        // Xóa hạnh kiểm
        public bool DeleteHanhKiem(string hanhKiem)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    DatabaseHelper.OpenConnection(conn);
                    string query = "DELETE FROM hanhkiem WHERE MaHanhKiem = @MaHanhKiem";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaHanhKiem", hanhKiem);
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

        // Tìm kiếm hạnh kiểm
        public List<HanhKiemDTO> SearchHanhKiem(string searchTerm)
        {
            List<HanhKiemDTO> listHanhKiem = new List<HanhKiemDTO>();
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM hanhkiem WHERE MaHanhKiem LIKE @searchTerm OR TenHanhKiem LIKE @searchTerm";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        HanhKiemDTO hanhKiem = new HanhKiemDTO
                        {
                            MaHanhKiem = reader["MaHanhKiem"].ToString(),
                            TenHanhKiem = reader["TenHanhKiem"].ToString(),
                        };
                        listHanhKiem.Add(hanhKiem);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return  listHanhKiem;
        }
        public HanhKiemDTO GetHanhKiemByMa(string maHanhKiem)
        {
            HanhKiemDTO hanhKiem = new HanhKiemDTO();
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM hanhkiem WHERE MaHanhKiem = @MaHanhKiem";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaHanhKiem", maHanhKiem);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        hanhKiem.MaHanhKiem = reader["MaHanhKiem"].ToString();
                        hanhKiem.TenHanhKiem = reader["TenHanhKiem"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return hanhKiem;
        }
    }
}
