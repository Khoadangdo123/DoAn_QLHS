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
    public class ThanhTichDAL : DatabaseHelper
    {

        public string GenMaTT()
        {
            string maThanhTich_New = "";
            string query = "SELECT MaThanhTich FROM ThanhTich ORDER BY MaThanhTich DESC LIMIT 1";
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    string maThanhTich_Max = result.ToString();
                    int soThuTu = int.Parse(maThanhTich_Max.Substring(2)) + 1;
                    maThanhTich_New = "TT" + soThuTu.ToString("D4");
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return maThanhTich_New;
        }
        public List<ThanhTichDTO> GetAllThanhTich()
        {
            List<ThanhTichDTO> listThanhTich = new List<ThanhTichDTO>();
            string query = "SELECT * FROM thanhtich";
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ThanhTichDTO thanhTich = new ThanhTichDTO
                        {
                            MaThanhTich = reader["MaThanhTich"].ToString(),
                            MaHocSinh = reader["MaHocSinh"].ToString(),
                            MaNamHoc = reader["MaNamHoc"].ToString(),
                            MaLop = reader["MaLop"].ToString(),
                            MaHocKy = reader["MaHocKy"].ToString(),
                            NgayLap = Convert.ToDateTime(reader["NgayLap"]),
                            NoiDung = reader["NoiDung"].ToString(),
                            DiemThuong = Convert.ToDouble(reader["DiemThuong"])
                        };


                        listThanhTich.Add(thanhTich);
                    }
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return listThanhTich;
        }

        public bool AddThanhTich(ThanhTichDTO thanhTich)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    DatabaseHelper.OpenConnection(conn);
                    string query = "INSERT INTO thanhtich (MaThanhTich, NoiDung, DiemThuong) " +
                               "VALUES (@MaThanhTich, @NoiDung, @DiemThuong)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaThanhTich", thanhTich.MaThanhTich);
                    //cmd.Parameters.AddWithValue("@MaNamHoc", thanhTich.MaNamHoc);
                    //cmd.Parameters.AddWithValue("@MaLop", thanhTich.MaLop);
                    //cmd.Parameters.AddWithValue("@MaHocKy", thanhTich.MaHocKy);
                    //cmd.Parameters.AddWithValue("@NgayLap", thanhTich.NgayLap);
                    cmd.Parameters.AddWithValue("@NoiDung", thanhTich.NoiDung);
                    cmd.Parameters.AddWithValue("@DiemThuong", thanhTich.DiemThuong);
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
        public bool DeleteThanhTich(string thanhTich)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    DatabaseHelper.OpenConnection(conn);
                    string query = "DELETE FROM thanhtich WHERE MaThanhTich = @MaThanhTich";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaThanhTich", thanhTich);
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
        public bool UpdateThanhTich(ThanhTichDTO thanhTich)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    DatabaseHelper.OpenConnection(conn);
                    string query = "UPDATE thanhtich SET MaHocSinh = @MaHocSinh, MaNamHoc = @MaNamHoc, MaLop = @MaLop, MaHocKy = @MaHocKy, NgayLap = @NgayLap, NoiDung = @NoiDung, DiemThuong = @DiemThuong WHERE STT = @STT";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaHocSinh", thanhTich.MaHocSinh);
                    cmd.Parameters.AddWithValue("@MaNamHoc", thanhTich.MaNamHoc);
                    cmd.Parameters.AddWithValue("@MaLop", thanhTich.MaLop);
                    cmd.Parameters.AddWithValue("@MaHocKy", thanhTich.MaHocKy);
                    cmd.Parameters.AddWithValue("@NgayLap", thanhTich.NgayLap);
                    cmd.Parameters.AddWithValue("@NoiDung", thanhTich.NoiDung);
                    cmd.Parameters.AddWithValue("@DiemThuong", thanhTich.DiemThuong);
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
        public List<ThanhTichDTO> SearchThanhTich(string searchTerm)
        {
            List<ThanhTichDTO> listThanhTich = new List<ThanhTichDTO>();
            string query = "SELECT * FROM thanhtich WHERE MaThanhTich LIKE @searchTerm OR NoiDung LIKE @searchTerm";
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ThanhTichDTO thanhTich = new ThanhTichDTO
                        {
                            MaThanhTich = reader["MaThanhTich"].ToString(),
                            MaHocSinh = reader["MaHocSinh"].ToString(),
                            MaNamHoc = reader["MaNamHoc"].ToString(),
                            MaLop = reader["MaLop"].ToString(),
                            MaHocKy = reader["MaHocKy"].ToString(),
                            NgayLap = Convert.ToDateTime(reader["NgayLap"]),
                            NoiDung = reader["NoiDung"].ToString(),
                            DiemThuong = Convert.ToDouble(reader["DiemThuong"])
                        };
                        listThanhTich.Add(thanhTich);
                    }
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return listThanhTich;

        }
        public ThanhTichDTO GetThanhTichByMa(string maThanhTich)
        {
            ThanhTichDTO thanhTich = null;
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                string query = "SELECT * FROM thanhtich WHERE MaThanhTich = @MaThanhTich";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaThanhTich", maThanhTich);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    thanhTich = new ThanhTichDTO
                    {
                        MaThanhTich = reader["MaThanhTich"].ToString(),
                        MaHocSinh = reader["MaHocSinh"].ToString(),
                        MaNamHoc = reader["MaNamHoc"].ToString(),
                        MaLop = reader["MaLop"].ToString(),
                        MaHocKy = reader["MaHocKy"].ToString(),
                        NgayLap = Convert.ToDateTime(reader["NgayLap"]),
                        NoiDung = reader["NoiDung"].ToString(),
                        DiemThuong = Convert.ToDouble(reader["DiemThuong"])
                    };
                }
            }
            return thanhTich;
        }

    }
}
