using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_CSharp.DTO
{
    public class ViPhamDTO
    {
        private string maViPham;
        private string tenViPham;
        private string maHocSinh;
        private string maNamHoc;
        private string maLop;
        private string maHocKy;
        private DateTime ngayLap;
        private string noiDung;
        private double diemTru;
  
        public string MaViPham 
        {
            get { return maViPham; } 
            set { maViPham = value; } 
        }
        public string TenViPham
        {
            get { return tenViPham; }
            set { tenViPham = value; }
        }
        public string MaHocSinh {
            get { return maHocSinh; }
            set { maHocSinh = value; }
        }
        public string MaNamHoc {
            get { return maNamHoc; }
            set { maNamHoc = value; }
        }
        public string MaLop {
            get { return maLop; }
            set { maLop = value; }
        }
        public string MaHocKy {
            get { return maHocKy; }
            set { maHocKy = value; }
        }
        public DateTime NgayLap {
            get { return ngayLap; }
            set { ngayLap = value; }
        }
        public string NoiDung {
            get { return noiDung; }
            set { noiDung = value; }
        }
        public double DiemTru {
            get { return diemTru; }
            set { diemTru = value; }
        }

        public ViPhamDTO() { }

        public ViPhamDTO(string maViPham,string tenViPham , string maHocSinh, string maNamHoc, string maLop, string maHocKy, DateTime ngayLap, string noiDung, double diemTru)
        {
            this.MaViPham = maViPham;
            this.TenViPham = tenViPham;
            this.MaHocSinh = maHocSinh;
            this.MaNamHoc = maNamHoc;
            this.MaLop = maLop;
            this.MaHocKy = maHocKy;
            this.NgayLap = ngayLap;
            this.NoiDung = noiDung;
            this.DiemTru = diemTru;
        }
    }

}
