using System;

namespace GUI_CSharp.DTO
{
    internal class KetQuaDTO
    {
        // Fields
        private string maKetQua;   // Corresponds to MaKetQua VARCHAR(6)
        private string tenKetQua;  // Corresponds to TenKetQua NVARCHAR(30)

        // Getters and Setters
        public string MaKetQua
        {
            get { return maKetQua; }
            set { maKetQua = value; }
        }

        public string TenKetQua
        {
            get { return tenKetQua; }
            set { tenKetQua = value; }
        }

        // Constructor
        public KetQuaDTO() { }

        public KetQuaDTO(string maKetQua, string tenKetQua)
        {
            this.maKetQua = maKetQua;
            this.tenKetQua = tenKetQua;
        }
    }
}
