using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_CSharp.DTO
{
    public class KQ_HocSinh_CaNamDTO
    {
        public string MaHocSinh { get; set; }
        public string MaLop { get; set; }
        public string MaNamHoc { get; set; }
        public string MaHocLuc { get; set; }
        public string MaHanhKiem { get; set; }
        public string MaKetQua { get; set; }
        public double DiemTBHK1 { get; set; }
        public double DiemTBHK2 { get; set; }
        public double DiemTBCN { get; set; }

        public KQ_HocSinh_CaNamDTO() { }

        public KQ_HocSinh_CaNamDTO(string maHocSinh, string maLop, string maNamHoc, string maHocLuc, string maHanhKiem, string maKetQua, double diemTBHK1, double diemTBHK2, double diemTBCN)
        {
            MaHocSinh = maHocSinh;
            MaLop = maLop;
            MaNamHoc = maNamHoc;
            MaHocLuc = maHocLuc;
            MaHanhKiem = maHanhKiem;
            MaKetQua = maKetQua;
            DiemTBHK1 = diemTBHK1;
            DiemTBHK2 = diemTBHK2;
            DiemTBCN = diemTBCN;
        }
    }

}
