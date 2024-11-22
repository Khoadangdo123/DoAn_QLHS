using DTO;
using System;

namespace GUI_CSharp.DTO
{
    public class GiaoVienDTO : NguoiDTO  // Change 'internal' to 'public'
    {
        // Fields
        private string maGiaoVien;
        private string tenGiaoVien;
        private string diaChi;
        private string dienThoai;
        private string maMonHoc;

        // Getters and Setters
        public string MaGiaoVien
        {
            get { return maGiaoVien; }
            set { maGiaoVien = value; }
        }

        public string TenGiaoVien
        {
            get { return tenGiaoVien; }
            set { tenGiaoVien = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
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

        public GiaoVienDTO()
            : base("","", "")
        {
            this.maGiaoVien = "";
            this.tenGiaoVien = "";
            this.diaChi = "";
            this.dienThoai = "";
            this.maMonHoc = "";
        }

        public GiaoVienDTO(string maGiaoVien, string hoTen, string diaChi, string gioiTinh, string dienThoai, string maMonHoc)
            : base(diaChi, hoTen, gioiTinh)
        {
            this.maGiaoVien = maGiaoVien;
            this.tenGiaoVien = tenGiaoVien;
            this.diaChi = diaChi;
            this.dienThoai = dienThoai;
            this.maMonHoc = maMonHoc;
        }
    }
}
