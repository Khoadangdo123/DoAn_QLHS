using System;

namespace GUI_CSharp.DTO
{
    public class HanhKiemDTO
    {
        // Fields
        private string maHanhKiem;   // Corresponds to MaHanhKiem VARCHAR(6)
        private string tenHanhKiem;  // Corresponds to TenHanhKiem NVARCHAR(30)

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

        // Constructor
        public HanhKiemDTO() { }

        public HanhKiemDTO(string maHanhKiem, string tenHanhKiem)
        {
            this.maHanhKiem = maHanhKiem;
            this.tenHanhKiem = tenHanhKiem;
        }
    }
}
