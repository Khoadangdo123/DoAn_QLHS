using DAL;
using GUI_CSharp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DiemMonBLL
    {
        private DiemMonDAL monDAL = new DiemMonDAL();

        public KQ_HocSinh_MonHocDTO GetDiemMonByMa(string maHocSinh)
        {
            return monDAL.GetDiemMonByMa(maHocSinh);
        }

        public List<KQ_HocSinh_MonHocDTO> GetTableDiemMon()
        {
            return monDAL.GetTableDiemMon();
        }

        public bool AddDiemMon(KQ_HocSinh_MonHocDTO diemMon)
        {
            return monDAL.AddDiemMon(diemMon);
        }

        public bool UpdateDiemMon(KQ_HocSinh_MonHocDTO diemMon)
        {
            return monDAL.UpdateDiemMon(diemMon);
        }
        public List<KQ_HocSinh_MonHocDTO> SearchDiemMon(string searchTerm)
        {
            return monDAL.SearchDiemMon(searchTerm);
        }

        public List<KeyValuePair<string, string>> LayDanhSachMonHoc()
        {
            return monDAL.LayDanhSachMonHoc();
        }

        public List<KQ_HocSinh_MonHocDTO> GetDiemMonByConditions(string maMonHoc, string maLop, string maNamHoc, string maHocKy)
        {
            return monDAL.GetDiemMonByConditions(maMonHoc, maLop, maNamHoc, maHocKy);
        }

    }
}
