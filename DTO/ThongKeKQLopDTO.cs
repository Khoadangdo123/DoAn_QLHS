using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKeKQLopDTO
    {
        public int STT { get; set; }
        public string Lop { get; set; }
        public string Khoi { get; set; }
        public string NamHoc { get; set; }
        public int LenLop { get; set; }
        public int ThiLai { get; set; }
        public int RenLuyenHe { get; set; }
        public int OLai { get; set; }

        public ThongKeKQLopDTO()
        {
            // Default constructor
        }

        public ThongKeKQLopDTO(int stt, string lop, string khoi, string namHoc, int lenLop, int thiLai, int renLuyenHe, int oLai)
        {
            STT = stt;
            Lop = lop;
            Khoi = khoi;
            NamHoc = namHoc;
            LenLop = lenLop;
            ThiLai = thiLai;
            RenLuyenHe = renLuyenHe;
            OLai = oLai;
        }
    }
}