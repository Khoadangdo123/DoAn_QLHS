using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_CSharp.DTO
{
    public class LoaiNguoiDungDTO
    {
        // Properties to match the SQL table columns
        public string MaLoai { get; set; }  // Corresponds to MaLoai VARCHAR(6)
        public string TenLoai { get; set; } // Corresponds to TenLoai NVARCHAR(30)

        // Constructor
        public LoaiNguoiDungDTO() { }

        public LoaiNguoiDungDTO(string maLoai, string tenLoai)
        {
            MaLoai = maLoai;
            TenLoai = tenLoai;
        }
    }
}