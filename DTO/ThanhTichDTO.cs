using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_CSharp.DTO
{
    public class ThanhTichDTO
    {
        public int STT { get; set; }
        public string MaHocSinh { get; set; }
        public string MaNamHoc { get; set; }
        public string MaLop { get; set; }
        public string MaHocKy { get; set; }
        public DateTime NgayLap { get; set; }
        public string NoiDung { get; set; }
        public double DiemThuong { get; set; }

        public ThanhTichDTO() { }

        public ThanhTichDTO(int stt, string maHocSinh, string maNamHoc, string maLop, string maHocKy, DateTime ngayLap, string noiDung, double diemThuong)
        {
            STT = stt;
            MaHocSinh = maHocSinh;
            MaNamHoc = maNamHoc;
            MaLop = maLop;
            MaHocKy = maHocKy;
            NgayLap = ngayLap;
            NoiDung = noiDung;
            DiemThuong = diemThuong;
        }
    }

}
