using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_CSharp.DTO
{
    public class ThongKeHocSinhDTO
    {
        public int STT { get; set; }
        public string MaHS { get; set; }
        public string TenHS { get; set; }
        public DateTime NgaySinh { get; set; }
        public int GioiTinh { get; set; }
        public string Khoi { get; set; }
        public string Lop { get; set; }
        public string NamHoc { get; set; }

        public ThongKeHocSinhDTO()
        {
            // Default constructor
        }

        public ThongKeHocSinhDTO(int stt, string maHS, string tenHS, DateTime ngaySinh, int gioiTinh, string khoi, string lop, string namHoc)
        {
            STT = stt;
            MaHS = maHS;
            TenHS = tenHS;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            Khoi = khoi;
            Lop = lop;
            NamHoc = namHoc;
        }

        public string convertGioiTinh
        {
            get { return GioiTinh == 0 ? "Nam" : "Nữ"; }
        }

    }

}