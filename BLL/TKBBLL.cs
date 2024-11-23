using DAL;
using GUI_CSharp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TKBBLL
    {
        List<ThoiKhoaBieuDTO> list;
        TKBDAL dal = new TKBDAL();

        public TKBBLL() 
        {
            list = new List<ThoiKhoaBieuDTO> ();
            list = dal.getAllTKB();
        }

        public List<ThoiKhoaBieuDTO> getTKB_GiaoVien(String magv,String maNamHoc,String MaHocKy)
        {
            List<ThoiKhoaBieuDTO> list = new List<ThoiKhoaBieuDTO>();

            foreach (ThoiKhoaBieuDTO temp in list)
            {
                if(temp.MaGiaoVien == magv && temp.MaNamHoc == maNamHoc && temp.MaHocKy == MaHocKy)
                {
                    list.Add(temp);
                }
            }

            return list;
        }

        public List<NamHocDTO> getNamHoc()
        { 
            return dal.getNamHoc(); 
        }

        public List<HocKyDTO> getHocKy_NamHoc(String namhoc)
        {

            return dal.getHocKy_NamHoc(namhoc); 
        }
    }
}
