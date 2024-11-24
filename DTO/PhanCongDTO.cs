using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_CSharp.DTO
{
    public class PhanCongDTO
    {
        public int STT { get; set; }
        public string MaNamHoc { get; set; }
        public string MaLop { get; set; }
        public string MaMonHoc { get; set; }
        public string MaGiaoVien { get; set; }
        public int SoTiet { get; set; }
        public DateTime NgayPhanCong { get; set; }

        public PhanCongDTO() { }

        public PhanCongDTO(int stt, string maNamHoc, string maLop, string maMonHoc, string maGiaoVien)
        {
            STT = stt;
            MaNamHoc = maNamHoc;
            MaLop = maLop;
            MaMonHoc = maMonHoc;
            MaGiaoVien = maGiaoVien;
        }
    }

}
