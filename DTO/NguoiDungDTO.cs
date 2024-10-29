using System;

namespace GUI_CSharp.DTO
{
    internal class NguoiDungDTO
    {
        // Fields
        private string maNguoiDung;   // Corresponds to MaNguoiDung VARCHAR(6)
        private string maLoai;        // Corresponds to MaLoai VARCHAR(6)
        private string tenNguoiDung;  // Corresponds to TenNguoiDung NVARCHAR(30)
        private string tenDangNhap;   // Corresponds to TenDangNhap NVARCHAR(30)
        private string matKhau;       // Corresponds to MatKhau VARCHAR(64)

        // Getters and Setters
        public string MaNguoiDung
        {
            get { return maNguoiDung; }
            set { maNguoiDung = value; }
        }

        public string MaLoai
        {
            get { return maLoai; }
            set { maLoai = value; }
        }

        public string TenNguoiDung
        {
            get { return tenNguoiDung; }
            set { tenNguoiDung = value; }
        }

        public string TenDangNhap
        {
            get { return tenDangNhap; }
            set { tenDangNhap = value; }
        }

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        // Constructor
        public NguoiDungDTO() { }

        public NguoiDungDTO(string maNguoiDung, string maLoai, string tenNguoiDung, string tenDangNhap, string matKhau)
        {
            this.maNguoiDung = maNguoiDung;
            this.maLoai = maLoai;
            this.tenNguoiDung = tenNguoiDung;
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
        }
    }
}
