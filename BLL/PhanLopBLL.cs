using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using GUI_CSharp.DTO;
namespace BLL
{
    public class PhanLopBLL
    {
        private PhanLopDAL phanLopDAL = new PhanLopDAL();

        public List<HocSinhDTO> LayDanhSachHocSinh(string maNamHoc, string maHocKy, string maKhoiLop, string maLop)
        {
            return phanLopDAL.GetHocSinhByPhanLop(maNamHoc, maHocKy, maKhoiLop, maLop);
        }

        public void CapNhatPhanLop(List<string> maHocSinhList, string maNamHoc, string maHocKy, string maKhoiLop, string maLop)
        {
            phanLopDAL.UpdatePhanLop(maHocSinhList, maNamHoc, maHocKy, maKhoiLop, maLop);
        }

        public List<KeyValuePair<string, string>> LayDanhSachNamHoc()
        {
            return phanLopDAL.LayDanhSachNamHoc();
        }

        public List<KeyValuePair<string, string>> LayDanhSachHocKy()
        {
            return phanLopDAL.LayDanhSachHocKy();
        }

        public List<KeyValuePair<string, string>> LayDanhSachKhoiLop()
        {
            return phanLopDAL.LayDanhSachKhoiLop();
        }

        public List<KeyValuePair<string, string>> LayDanhSachLop()
        {
            return phanLopDAL.LayDanhSachLop();
        }
    }
}
