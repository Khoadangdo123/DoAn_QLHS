using System;

namespace GUI_CSharp.DTO
{
    public class TonGiaoDTO
    {
        // Fields
        private string maTonGiao;   // Corresponds to MaTonGiao VARCHAR(6)
        private string tenTonGiao;  // Corresponds to TenTonGiao NVARCHAR(30)

        // Getters and Setters
        public string MaTonGiao
        {
            get { return maTonGiao; }
            set { maTonGiao = value; }
        }

        public string TenTonGiao
        {
            get { return tenTonGiao; }
            set { tenTonGiao = value; }
        }

        // Constructor
        public TonGiaoDTO() { }

        public TonGiaoDTO(string maTonGiao, string tenTonGiao)
        {
            this.maTonGiao = maTonGiao;
            this.tenTonGiao = tenTonGiao;
        }
    }
}
