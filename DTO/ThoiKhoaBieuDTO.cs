using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_CSharp.DTO
{
    internal class ThoiKhoaBieuDTO
    {
        public int STT { get; set; }
        public string MaLop { get; set; }
        public string MaNamHoc { get; set; }
        public string MaMonHoc { get; set; }
        public string MaHocKy { get; set; }
        public string MaGiaoVien { get; set; }
        public int Thu { get; set; }
        public int TietBD { get; set; }
        public int SoTiet { get; set; }

        public ThoiKhoaBieuDTO() { }

        public ThoiKhoaBieuDTO(int stt, string maLop, string maNamHoc, string maMonHoc, string maHocKy, string maGiaoVien, int thu, int tietBD, int soTiet)
        {
            STT = stt;
            MaLop = maLop;
            MaNamHoc = maNamHoc;
            MaMonHoc = maMonHoc;
            MaHocKy = maHocKy;
            MaGiaoVien = maGiaoVien;
            Thu = thu;
            TietBD = tietBD;
            SoTiet = soTiet;
        }
    }

}
