using DAL;
using GUI_CSharp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThanhTichBLL
    {
        private ThanhTichDAL thanhTichDAL = new ThanhTichDAL();

        public string GenMaTT()
        {
            return thanhTichDAL.GenMaTT();
        }

        public List<ThanhTichDTO> GetAllThanhTich()
        {
            return thanhTichDAL.GetAllThanhTich();
        }
        public bool AddThanhTich(ThanhTichDTO thanhTich)
        {
            return thanhTichDAL.AddThanhTich(thanhTich);
        }

        public List<ThanhTichDTO> LayDanhSachThanhTich()
        {
            return thanhTichDAL.GetAllThanhTich();
        }
        public bool DeleteThanhTich(string maThanhTich)
        {
            return thanhTichDAL.DeleteThanhTich(maThanhTich);
        }

        public bool UpdateThanhTich(ThanhTichDTO thanhTich)
        {
            return thanhTichDAL.UpdateThanhTich(thanhTich);
        }
        public List<ThanhTichDTO> SearchThanhTich(string searchTerm)
        {
            return thanhTichDAL.SearchThanhTich(searchTerm);
        }
        public ThanhTichDTO GetThanhTichByMa(string maThanhTich)
        {
            return thanhTichDAL.GetThanhTichByMa(maThanhTich);
        }
    }
}
