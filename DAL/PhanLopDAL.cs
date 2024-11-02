using GUI_CSharp.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhanLopDAL
    {
        public List<HocSinhDTO> GetHocSinhByPhanLop(string maNamHoc, string maHocKy, string maKhoiLop, string maLop)
        {
            List<HocSinhDTO> hocSinhList = new List<HocSinhDTO>();

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);

                string query = @"
                SELECT pl.MaHocSinh, hs.HoTen
                FROM phanlop pl
                JOIN hocsinh hs ON pl.MaHocSinh = hs.MaHocSinh
                WHERE pl.MaNamHoc = @MaNamHoc AND pl.MaHocKy = @MaHocKy 
                      AND pl.MaKhoiLop = @MaKhoiLop AND pl.MaLop = @MaLop";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNamHoc", maNamHoc);
                    cmd.Parameters.AddWithValue("@MaHocKy", maHocKy);
                    cmd.Parameters.AddWithValue("@MaKhoiLop", maKhoiLop);
                    cmd.Parameters.AddWithValue("@MaLop", maLop);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            HocSinhDTO hocSinh = new HocSinhDTO
                            {
                                MaHocSinh = reader["MaHocSinh"].ToString(),
                                HoTen = reader["HoTen"].ToString()
                            };
                            hocSinhList.Add(hocSinh);
                        }
                    }
                }

                DatabaseHelper.CloseConnection(conn);
            }

            return hocSinhList;
        }

        public void UpdatePhanLop(List<string> maHocSinhList, string maNamHoc, string maHocKy, string maKhoiLop, string maLop)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);

                string query = @"
                UPDATE phanlop
                SET MaNamHoc = @MaNamHoc, MaHocKy = @MaHocKy, MaKhoiLop = @MaKhoiLop, MaLop = @MaLop
                WHERE MaHocSinh = @MaHocSinh";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNamHoc", maNamHoc);
                    cmd.Parameters.AddWithValue("@MaHocKy", maHocKy);
                    cmd.Parameters.AddWithValue("@MaKhoiLop", maKhoiLop);
                    cmd.Parameters.AddWithValue("@MaLop", maLop);

                    foreach (string maHocSinh in maHocSinhList)
                    {
                        cmd.Parameters.AddWithValue("@MaHocSinh", maHocSinh);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@MaNamHoc", maNamHoc);
                        cmd.Parameters.AddWithValue("@MaHocKy", maHocKy);
                        cmd.Parameters.AddWithValue("@MaKhoiLop", maKhoiLop);
                        cmd.Parameters.AddWithValue("@MaLop", maLop);
                    }
                }

                DatabaseHelper.CloseConnection(conn);
            }
        }

        public List<KeyValuePair<string, string>> LayDanhSachNamHoc()
        {
            List<KeyValuePair<string, string>> namHocList = new List<KeyValuePair<string, string>>();
            string query = "SELECT MaNamHoc, TenNamHoc FROM namhoc";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string maNamHoc = reader["MaNamHoc"].ToString();
                    string tenNamHoc = reader["TenNamHoc"].ToString();
                    namHocList.Add(new KeyValuePair<string, string>(maNamHoc, tenNamHoc));
                }
            }

            return namHocList;
        }

        public List<KeyValuePair<string, string>> LayDanhSachHocKy()
        {
            List<KeyValuePair<string, string>> hocKyList = new List<KeyValuePair<string, string>>();
            string query = "SELECT MaHocKy, TenHocKy FROM hocky";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string maHocKy = reader["MaHocKy"].ToString();
                    string tenHocKy = reader["TenHocKy"].ToString();
                    hocKyList.Add(new KeyValuePair<string, string>(maHocKy, tenHocKy));
                }
            }

            return hocKyList;
        }

        public List<KeyValuePair<string, string>> LayDanhSachKhoiLop()
        {
            List<KeyValuePair<string, string>> khoiLopList = new List<KeyValuePair<string, string>>();
            string query = "SELECT MaKhoiLop, TenKhoiLop FROM khoilop";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string maKhoiLop = reader["MaKhoiLop"].ToString();
                    string tenKhoiLop = reader["TenKhoiLop"].ToString();
                    khoiLopList.Add(new KeyValuePair<string, string>(maKhoiLop, tenKhoiLop));
                }
            }

            return khoiLopList;
        }

        public List<KeyValuePair<string, string>> LayDanhSachLop()
        {
            List<KeyValuePair<string, string>> lopList = new List<KeyValuePair<string, string>>();
            string query = "SELECT MaLop, TenLop FROM lop";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string maLop = reader["MaLop"].ToString();
                    string tenLop = reader["TenLop"].ToString();
                    lopList.Add(new KeyValuePair<string, string>(maLop, tenLop));
                }
            }

            return lopList;
        }
    }
}
