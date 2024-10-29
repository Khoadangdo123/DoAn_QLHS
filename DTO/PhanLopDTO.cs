using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_CSharp.DTO
{
    internal class PhanLopDTO
    {
        public string MaNamHoc { get; set; }
        public string MaKhoiLop { get; set; }
        public string MaLop { get; set; }
        public string MaHocSinh { get; set; }

        public PhanLopDTO() { }

        public PhanLopDTO(string maNamHoc, string maKhoiLop, string maLop, string maHocSinh)
        {
            MaNamHoc = maNamHoc;
            MaKhoiLop = maKhoiLop;
            MaLop = maLop;
            MaHocSinh = maHocSinh;
        }
    }

}
