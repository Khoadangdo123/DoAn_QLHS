using System;

namespace GUI_CSharp.DTO
{
    internal class MonHocDTO
    {
        // Fields
        private string maMonHoc;   // Corresponds to MaMonHoc VARCHAR(6)
        private string tenMonHoc;  // Corresponds to TenMonHoc NVARCHAR(30)
        private int soTiet;        // Corresponds to SoTiet INT
        private int heSo;          // Corresponds to HeSo INT

        // Getters and Setters
        public string MaMonHoc
        {
            get { return maMonHoc; }
            set { maMonHoc = value; }
        }

        public string TenMonHoc
        {
            get { return tenMonHoc; }
            set { tenMonHoc = value; }
        }

        public int SoTiet
        {
            get { return soTiet; }
            set { soTiet = value; }
        }

        public int HeSo
        {
            get { return heSo; }
            set { heSo = value; }
        }

        // Constructor
        public MonHocDTO() { }

        public MonHocDTO(string maMonHoc, string tenMonHoc, int soTiet, int heSo)
        {
            this.maMonHoc = maMonHoc;
            this.tenMonHoc = tenMonHoc;
            this.soTiet = soTiet;
            this.heSo = heSo;
        }
    }
}
