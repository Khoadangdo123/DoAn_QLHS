using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_CSharp.DTO
{
    public class ThanhTichDTO
    {
        private string maThanhTich;
        private string tenThanhTich;
        private string maHocSinh;
        private string maNamHoc;
        private string maLop;
        private string maHocKy;
        private DateTime ngayLap;
        private string noiDung;
        private double diemThuong;
        public string MaThanhTich
        {
            get { return maThanhTich; }
            set { maThanhTich = value; }
        }
        public string TenThanhTich
        {
            get { return tenThanhTich; }
            set { tenThanhTich = value; }
        }
        public string MaHocSinh
        {
            get { return maHocSinh; }
            set { maHocSinh = value; }
        }
        public string MaNamHoc
        {
            get { return maNamHoc; }
            set { maNamHoc = value; }
        }
        public string MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }
        public string MaHocKy
        {
            get { return maHocKy; }
            set { maHocKy = value; }
        }
        public DateTime NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }
        public string NoiDung
        {
            get { return noiDung; }
            set { noiDung = value; }
        }
        public double DiemThuong
        {
            get { return diemThuong; }
            set { diemThuong = value; }
        }

        public ThanhTichDTO() { }

        public ThanhTichDTO(string maThanhTich,string tenThanhTich ,string maHocSinh, string maNamHoc, string maLop, string maHocKy, DateTime ngayLap, string noiDung, double diemThuong)
        {
            this.MaThanhTich = maThanhTich;
            this.TenThanhTich = tenThanhTich;
            this.MaHocSinh = maHocSinh;
            this.MaNamHoc = maNamHoc;
            this.MaLop = maLop;
            this.MaHocKy = maHocKy;
            this.NgayLap = ngayLap;
            this.NoiDung = noiDung;
            this.DiemThuong = diemThuong;
        }
    }

}
