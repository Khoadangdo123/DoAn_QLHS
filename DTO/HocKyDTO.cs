using System;

namespace GUI_CSharp.DTO
{
    public class HocKyDTO
    {
        // Fields
        private string maHocKy;   // Corresponds to MaHocKy VARCHAR(3)
        private string tenHocKy;  // Corresponds to TenHocKy NVARCHAR(30)
        private int heSo;         // Corresponds to HeSo INT

        // Getters and Setters
        public string MaHocKy
        {
            get { return maHocKy; }
            set { maHocKy = value; }
        }

        public string TenHocKy
        {
            get { return tenHocKy; }
            set { tenHocKy = value; }
        }

        public int HeSo
        {
            get { return heSo; }
            set { heSo = value; }
        }

        // Constructor
        public HocKyDTO() { }

        public HocKyDTO(string maHocKy, string tenHocKy, int heSo)
        {
            this.maHocKy = maHocKy;
            this.tenHocKy = tenHocKy;
            this.heSo = heSo;
        }
    }
}
