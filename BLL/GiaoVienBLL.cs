using System.Collections.Generic;
using DAL;
using GUI_CSharp.DTO;

namespace BLL
{
    public class GiaoVienBLL  
    {
        private GiaoVienDAL giaoVienDAL = new GiaoVienDAL();

        public List<GiaoVienDTO> GetAllGiaoVien()
        {
            return giaoVienDAL.GetAllGiaoVien();
        }

        public bool InsertGiaoVien(GiaoVienDTO gv)
        {
            return giaoVienDAL.InsertGiaoVien(gv);
        }

        public bool UpdateGiaoVien(GiaoVienDTO gv)
        {
            return giaoVienDAL.UpdateGiaoVien(gv);
        }

        public bool DeleteGiaoVien(string maGiaoVien)
        {
            return giaoVienDAL.DeleteGiaoVien(maGiaoVien);
        }
        public string GenMaGV()
        {
            return giaoVienDAL.GenMaGV();
        }
        public GiaoVienDTO GetGiaoVienByMaGiaoVien(string maGiaoVien)
        {
            return giaoVienDAL.GetGiaoVienByMaGiaoVien(maGiaoVien);
        }
        public List<GiaoVienDTO> SearchGiaoVien(string searchTerm)
        {
            return giaoVienDAL.SearchGiaoVien(searchTerm);
        }

    }
}
