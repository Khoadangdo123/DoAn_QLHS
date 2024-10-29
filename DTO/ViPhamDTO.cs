using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_CSharp.DTO
{
    public class ViPhamDTO
    {
        public int STT { get; set; }
        public string MaHocSinh { get; set; }
        public string MaNamHoc { get; set; }
        public string MaLop { get; set; }
        public string MaHocKy { get; set; }
        public DateTime NgayLap { get; set; }
        public string NoiDung { get; set; }
        public double DiemTru { get; set; }

        public ViPhamDTO() { }

        public ViPhamDTO(int stt, string maHocSinh, string maNamHoc, string maLop, string maHocKy, DateTime ngayLap, string noiDung, double diemTru)
        {
            STT = stt;
            MaHocSinh = maHocSinh;
            MaNamHoc = maNamHoc;
            MaLop = maLop;
            MaHocKy = maHocKy;
            NgayLap = ngayLap;
            NoiDung = noiDung;
            DiemTru = diemTru;
        }
    }

}
