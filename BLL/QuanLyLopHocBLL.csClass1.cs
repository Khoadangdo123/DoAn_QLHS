using DAL;
using GUI_CSharp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class QuanLyLopHocBLL
    {


        public bool checkMaLopHocList(string malop)
        {
            QuanLyLopHocAccess qllh = new QuanLyLopHocAccess();

            return qllh.checkMaLop(malop);
        }

        public List<GiaoVienDTO> getGiaoVienList()
        {
            QuanLyLopHocAccess qllh = new QuanLyLopHocAccess();
            List<GiaoVienDTO> giaovienlist = qllh.getGiaoVien();


            return giaovienlist;
        }

        public List<HocKyDTO> getHocKyList()
        {
            QuanLyLopHocAccess qllh = new QuanLyLopHocAccess();
            List<HocKyDTO> hockylist = qllh.getHocKy();


            return hockylist;
        }

        public List<KhoiLopDTO> getKhoiLopList()
        {
            QuanLyLopHocAccess qllh = new QuanLyLopHocAccess();
            List<KhoiLopDTO> hockylist = qllh.getKhoiLop();


            return hockylist;
        }

        public List<NamHocDTO> getNamHocListData()
        {
            QuanLyLopHocAccess qllh = new QuanLyLopHocAccess();
            List<NamHocDTO> hockylist = qllh.getNamHoc();

            return hockylist;
        }


        public List<string> getDataListLopHoc()
        {
            QuanLyLopHocAccess qllh = new QuanLyLopHocAccess();
            List<LopDTO> lopList = qllh.ReadQuanLyLopHocData();
            List<string> dataListSummary = new List<string>();
            foreach (var lop in lopList)
            {
                string summary = $"{lop.MaLop}, {lop.TenLop}, {lop.LopKhoiLopDTO.TenKhoiLop} ,{lop.SiSo.ToString()}, {lop.LopNamHocDTO.TenNamHoc}, {lop.LopHocKyDTO.TenHocKy}, {lop.LopGiaoVienDTO.HoTen}";
                dataListSummary.Add(summary);
            }

            return dataListSummary;
        }


        public void deleteListLopHoc(string malop)
        {
            QuanLyLopHocAccess qllh = new QuanLyLopHocAccess();
            qllh.DeleteLop(malop);
        }

        public void insertListLopHoc(string malop, string tenlop, string makhoilop, string manamhoc, int siso, string magiaovien, string mahocky)
        {
            QuanLyLopHocAccess qllh = new QuanLyLopHocAccess();
            qllh.InsertLop(malop, tenlop, makhoilop, manamhoc, siso, magiaovien, mahocky);
        }

        public void updateListLopHoc(string malop, string tenlop, string makhoilop, string manamhoc, int siso, string magiaovien, string mahocky)
        {
            QuanLyLopHocAccess qllh = new QuanLyLopHocAccess();
            qllh.UpdateLop(malop, tenlop, makhoilop, manamhoc, siso, magiaovien, mahocky);
        }
    }
}
