using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class ThongKeKQLopDAL
    {
        public List<ThongKeKQLopDTO> GetThongKeKQ_Lop()
        {
            List<ThongKeKQLopDTO> thongKeKQList = new List<ThongKeKQLopDTO>();
            string query = @"
                    SELECT 
                        ROW_NUMBER() OVER (ORDER BY l.TenLop) AS STT,
                        l.TenLop AS Lop,
                        kl.TenKhoiLop AS Khoi,
                        nh.TenNamHoc AS NamHoc,
                        SUM(CASE WHEN kq.MaKetQua = 'KQ0001' THEN 1 ELSE 0 END) AS LenLop,
                        SUM(CASE WHEN kq.MaKetQua = 'KQ0002' THEN 1 ELSE 0 END) AS ThiLai,
                        SUM(CASE WHEN kq.MaKetQua = 'KQ0003' THEN 1 ELSE 0 END) AS RenLuyenHe,
                        SUM(CASE WHEN kq.MaKetQua = 'KQ0004' THEN 1 ELSE 0 END) AS OLai
                    FROM 
                        lop l
                    JOIN 
                        khoilop kl ON l.MaKhoiLop = kl.MaKhoiLop
                    JOIN 
                        phanlop pl ON l.MaLop = pl.MaLop
                    JOIN 
                        namhoc nh ON pl.MaNamHoc = nh.MaNamHoc
                    JOIN 
                        kq_hocsinh_canam kqhs ON pl.MaHocSinh = kqhs.MaHocSinh
                    JOIN 
                        ketqua kq ON kqhs.MaKetQua = kq.MaKetQua
                    GROUP BY 
                        l.TenLop, kl.TenKhoiLop, nh.TenNamHoc";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ThongKeKQLopDTO thongKeKQ = new ThongKeKQLopDTO
                        {
                            STT = reader.GetInt32(0),
                            Lop = reader.GetString(1),
                            Khoi = reader.GetString(2),
                            NamHoc = reader.GetString(3),
                            LenLop = reader.GetInt32(4),
                            ThiLai = reader.GetInt32(5),
                            RenLuyenHe = reader.GetInt32(6),
                            OLai = reader.GetInt32(7)
                        };

                        thongKeKQList.Add(thongKeKQ);
                    }
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return thongKeKQList;
        }

        public List<ThongKeKQLopDTO> FilterTKKQ_Lop(string lop, string namHoc)
        {
            List<ThongKeKQLopDTO> filteredList = new List<ThongKeKQLopDTO>();
            string query = @"
                    SELECT 
                        ROW_NUMBER() OVER (ORDER BY l.TenLop) AS STT,
                        l.TenLop AS Lop,
                        kl.TenKhoiLop AS Khoi,
                        nh.TenNamHoc AS NamHoc,
                        SUM(CASE WHEN kq.MaKetQua = 'KQ0001' THEN 1 ELSE 0 END) AS LenLop,
                        SUM(CASE WHEN kq.MaKetQua = 'KQ0002' THEN 1 ELSE 0 END) AS ThiLai,
                        SUM(CASE WHEN kq.MaKetQua = 'KQ0003' THEN 1 ELSE 0 END) AS RenLuyenHe,
                        SUM(CASE WHEN kq.MaKetQua = 'KQ0004' THEN 1 ELSE 0 END) AS OLai
                    FROM 
                        lop l
                    JOIN 
                        khoilop kl ON l.MaKhoiLop = kl.MaKhoiLop
                    JOIN 
                        phanlop pl ON l.MaLop = pl.MaLop
                    JOIN 
                        namhoc nh ON pl.MaNamHoc = nh.MaNamHoc
                    JOIN 
                        kq_hocsinh_canam kqhs ON pl.MaHocSinh = kqhs.MaHocSinh
                    JOIN 
                        ketqua kq ON kqhs.MaKetQua = kq.MaKetQua
                    WHERE
                        l.TenLop = @Lop AND nh.TenNamHoc = @NamHoc
                    GROUP BY 
                        l.TenLop, kl.TenKhoiLop, nh.TenNamHoc";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                DatabaseHelper.OpenConnection(conn);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Lop", lop);
                cmd.Parameters.AddWithValue("@NamHoc", namHoc);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ThongKeKQLopDTO thongKeKQ = new ThongKeKQLopDTO
                        {
                            STT = reader.GetInt32(0),
                            Lop = reader.GetString(1),
                            Khoi = reader.GetString(2),
                            NamHoc = reader.GetString(3),
                            LenLop = reader.GetInt32(4),
                            ThiLai = reader.GetInt32(5),
                            RenLuyenHe = reader.GetInt32(6),
                            OLai = reader.GetInt32(7)
                        };

                        filteredList.Add(thongKeKQ);
                    }
                }
                DatabaseHelper.CloseConnection(conn);
            }
            return filteredList;
        }

    }
}
