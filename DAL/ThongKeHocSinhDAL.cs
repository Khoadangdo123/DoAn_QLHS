using GUI_CSharp.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.IO;


namespace DAL
{
    public class ThongKeHocSinhDAL
    {
        public List<ThongKeHocSinhDTO> GetThongKeHocSinhData()
        {
            List<ThongKeHocSinhDTO> thongKeHocSinhList = new List<ThongKeHocSinhDTO>();
            string query = @"
                    SELECT 
                        ROW_NUMBER() OVER (ORDER BY hs.MaHocSinh) AS STT,
                        hs.MaHocSinh AS MaHS,
                        hs.HoTen AS TenHS,
                        hs.NgaySinh AS NgaySinh,
                        hs.GioiTinh AS GioiTinh,
                        kl.TenKhoiLop AS Khoi,
                        l.TenLop AS Lop,
                        nh.TenNamHoc AS NamHoc
                    FROM 
                        hocsinh hs
                    JOIN 
                        phanlop pl ON hs.MaHocSinh = pl.MaHocSinh
                    JOIN 
                        lop l ON pl.MaLop = l.MaLop
                    JOIN 
                        namhoc nh ON pl.MaNamHoc = nh.MaNamHoc
                    JOIN 
                        khoilop kl ON l.MaKhoiLop = kl.MaKhoiLop";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ThongKeHocSinhDTO thongKeHocSinh = new ThongKeHocSinhDTO
                        {
                            STT = reader.GetInt32(0),
                            MaHS = reader.GetString(1),
                            TenHS = reader.GetString(2),
                            NgaySinh = reader.GetDateTime(3),
                            GioiTinh = Convert.ToInt32(reader["GioiTinh"]),
                            Khoi = reader.GetString(5),
                            Lop = reader.GetString(6),
                            NamHoc = reader.GetString(7)
                        };


                        thongKeHocSinhList.Add(thongKeHocSinh);
                    }
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return thongKeHocSinhList;
        }

        public List<ThongKeHocSinhDTO> SearchHocSinh(string keyword)
        {
            List<ThongKeHocSinhDTO> thongKeHocSinhList = new List<ThongKeHocSinhDTO>();
            string query = @"
                SELECT 
                    ROW_NUMBER() OVER (ORDER BY hs.MaHocSinh) AS STT,
                    hs.MaHocSinh AS MaHS,
                    hs.HoTen AS TenHS,
                    hs.NgaySinh AS NgaySinh,
                    hs.GioiTinh AS GioiTinh,
                    kl.TenKhoiLop AS Khoi,
                    l.TenLop AS Lop,
                    nh.TenNamHoc AS NamHoc
                FROM 
                    hocsinh hs
                JOIN 
                    phanlop pl ON hs.MaHocSinh = pl.MaHocSinh
                JOIN 
                    lop l ON pl.MaLop = l.MaLop
                JOIN
                    khoilop kl ON l.MaKhoiLop = kl.MaKhoiLop
                JOIN 
                    namhoc nh ON pl.MaNamHoc = nh.MaNamHoc
                WHERE 
                    hs.MaHocSinh LIKE @Keyword OR hs.HoTen LIKE @Keyword";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ThongKeHocSinhDTO thongKeHocSinh = new ThongKeHocSinhDTO
                        {
                            STT = reader.GetInt32(0),
                            MaHS = reader.GetString(1),
                            TenHS = reader.GetString(2),
                            NgaySinh = reader.GetDateTime(3),
                            GioiTinh = Convert.ToInt32(reader["GioiTinh"]),
                            Khoi = reader.GetString(5),
                            Lop = reader.GetString(6),
                            NamHoc = reader.GetString(7)
                        };

                        thongKeHocSinhList.Add(thongKeHocSinh);
                    }
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return thongKeHocSinhList;
        }



        public List<ThongKeHocSinhDTO> FilterHocSinh(string lop, string namhoc)
        {
            List<ThongKeHocSinhDTO> thongKeHocSinhList = new List<ThongKeHocSinhDTO>();
            string query = @"
                    SELECT 
                        ROW_NUMBER() OVER (ORDER BY hs.MaHocSinh) AS STT,
                        hs.MaHocSinh AS MaHS,
                        hs.HoTen AS TenHS,
                        hs.NgaySinh AS NgaySinh,
                        hs.GioiTinh AS GioiTinh,
                        kl.TenKhoiLop AS Khoi,
                        l.TenLop AS Lop,
                        nh.TenNamHoc AS NamHoc
                    FROM 
                        hocsinh hs
                    JOIN 
                        phanlop pl ON hs.MaHocSinh = pl.MaHocSinh
                    JOIN 
                        lop l ON pl.MaLop = l.MaLop
                    JOIN 
                        khoilop kl ON l.MaKhoiLop = kl.MaKhoiLop
                    JOIN 
                        namhoc nh ON pl.MaNamHoc = nh.MaNamHoc
                    WHERE 
                        (@Lop IS NULL OR l.TenLop = @Lop) AND 
                        (@Namhoc IS NULL OR nh.TenNamHoc = @Namhoc)";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Lop", string.IsNullOrEmpty(lop) ? (object)DBNull.Value : lop);
                cmd.Parameters.AddWithValue("@NamHoc", string.IsNullOrEmpty(namhoc) ? (object)DBNull.Value : namhoc);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ThongKeHocSinhDTO thongKeHocSinh = new ThongKeHocSinhDTO
                        {
                            STT = reader.GetInt32(0),
                            MaHS = reader.GetString(1),
                            TenHS = reader.GetString(2),
                            NgaySinh = reader.GetDateTime(3),
                            GioiTinh = Convert.ToInt32(reader["GioiTinh"]),
                            Khoi = reader.GetString(5),
                            Lop = reader.GetString(6),
                            NamHoc = reader.GetString(7)
                        };

                        thongKeHocSinhList.Add(thongKeHocSinh);
                    }
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return thongKeHocSinhList;
        }
    }


}