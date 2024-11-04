using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GUI_CSharp.DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DiemMonDAL
    {
        public string GetTenHocSinh(string maHocSinh)
        {
            string tenHocSinh = "";
            string query = "SELECT HoTen FROM hocsinh WHERE MaHocSinh = @MaHocSinh";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHocSinh", maHocSinh);

                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    tenHocSinh = result.ToString();
                }

                DatabaseHelper.CloseConnection(conn);
            }
            return tenHocSinh;
        }

        public string GetTenMonHoc(string maMonHoc)
        {
            string tenMonHoc = "";
            string query = "SELECT TenMonHoc FROM monhoc WHERE MaMonHoc = @MaMonHoc";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);

                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    tenMonHoc = result.ToString();
                }

                DatabaseHelper.CloseConnection(conn);
            }
            return tenMonHoc;
        }

        public KQ_HocSinh_MonHocDTO GetDiemMonByMa(string maHocSinh)
        {
            KQ_HocSinh_MonHocDTO diemMon = null;

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                string query = "SELECT * FROM kq_hocsinh_monhoc WHERE MaHocSinh = @MaHocSinh";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MaHocSinh", maHocSinh);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    diemMon = new KQ_HocSinh_MonHocDTO
                    {
                        MaHocSinh = reader["MaHocSinh"].ToString(),
                        MaLop = reader["MaLop"].ToString(),
                        MaNamHoc = reader["MaNamHoc"].ToString(),
                        MaMonHoc = reader["MaMonHoc"].ToString(),
                        MaHocKy = reader["MaHocKy"].ToString(),
                        DiemMiengTB = Convert.ToDouble(reader["DiemMiengTB"]),
                        Diem15PhutTB = Convert.ToDouble(reader["Diem15PhutTB"]),
                        Diem45PhutTB = Convert.ToDouble(reader["Diem45PhutTB"]),
                        DiemThi = Convert.ToDouble(reader["DiemThi"]),
                        DiemTBHK = Convert.ToDouble(reader["DiemTBHK"]),
                    };
                    diemMon.TenMonHoc = GetTenMonHoc(diemMon.MaMonHoc);
                }
            }

            return diemMon;
        }

        public List<KQ_HocSinh_MonHocDTO> GetTableDiemMon()
        {
            List<KQ_HocSinh_MonHocDTO> listDiemMon = new List<KQ_HocSinh_MonHocDTO>();

            string query = "SELECT * FROM kq_hocsinh_monhoc";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);

                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        KQ_HocSinh_MonHocDTO kq_monHoc = new KQ_HocSinh_MonHocDTO
                        {
                            MaHocSinh = reader["MaHocSinh"].ToString(),
                            MaLop = reader["MaLop"].ToString(),
                            MaNamHoc = reader["MaNamHoc"].ToString(),
                            MaMonHoc = reader["MaMonHoc"].ToString(),
                            MaHocKy = reader["MaHocKy"].ToString(),
                            DiemMiengTB = Convert.ToDouble(reader["DiemMiengTB"]),
                            Diem15PhutTB = Convert.ToDouble(reader["Diem15PhutTB"]),
                            Diem45PhutTB = Convert.ToDouble(reader["Diem45PhutTB"]),
                            DiemThi = Convert.ToDouble(reader["DiemThi"]),
                            DiemTBHK = Convert.ToDouble(reader["DiemTBHK"]),
                        };

                        kq_monHoc.TenHocSinh = GetTenHocSinh(kq_monHoc.MaHocSinh);

                        listDiemMon.Add(kq_monHoc);
                    }
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return listDiemMon;
        }

        public bool AddDiemMon(KQ_HocSinh_MonHocDTO diemMon)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    DatabaseHelper.OpenConnection(conn);
                    string query = "INSERT INTO kq_hocsinh_monhoc (MaHocSinh, MaLop, MaNamHoc, MaMonHoc, MaHocKy, DiemMiengTB, Diem15PhutTB, Diem45PhutTB, DiemThi, DiemTBHK) " +
                   "VALUES (@MaHocSinh, @MaLop, @MaNamHoc, @MaMonHoc, @MaHocKy, @DiemMiengTB, @Diem15PhutTB, @Diem45PhutTB, @DiemThi, @DiemTBHK)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaHocSinh", diemMon.MaHocSinh);
                    cmd.Parameters.AddWithValue("@MaLop", diemMon.MaLop);
                    cmd.Parameters.AddWithValue("@MaNamHoc", diemMon.MaNamHoc);
                    cmd.Parameters.AddWithValue("@MaMonHoc", diemMon.MaMonHoc);
                    cmd.Parameters.AddWithValue("@MaHocKy", diemMon.MaHocKy);
                    cmd.Parameters.AddWithValue("@DiemMiengTB", diemMon.DiemMiengTB);
                    cmd.Parameters.AddWithValue("@Diem15PhutTB", diemMon.Diem15PhutTB);
                    cmd.Parameters.AddWithValue("@Diem45PhutTB", diemMon.Diem45PhutTB);
                    cmd.Parameters.AddWithValue("@DiemThi", diemMon.DiemThi);
                    cmd.Parameters.AddWithValue("@DiemTBHK", diemMon.DiemTBHK);


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

        public bool UpdateDiemMon(KQ_HocSinh_MonHocDTO diemMon)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    DatabaseHelper.OpenConnection(conn);
                    string query = "UPDATE kq_hocsinh_monhoc SET DiemMiengTB = @DiemMiengTB, Diem15PhutTB = @Diem15PhutTB, Diem45PhutTB = @Diem45PhutTB, DiemThi = @DiemThi, DiemTBHK = @DiemTBHK WHERE MaHocSinh = @MaHocSinh";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@MaHocSinh", diemMon.MaHocSinh);
                    cmd.Parameters.AddWithValue("@DiemMiengTB", diemMon.DiemMiengTB);
                    cmd.Parameters.AddWithValue("@Diem15PhutTB", diemMon.Diem15PhutTB);
                    cmd.Parameters.AddWithValue("@Diem45PhutTB", diemMon.Diem45PhutTB);
                    cmd.Parameters.AddWithValue("@DiemThi", diemMon.DiemThi);
                    cmd.Parameters.AddWithValue("@DiemTBHK", Math.Round((diemMon.DiemMiengTB + diemMon.Diem15PhutTB + (diemMon.Diem45PhutTB * 2) + (diemMon.DiemThi * 1)) / 5, 1));

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

        public List<KQ_HocSinh_MonHocDTO> GetDiemMonByConditions(string maMonHoc, string maLop, string maNamHoc, string maHocKy)
        {
            List<KQ_HocSinh_MonHocDTO> diemMonList = new List<KQ_HocSinh_MonHocDTO>();

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);

                string query = @"
                SELECT mh.MaHocSinh, hs.HoTen, mh.DiemMiengTB, mh.Diem15PhutTB, mh.Diem45PhutTB, mh.DiemThi, mh.DiemTBHK
                FROM kq_hocsinh_monhoc mh
                JOIN hocsinh hs ON mh.MaHocSinh = hs.MaHocSinh
                WHERE mh.MaNamHoc = @MaNamHoc AND mh.MaHocKy = @MaHocKy 
                      AND mh.MaMonHoc = @MaMonHoc AND mh.MaLop = @MaLop";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNamHoc", maNamHoc);
                    cmd.Parameters.AddWithValue("@MaHocKy", maHocKy);
                    cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                    cmd.Parameters.AddWithValue("@MaLop", maLop);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            KQ_HocSinh_MonHocDTO diemMon = new KQ_HocSinh_MonHocDTO
                            {
                                MaHocSinh = reader["MaHocSinh"].ToString(),
                                TenHocSinh = reader["HoTen"].ToString(),
                                DiemMiengTB = Convert.ToDouble(reader["DiemMiengTB"]),
                                Diem15PhutTB = Convert.ToDouble(reader["Diem15PhutTB"]),
                                Diem45PhutTB = Convert.ToDouble(reader["Diem45PhutTB"]),
                                DiemThi = Convert.ToDouble(reader["DiemThi"]),
                                DiemTBHK = Convert.ToDouble(reader["DiemTBHK"]),
                            };

                            diemMon.TenHocSinh = GetTenHocSinh(diemMon.MaHocSinh);
                            diemMonList.Add(diemMon);
                        }
                    }
                }

                DatabaseHelper.CloseConnection(conn);
            }

            return diemMonList;
        }

        public List<KQ_HocSinh_MonHocDTO> SearchDiemMon(string searchTerm)
        {
            List<KQ_HocSinh_MonHocDTO> results = new List<KQ_HocSinh_MonHocDTO>();

            // Truy vấn tìm kiếm cho mã học sinh
            string query = "SELECT * FROM kq_hocsinh_monhoc WHERE MaHocSinh LIKE @search";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        KQ_HocSinh_MonHocDTO diemMon = new KQ_HocSinh_MonHocDTO
                        {
                            MaHocSinh = reader["MaHocSinh"].ToString(),
                            MaLop = reader["MaLop"].ToString(),
                            MaNamHoc = reader["MaNamHoc"].ToString(),
                            MaMonHoc = reader["MaMonHoc"].ToString(),
                            MaHocKy = reader["MaHocKy"].ToString(),
                            DiemMiengTB = Convert.ToDouble(reader["DiemMiengTB"]),
                            Diem15PhutTB = Convert.ToDouble(reader["Diem15PhutTB"]),
                            Diem45PhutTB = Convert.ToDouble(reader["Diem45PhutTB"]),
                            DiemThi = Convert.ToDouble(reader["DiemThi"]),
                            DiemTBHK = Convert.ToDouble(reader["DiemTBHK"]),
                        };

                        diemMon.TenHocSinh = GetTenHocSinh(diemMon.MaHocSinh);

                        results.Add(diemMon);
                    }
                }
            }

            return results;
        }

        public List<KeyValuePair<string, string>> LayDanhSachMonHoc()
        {
            List<KeyValuePair<string, string>> monHocList = new List<KeyValuePair<string, string>>();
            string query = "SELECT MaMonHoc, TenMonHoc FROM monhoc";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string maMonHoc = reader["MaMonHoc"].ToString();
                    string tenMonHoc = reader["TenMonHoc"].ToString();
                    monHocList.Add(new KeyValuePair<string, string>(maMonHoc, tenMonHoc));
                }
            }

            return monHocList;
        }
    }
}
