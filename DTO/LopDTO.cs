using System;

namespace GUI_CSharp.DTO
{
    internal class LopDTO
    {
        // Fields
        private string maLop;
        private string tenLop;
        private string maKhoiLop;
        private string maNamHoc;
        private int siSo;
        private string maGiaoVien;

        // Getters and Setters
        public string MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }

        public string TenLop
        {
            get { return tenLop; }
            set { tenLop = value; }
        }

        public string MaKhoiLop
        {
            get { return maKhoiLop; }
            set { maKhoiLop = value; }
        }

        public string MaNamHoc
        {
            get { return maNamHoc; }
            set { maNamHoc = value; }
        }

        public int SiSo
        {
            get { return siSo; }
            set { siSo = value; }
        }

        public string MaGiaoVien
        {
            get { return maGiaoVien; }
            set { maGiaoVien = value; }
        }

        // Constructor
        public LopDTO() { }

        public LopDTO(string maLop, string tenLop, string maKhoiLop, string maNamHoc, int siSo, string maGiaoVien)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
            this.maKhoiLop = maKhoiLop;
            this.maNamHoc = maNamHoc;
            this.siSo = siSo;
            this.maGiaoVien = maGiaoVien;
        }
    }
}
