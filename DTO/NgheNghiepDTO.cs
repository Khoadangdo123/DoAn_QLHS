using System;

namespace GUI_CSharp.DTO
{
    public class NgheNghiepDTO
    {
        // Fields
        private string maNghe;
        private string tenNghe;

        // Getters and Setters
        public string MaNghe
        {
            get { return maNghe; }
            set { maNghe = value; }
        }

        public string TenNghe
        {
            get { return tenNghe; }
            set { tenNghe = value; }
        }

        // Constructor
        public NgheNghiepDTO() { }

        public NgheNghiepDTO(string maNghe, string tenNghe)
        {
            this.maNghe = maNghe;
            this.tenNghe = tenNghe;
        }
    }
}
