using System;

namespace GUI_CSharp.DTO
{
    public class LopDTO
    {
        public NamHocDTO LopNamHocDTO { get; set; }
        public HocKyDTO LopHocKyDTO { get; set; }
        public GiaoVienDTO LopGiaoVienDTO { get; set; }
        public KhoiLopDTO LopKhoiLopDTO { get; set; }
        // Fields
        private string maLop;
        private string tenLop;
        private string maKhoiLop;
        private string maNamHoc;
        private int siSo;
        private string maGiaoVien;
        private string maHocKy;

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

        public string MaHocKy
        {
            get { return maHocKy; }
            set { maHocKy = value; }
        }

        // Constructor
        public LopDTO() { }

        public LopDTO(
             string maHocKyHK, string tenHocKyHK, int HeSoHK,

             string maGiaoVienGV, string tenGiaoVienGV, string diaChiGV,
             string gioiTinhGV, string dienThoaiGV, string maMonHocGV,

             string makhoilopKL, string tenkhoilopKL,

             string maNamHocNH, string tenNamHocNH,
             string maLop, string tenLop, string maKhoiLop,
             string maNamHoc, int siSo, string maGiaoVien,
             string maHocKy
             )
        {
            LopHocKyDTO = new HocKyDTO(maHocKyHK, tenHocKyHK, HeSoHK);
            LopGiaoVienDTO = new GiaoVienDTO(maGiaoVienGV, tenGiaoVienGV, diaChiGV, gioiTinhGV, dienThoaiGV, maMonHocGV);
            LopNamHocDTO = new NamHocDTO(maNamHocNH, tenNamHocNH);
            LopKhoiLopDTO = new KhoiLopDTO(makhoilopKL, tenkhoilopKL);
            this.maLop = maLop;
            this.tenLop = tenLop;
            this.maKhoiLop = maKhoiLop;
            this.maNamHoc = maNamHoc;
            this.siSo = siSo;
            this.maGiaoVien = maGiaoVien;
            this.maHocKy = maHocKy;
        }

        // Dùng để thêm sửa xóa
        public LopDTO(
            string maLop, string tenLop, string maKhoiLop,
            string maNamHoc, int siSo, string maGiaoVien,
            string maHocKy
            )
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
            this.maKhoiLop = maKhoiLop;
            this.maNamHoc = maNamHoc;
            this.siSo = siSo;
            this.maGiaoVien = maGiaoVien;
            this.maHocKy = maHocKy;
        }
    }
}
