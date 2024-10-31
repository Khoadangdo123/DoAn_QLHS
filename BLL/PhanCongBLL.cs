using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI_CSharp.DTO;

namespace BLL
{
    internal class PhanCongBLL
    {
        public List<PhanCongDTO> ListPC = new List<PhanCongDTO>();

        public PhanCongBLL() { }

        public PhanCongBLL(List<PhanCongDTO> listPC)
        {
            ListPC = listPC;
        }

        //Kiểm tra trùng
        public Boolean CheckDupPhanCong(PhanCongDTO phanCong)
        {

            return true;
        }

        //Thêm phân công
        public Boolean addPhanCong(PhanCongDTO phanCong)
        {
            ListPC.Add(phanCong);
            return true;
        }

        //Sửa phân công
        public Boolean updatePhanCong(PhanCongDTO newPhanCong, PhanCongDTO oldPhanCong)
        {
            return true;
        }

        //Xóa phân công
        public Boolean deletePhanCong(PhanCongDTO phanCong)
        {
            return true;
        }

        //Tìm kiếm, lọc
    }
}
