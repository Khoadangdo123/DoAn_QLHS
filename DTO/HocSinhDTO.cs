using System;
using DTO;

namespace GUI_CSharp.DTO
{
    public class HocSinhDTO : NguoiDTO
    {
        // Fields
        private string maHocSinh;
        private DateTime ngaySinh;
        private string maDanToc;
        private string maTonGiao;
        private string hoTenCha;
        private string maNgheCha;
        private string hoTenMe;
        private string maNgheMe;
        private string email;

        // Getters and Setters
        public string MaHocSinh
        {
            get { return maHocSinh; }
            set { maHocSinh = value; }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public string MaDanToc
        {
            get { return maDanToc; }
            set { maDanToc = value; }
        }

        public string MaTonGiao
        {
            get { return maTonGiao; }
            set { maTonGiao = value; }
        }

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

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        // Constructor
        public HocSinhDTO(string maHocSinh, string hoTen, string gioiTinh, DateTime ngaySinh, string diaChi, string maDanToc, string maTonGiao, string hoTenCha, string maNgheCha, string hoTenMe, string maNgheMe, string email)
            : base(diaChi, hoTen, gioiTinh)
        {
            this.maHocSinh = maHocSinh;
            this.ngaySinh = ngaySinh;
            this.maDanToc = maDanToc;
            this.maTonGiao = maTonGiao;
            this.hoTenCha = hoTenCha;
            this.maNgheCha = maNgheCha;
            this.hoTenMe = hoTenMe;
            this.maNgheMe = maNgheMe;
            this.email = email;
        }
    }
}
