using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguoiDTO
    {
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }

        // Constructor
        public NguoiDTO(string diaChi, string hoTen, string gioiTinh)
        {
            DiaChi = diaChi;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
        }
    }
}
