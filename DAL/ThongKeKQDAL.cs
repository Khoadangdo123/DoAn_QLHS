using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;


namespace DAL
{
    public class ThongKeKQDAL
    {
        public List<ThongKeKQDTO> GetThongKeKQ_HS()
        {
            List<ThongKeKQDTO> thongKeKQList = new List<ThongKeKQDTO>();
            string query = @"
                        SELECT 
                            ROW_NUMBER() OVER (ORDER BY hs.MaHocSinh) AS STT,
                            hs.MaHocSinh AS MaHocSinh,
                            hs.HoTen AS HoTen,
                            l.TenLop AS Lop,
                            nh.TenNamHoc AS NamHoc,
                            kq.TenKetQua AS KetQua
                        FROM 
                            hocsinh hs
                        JOIN 
                            phanlop pl ON hs.MaHocSinh = pl.MaHocSinh
                        JOIN 
                            lop l ON pl.MaLop = l.MaLop
                        JOIN 
                            namhoc nh ON pl.MaNamHoc = nh.MaNamHoc
                        JOIN 
                            kq_hocsinh_canam kqhs ON hs.MaHocSinh = kqhs.MaHocSinh
                        JOIN 
                            ketqua kq ON kqhs.MaKetQua = kq.MaKetQua";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ThongKeKQDTO thongKeKQ = new ThongKeKQDTO
                        {
                            STT = reader.GetInt32(0),
                            MaHocSinh = reader.GetString(1),
                            HoTen = reader.GetString(2),
                            Lop = reader.GetString(3),
                            NamHoc = reader.GetString(4),
                            KetQua = reader.GetString(5)
                        };

                        thongKeKQList.Add(thongKeKQ);
                    }
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return thongKeKQList;
        }

        public List<ThongKeKQDTO> TimKiemThongKeKQ_HS(string keyword)
        {
            List<ThongKeKQDTO> thongKeKQList = new List<ThongKeKQDTO>();
            string query = @"
                        SELECT 
                            ROW_NUMBER() OVER (ORDER BY hs.MaHocSinh) AS STT,
                            hs.MaHocSinh AS MaHocSinh,
                            hs.HoTen AS HoTen,
                            l.TenLop AS Lop,
                            nh.TenNamHoc AS NamHoc,
                            kq.TenKetQua AS KetQua
                        FROM 
                            hocsinh hs
                        JOIN 
                            phanlop pl ON hs.MaHocSinh = pl.MaHocSinh
                        JOIN 
                            lop l ON pl.MaLop = l.MaLop
                        JOIN 
                            namhoc nh ON pl.MaNamHoc = nh.MaNamHoc
                        JOIN 
                            kq_hocsinh_canam kqhs ON hs.MaHocSinh = kqhs.MaHocSinh
                        JOIN
                            ketqua kq ON kqhs.MaKetQua = kq.MaKetQua
                        WHERE
                            hs.MaHocSinh LIKE @Keyword OR
                            hs.HoTen LIKE @Keyword";
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ThongKeKQDTO thongKeKQ = new ThongKeKQDTO
                        {
                            STT = reader.GetInt32(0),
                            MaHocSinh = reader.GetString(1),
                            HoTen = reader.GetString(2),
                            Lop = reader.GetString(3),
                            NamHoc = reader.GetString(4),
                            KetQua = reader.GetString(5)
                        };

                        thongKeKQList.Add(thongKeKQ);
                    }
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return thongKeKQList;
        }

        public List<ThongKeKQDTO> FilterTKKQ_HS(string lop, string namhoc)
        {
            List<ThongKeKQDTO> thongKeKQList = new List<ThongKeKQDTO>();
            string query = @"
                        SELECT 
                            ROW_NUMBER() OVER (ORDER BY hs.MaHocSinh) AS STT,
                            hs.MaHocSinh AS MaHocSinh,
                            hs.HoTen AS HoTen,
                            l.TenLop AS Lop,
                            nh.TenNamHoc AS NamHoc,
                            kq.TenKetQua AS KetQua
                        FROM 
                            hocsinh hs
                        JOIN 
                            phanlop pl ON hs.MaHocSinh = pl.MaHocSinh
                        JOIN 
                            lop l ON pl.MaLop = l.MaLop
                        JOIN
                            namhoc nh ON pl.MaNamHoc = nh.MaNamHoc
                        JOIN 
                            kq_hocsinh_canam kqhs ON hs.MaHocSinh = kqhs.MaHocSinh
                        JOIN
                            ketqua kq ON kqhs.MaKetQua = kq.MaKetQua
                        WHERE 
                        (@Lop IS NULL OR l.TenLop = @Lop) AND 
                        (@Namhoc IS NULL OR nh.TenNamHoc = @Namhoc)";
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Lop", lop);
                cmd.Parameters.AddWithValue("@NamHoc", namhoc);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ThongKeKQDTO thongKeKQ = new ThongKeKQDTO
                        {
                            STT = reader.GetInt32(0),
                            MaHocSinh = reader.GetString(1),
                            HoTen = reader.GetString(2),
                            Lop = reader.GetString(3),
                            NamHoc = reader.GetString(4),
                            KetQua = reader.GetString(5)
                        };

                        thongKeKQList.Add(thongKeKQ);
                    }
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return thongKeKQList;
        }
    }

}
