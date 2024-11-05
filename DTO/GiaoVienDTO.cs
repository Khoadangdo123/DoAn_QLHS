using System;
using DTO;

namespace GUI_CSharp.DTO
{
    public class GiaoVienDTO : NguoiDTO
    {
        // Fields
        public string maGiaoVien;
        public string dienThoai;
        public string maMonHoc;

        // Getters and Setters
        public string MaGiaoVien
        {
            get { return maGiaoVien; }
            set { maGiaoVien = value; }
        }

        public string DienThoai
        {
            get { return dienThoai; }
            set { dienThoai = value; }
        }

        public string MaMonHoc
        {
            get { return maMonHoc; }
            set { maMonHoc = value; }
        }

        // Constructor
        public GiaoVienDTO(string maGiaoVien, string hoTen, string diaChi, string gioiTinh, string dienThoai, string maMonHoc)
            : base(diaChi, hoTen, gioiTinh)
        {
            this.maGiaoVien = maGiaoVien;
            this.dienThoai = dienThoai;
            this.maMonHoc = maMonHoc;
        }
    }
}
