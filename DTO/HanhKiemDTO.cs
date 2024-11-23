using System;

namespace GUI_CSharp.DTO
{
    public class HanhKiemDTO
    {
        // Fields
        private string maHanhKiem;   // Corresponds to MaHanhKiem VARCHAR(6)
        private string tenHanhKiem;  // Corresponds to TenHanhKiem NVARCHAR(30)
        private double diemCanTren;  // Corresponds to DiemCanTren DOUBLE
        private double diemCanDuoi;  // Corresponds to DiemCanDuoi DOUBLE

        // Getters and Setters
        public string MaHanhKiem
        {
            get { return maHanhKiem; }
            set { maHanhKiem = value; }
        }

        public string TenHanhKiem
        {
            get { return tenHanhKiem; }
            set { tenHanhKiem = value; }
        }

        public double DiemCanTren
        {
            get { return diemCanTren; }
            set { diemCanTren = value; }
        }

        public double DiemCanDuoi
        {
            get { return diemCanDuoi; }
            set { diemCanDuoi = value; }
        }
        // Constructor
        public HanhKiemDTO() { }

        public HanhKiemDTO(string maHanhKiem, string tenHanhKiem, double diemCanTren, double diemCanDuoi)
        {
            this.maHanhKiem = maHanhKiem;
            this.tenHanhKiem = tenHanhKiem;
            this.diemCanTren = diemCanTren;
            this.diemCanDuoi = diemCanDuoi;
            DiemCanTren = diemCanTren;
            DiemCanDuoi = diemCanDuoi;
        }
    }
}
