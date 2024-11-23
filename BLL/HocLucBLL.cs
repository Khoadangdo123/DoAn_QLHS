using DAL;
using GUI_CSharp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class HocLucBLL
    {
        private HocLucDAL hocLucDAL = new HocLucDAL();

        public string GenMaHL()
        {
            return hocLucDAL.GenMaHL();
        }
        public List<HocLucDTO> GetAllHocLuc()
        {
            return hocLucDAL.GetAllHocLuc();
        }

        public bool AddHocLuc(HocLucDTO hocLuc)
        {
            return hocLucDAL.AddHocLuc(hocLuc);
        }

        public bool UpdateHocLuc(HocLucDTO hocLuc)
        {
            return hocLucDAL.UpdateHocLuc(hocLuc);
        }

        public bool DeleteHocLuc(string maHocLuc)
        {
            return hocLucDAL.DeleteHocLuc(maHocLuc);
        }
        public List<HocLucDTO> SearchHocLuc(string searchTerm)
        {
            return hocLucDAL.SearchHocLuc(searchTerm);
        }
        public HocLucDTO GetHocLucByMa(string maHocLuc)
        {
            return hocLucDAL.GetHocLucByMa(maHocLuc);
        }
    }
}
