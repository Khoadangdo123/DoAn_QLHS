using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_CSharp.DTO
{
    public class DiemDTO
    {
        public int STT { get; set; }
        public string MaHocSinh { get; set; }
        public string MaMonHoc { get; set; }
        public string MaHocKy { get; set; }
        public string MaNamHoc { get; set; }
        public string MaLop { get; set; }
        public string MaLoai { get; set; }
        public double Diem { get; set; }

        public DiemDTO() { }

        public DiemDTO(int stt, string maHocSinh, string maMonHoc, string maHocKy, string maNamHoc, string maLop, string maLoai, double diem)
        {
            STT = stt;
            MaHocSinh = maHocSinh;
            MaMonHoc = maMonHoc;
            MaHocKy = maHocKy;
            MaNamHoc = maNamHoc;
            MaLop = maLop;
            MaLoai = maLoai;
            Diem = diem;
        }
    }

}
