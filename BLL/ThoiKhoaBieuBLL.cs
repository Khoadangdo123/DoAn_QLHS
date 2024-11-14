using GUI_CSharp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    internal class ThoiKhoaBieuBLL
    {
        public List<ThoiKhoaBieuDTO> listTKB = new List<ThoiKhoaBieuDTO> ();
        private ThoiKhoaBieuDAL dal;

        public ThoiKhoaBieuBLL(List<ThoiKhoaBieuDTO> listTKB)
        {
            dal = new ThoiKhoaBieuDAL();
            listTKB = dal.GetAllTKB();
        }

        //check trùng thời kháo biểu
        public bool CheckDupTKB(ThoiKhoaBieuDTO obj)
        {
            foreach (ThoiKhoaBieuDTO temp in listTKB)
            {
                //lọc cùng năm học, học kỳ
                if(temp.MaNamHoc == obj.MaNamHoc && temp.MaHocKy == obj.MaHocKy)
                {
                    //lọc cùng thứ 
                    if(temp.Thu == obj.Thu)
                    {
                        //lọc trùng tiết
                        if(temp.TietBD <= obj.TietBD && ((temp.TietBD + temp.SoTiet) >= obj.TietBD))
                        {
                            //lọc trùng lớp
                            if(temp.MaLop == obj.MaLop)
                            {
                                return false;
                            }
                            //lọc giáo viên trống tiết
                            if(temp.MaGiaoVien == obj.MaGiaoVien)
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }

        //Thêm thời khóa biểu
        public bool addTKB(ThoiKhoaBieuDTO obj)
        {
            if (!CheckDupTKB(obj)) { return false; }
            listTKB.Add(obj);
            dal.InsertTKB(obj);
            return true;
        }

        //Sửa thời khóa biểu
        public bool updateTKB(ThoiKhoaBieuDTO new_obj, ThoiKhoaBieuDTO old_obj)
        {
            if (!CheckDupTKB(new_obj)) { return false; }
            listTKB[listTKB.IndexOf(old_obj)] = new_obj;
            dal.UpdateTKB(new_obj);
            return true;
        }

        //xóa thời khóa biểu
        public bool deleteTKB(ThoiKhoaBieuDTO obj)
        {
            listTKB.Remove(obj);
            dal.DeleteTKB(obj);
            return true;
        }

        //Lấy thời khóa biểu theo giáo viên
        public List<ThoiKhoaBieuDTO> getTKBbyMaGV(String maGV, String maNH, String maHK)
        {
            List<ThoiKhoaBieuDTO> list = new List<ThoiKhoaBieuDTO> ();

            foreach (ThoiKhoaBieuDTO temp in listTKB)
            {
                if (temp.MaGiaoVien == maGV)
                {
                    if(temp.MaNamHoc== maNH)
                    {
                        if(temp.MaHocKy == maHK)
                        {
                            list.Add(temp);
                        }
                    }
                }
            }

            return list;
        }
    }
}
