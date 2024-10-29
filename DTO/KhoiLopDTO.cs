using System;

namespace GUI_CSharp.DTO
{
    internal class KhoiLopDTO
    {
        // Fields
        private string maKhoiLop;   // Corresponds to MaKhoiLop VARCHAR(6)
        private string tenKhoiLop;  // Corresponds to TenKhoiLop NVARCHAR(30)

        // Getters and Setters
        public string MaKhoiLop
        {
            get { return maKhoiLop; }
            set { maKhoiLop = value; }
        }

        public string TenKhoiLop
        {
            get { return tenKhoiLop; }
            set { tenKhoiLop = value; }
        }

        // Constructor
        public KhoiLopDTO() { }

        public KhoiLopDTO(string maKhoiLop, string tenKhoiLop)
        {
            this.maKhoiLop = maKhoiLop;
            this.tenKhoiLop = tenKhoiLop;
        }
    }
}
