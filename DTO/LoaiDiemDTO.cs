using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_CSharp.DTO
{
    public class LoaiDiemDTO
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public int HeSo { get; set; }

        public LoaiDiemDTO() { }

        public LoaiDiemDTO(string maLoai, string tenLoai, int heSo)
        {
            MaLoai = maLoai;
            TenLoai = tenLoai;
            HeSo = heSo;
        }
    }

}
