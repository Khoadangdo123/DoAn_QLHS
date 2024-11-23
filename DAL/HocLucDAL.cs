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
    public class HocLucDAL : DatabaseHelper
    {
        public string GenMaHL()
        {
            string maHocLuc_New = "";
            string query = "SELECT MaHocLuc FROM hocluc ORDER BY MaHocLuc DESC LIMIT 1";
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    string maHocLuc_Max = result.ToString();
                    int soThuTu = int.Parse(maHocLuc_Max.Substring(2)) + 1;
                    maHocLuc_New = "HL" + soThuTu.ToString("D4");
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return maHocLuc_New;
        }
        public List<HocLucDTO> GetAllHocLuc()
        {
            List<HocLucDTO> listHocLuc = new List<HocLucDTO>();

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM HocLuc";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        HocLucDTO hocLuc = new HocLucDTO
                        {
                            MaHocLuc = reader["MaHocLuc"].ToString(),
                            TenHocLuc = reader["TenHocLuc"].ToString(),
                            DiemCanDuoi = Convert.ToDouble(reader["DiemCanDuoi"]),
                            DiemCanTren = Convert.ToDouble(reader["DiemCanTren"]),
                            DiemKhongChe = Convert.ToDouble(reader["DiemKhongChe"])
                        };
                        listHocLuc.Add(hocLuc);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return listHocLuc;
        }
        public bool AddHocLuc(HocLucDTO hocLuc)
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO HocLuc (MaHocLuc, TenHocLuc, DiemCanDuoi, DiemCanTren, DiemKhongChe) " +
                                   "VALUES (@MaHocLuc, @TenHocLuc, @DiemCanDuoi, @DiemCanTren, @DiemKhongChe)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaHocLuc", hocLuc.MaHocLuc);
                    cmd.Parameters.AddWithValue("@TenHocLuc", hocLuc.TenHocLuc);
                    cmd.Parameters.AddWithValue("@DiemCanDuoi", hocLuc.DiemCanDuoi);
                    cmd.Parameters.AddWithValue("@DiemCanTren", hocLuc.DiemCanTren);
                    cmd.Parameters.AddWithValue("@DiemKhongChe", hocLuc.DiemKhongChe);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
        public bool UpdateHocLuc(HocLucDTO hocLuc)
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE HocLuc SET TenHocLuc = @TenHocLuc, DiemCanDuoi = @DiemCanDuoi, " +
                                   "DiemCanTren = @DiemCanTren, DiemKhongChe = @DiemKhongChe WHERE MaHocLuc = @MaHocLuc";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaHocLuc", hocLuc.MaHocLuc);
                    cmd.Parameters.AddWithValue("@TenHocLuc", hocLuc.TenHocLuc);
                    cmd.Parameters.AddWithValue("@DiemCanDuoi", hocLuc.DiemCanDuoi);
                    cmd.Parameters.AddWithValue("@DiemCanTren", hocLuc.DiemCanTren);
                    cmd.Parameters.AddWithValue("@DiemKhongChe", hocLuc.DiemKhongChe);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
        public bool DeleteHocLuc(string hocLuc)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    DatabaseHelper.OpenConnection(conn);
                    string query = "DELETE FROM hocluc WHERE MaHocLuc = @MaHocLuc";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaHocLuc", hocLuc);
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
        // Tìm kiếm học lực
        public List<HocLucDTO> SearchHocLuc(string searchTerm)
        {
            List<HocLucDTO> listHocLuc = new List<HocLucDTO>();
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM HocLuc WHERE MaHocLuc LIKE @searchTerm OR TenHocLuc LIKE @searchTerm";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        HocLucDTO hocLuc = new HocLucDTO
                        {
                            MaHocLuc = reader["MaHocLuc"].ToString(),
                            TenHocLuc = reader["TenHocLuc"].ToString(),
                            DiemCanDuoi = Convert.ToDouble(reader["DiemCanDuoi"]),
                            DiemCanTren = Convert.ToDouble(reader["DiemCanTren"]),
                            DiemKhongChe = Convert.ToDouble(reader["DiemKhongChe"])
                        };
                        listHocLuc.Add(hocLuc);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return listHocLuc;
        }
        public HocLucDTO GetHocLucByMa(string maHocLuc)
        {
            HocLucDTO hocLuc = null;
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM HocLuc WHERE MaHocLuc = @MaHocLuc";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaHocLuc", maHocLuc);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        hocLuc = new HocLucDTO
                        {
                            MaHocLuc = reader["MaHocLuc"].ToString(),
                            TenHocLuc = reader["TenHocLuc"].ToString(),
                            DiemCanDuoi = Convert.ToDouble(reader["DiemCanDuoi"]),
                            DiemCanTren = Convert.ToDouble(reader["DiemCanTren"]),
                            DiemKhongChe = Convert.ToDouble(reader["DiemKhongChe"])
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return hocLuc;
        }
    }
}
