using DAL;
using GUI_CSharp.DTO;
using System.Collections.Generic;

namespace BLL
{

    public class HocSinhBLL
    {
        private HocSinhDAL hocSinhDAL = new HocSinhDAL();

        public string GenMaHS()
        {
            return hocSinhDAL.GenMaHS();
        }
        public List<HocSinhDTO> GetAllHocSinh()
        {
            return hocSinhDAL.GetAllHocSinh();
        }

        public bool AddHocSinh(HocSinhDTO hocSinh)
        {
            return hocSinhDAL.AddHocSinh(hocSinh);
        }

        public bool UpdateHocSinh(HocSinhDTO hocSinh)
        {
            return hocSinhDAL.UpdateHocSinh(hocSinh);
        }

        public bool DeleteHocSinh(string maHocSinh)
        {
            return hocSinhDAL.DeleteHocSinh(maHocSinh);
        }

        public List<HocSinhDTO> SearchHocSinh(string searchTerm)
        {
            return hocSinhDAL.SearchHocSinh(searchTerm);
        }

        public HocSinhDTO GetHocSinhByMa(string maHocSinh)
        {
            return hocSinhDAL.GetHocSinhByMa(maHocSinh);
        }

        

    }
}