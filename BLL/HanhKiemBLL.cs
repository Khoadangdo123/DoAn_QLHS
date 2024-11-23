using DAL;
using GUI_CSharp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HanhKiemBLL
    {
        public string GenMaHK()
        {
            return hanhKiemDAL.GenMaHK();
        }
        private HanhKiemDAL hanhKiemDAL = new HanhKiemDAL();

        public List<HanhKiemDTO> GetAllHanhKiem()
        {
            return hanhKiemDAL.GetAllHanhKiem();
        }

        public bool AddHanhKiem(HanhKiemDTO hanhKiem)
        {
            return hanhKiemDAL.AddHanhKiem(hanhKiem);
        }

        public bool UpdateHanhKiem(HanhKiemDTO hanhKiem)
        {
            return hanhKiemDAL.UpdateHanhKiem(hanhKiem);
        }

        public bool DeleteHanhKiem(string maHanhKiem)
        {
            return hanhKiemDAL.DeleteHanhKiem(maHanhKiem);
        }
        public List<HanhKiemDTO> SearchHanhKiem(string searchTerm)
        {
            return hanhKiemDAL.SearchHanhKiem(searchTerm);
        }
        public HanhKiemDTO GetHanhKiemByMa(string maHanhKiem)
        {
            return hanhKiemDAL.GetHanhKiemByMa(maHanhKiem);
        }
    }
}
