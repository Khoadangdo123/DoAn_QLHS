using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKeKQDTO
    {
        public int STT { get; set; }
        public string MaHocSinh { get; set; }
        public string HoTen { get; set; }
        public string Lop { get; set; }
        public string NamHoc { get; set; }
        public string KetQua { get; set; }

        public ThongKeKQDTO()
        {
            // Default constructor
        }

        public ThongKeKQDTO(int stt, string maHocSinh, string hoTen, string lop, string namHoc, string ketQua)
        {
            STT = stt;
            MaHocSinh = maHocSinh;
            HoTen = hoTen;
            Lop = lop;
            NamHoc = namHoc;
            KetQua = ketQua;
        }
    }
}
