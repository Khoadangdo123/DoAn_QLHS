using DTO;
using System;

namespace GUI_CSharp.DTO
{
    public class HocSinhDTO : NguoiDTO
    {
        // Fields
        public string maHocSinh;
        public string hoTen;
        public string gioiTinh;
        public DateTime ngaySinh;
        public string diaChi;
        public string maDanToc;
        public string maTonGiao;
        public string hoTenCha;
        public string maNgheCha;
        public string hoTenMe;
        public string maNgheMe;
        public string email;

        // Getters and Setters
        public string MaHocSinh
        {
            get { return maHocSinh; }
            set { maHocSinh = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string MaDanToc
        {
            get { return maDanToc; }
            set { maDanToc = value; }
        }

        public string TenDanToc { get; set; }

        public string MaTonGiao
        {
            get { return maTonGiao; }
            set { maTonGiao = value; }
        }

        public string TenTonGiao { get; set; }

        public string HoTenCha
        {
            get { return hoTenCha; }
            set { hoTenCha = value; }
        }

        public string MaNgheCha
        {
            get { return maNgheCha; }
            set { maNgheCha = value; }
        }

        public string TenNgheCha { get; set; }

        public string HoTenMe
        {
            get { return hoTenMe; }
            set { hoTenMe = value; }
        }

        public string MaNgheMe
        {
            get { return maNgheMe; }
            set { maNgheMe = value; }
        }

        public string TenNgheMe { get; set; }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        // Constructor

        // Constructor mặc định
        public HocSinhDTO() : base("", "", "")
        {
            // Có thể khởi tạo giá trị mặc định cho các trường nếu cần
            this.maHocSinh = "";
            this.hoTen = "";
            this.gioiTinh = "";
            this.ngaySinh = DateTime.MinValue;
            this.diaChi = "";
            this.maDanToc = "";
            this.maTonGiao = "";
            this.hoTenCha = "";
            this.maNgheCha = "";
            this.hoTenMe = "";
            this.maNgheMe = "";
            this.email = "";
        }


        public HocSinhDTO(string maHocSinh, string hoTen, string gioiTinh, DateTime ngaySinh, string diaChi, string maDanToc, string maTonGiao, string hoTenCha, string maNgheCha, string hoTenMe, string maNgheMe, string email)
            : base(diaChi, hoTen, gioiTinh)
        {
            this.maHocSinh = maHocSinh;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.maDanToc = maDanToc;
            this.maTonGiao = maTonGiao;
            this.hoTenCha = hoTenCha;
            this.maNgheCha = maNgheCha;
            this.hoTenMe = hoTenMe;
            this.maNgheMe = maNgheMe;
            this.email = email;
        }

       /** public string convertGioiTinh
        {
            get { return GioiTinh == 0 ? "Nam" : "Nữ"; }
        }**/
    }
}
