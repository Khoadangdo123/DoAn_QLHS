using System;

namespace GUI_CSharp.DTO
{
    internal class DanTocDTO
    {
        // Fields
        private string maDanToc;   // Corresponds to MaDanToc VARCHAR(6)
        private string tenDanToc;  // Corresponds to TenDanToc NVARCHAR(30)

        // Getters and Setters
        public string MaDanToc
        {
            get { return maDanToc; }
            set { maDanToc = value; }
        }

        public string TenDanToc
        {
            get { return tenDanToc; }
            set { tenDanToc = value; }
        }

        // Constructor
        public DanTocDTO() { }

        public DanTocDTO(string maDanToc, string tenDanToc)
        {
            this.maDanToc = maDanToc;
            this.tenDanToc = tenDanToc;
        }
    }
}
