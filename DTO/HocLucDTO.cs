using System;

namespace GUI_CSharp.DTO
{
    internal class HocLucDTO
    {
        // Fields
        private string maHocLuc;       // Corresponds to MaHocLuc VARCHAR(6)
        private string tenHocLuc;      // Corresponds to TenHocLuc NVARCHAR(30)
        private double diemCanDuoi;    // Corresponds to DiemCanDuoi DOUBLE
        private double diemCanTren;    // Corresponds to DiemCanTren DOUBLE
        private double diemKhongChe;   // Corresponds to DiemKhongChe DOUBLE

        // Getters and Setters
        public string MaHocLuc
        {
            get { return maHocLuc; }
            set { maHocLuc = value; }
        }

        public string TenHocLuc
        {
            get { return tenHocLuc; }
            set { tenHocLuc = value; }
        }

        public double DiemCanDuoi
        {
            get { return diemCanDuoi; }
            set { diemCanDuoi = value; }
        }

        public double DiemCanTren
        {
            get { return diemCanTren; }
            set { diemCanTren = value; }
        }

        public double DiemKhongChe
        {
            get { return diemKhongChe; }
            set { diemKhongChe = value; }
        }

        // Constructor
        public HocLucDTO() { }

        public HocLucDTO(string maHocLuc, string tenHocLuc, double diemCanDuoi, double diemCanTren, double diemKhongChe)
        {
            this.maHocLuc = maHocLuc;
            this.tenHocLuc = tenHocLuc;
            this.diemCanDuoi = diemCanDuoi;
            this.diemCanTren = diemCanTren;
            this.diemKhongChe = diemKhongChe;
        }
    }
}
