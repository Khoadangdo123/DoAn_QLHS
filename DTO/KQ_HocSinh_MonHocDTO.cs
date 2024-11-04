using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_CSharp.DTO
{
    public class KQ_HocSinh_MonHocDTO
    {
        public string MaHocSinh { get; set; }
        public string TenHocSinh { get; set; }
        public string MaLop { get; set; }
        public string MaNamHoc { get; set; }
        public string MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }
        public string MaHocKy { get; set; }
        public double DiemMiengTB { get; set; }
        public double Diem15PhutTB { get; set; }
        public double Diem45PhutTB { get; set; }
        public double DiemThi { get; set; }
        public double DiemTBHK { get; set; }

        public KQ_HocSinh_MonHocDTO() { }

        public KQ_HocSinh_MonHocDTO(string maHocSinh, string maLop, string maNamHoc, string maMonHoc, string maHocKy, double diemMiengTB, double diem15PhutTB, double diem45PhutTB, double diemThi, double diemTBHK)
        {
            MaHocSinh = maHocSinh;
            MaLop = maLop;
            MaNamHoc = maNamHoc;
            MaMonHoc = maMonHoc;
            MaHocKy = maHocKy;
            DiemMiengTB = diemMiengTB;
            Diem15PhutTB = diem15PhutTB;
            Diem45PhutTB = diem45PhutTB;
            DiemThi = diemThi;
            DiemTBHK = diemTBHK;
        }
    }

}
