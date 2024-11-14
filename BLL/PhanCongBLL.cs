using System.Collections.Generic;
using DAL;
using GUI_CSharp.DTO;

namespace BLL
{
    public class PhanCongBLL
    {
        private PhanCongDAL phanCongDAL;

        public PhanCongBLL()
        {
            phanCongDAL = new PhanCongDAL();
        }

        public List<PhanCongDTO> GetAllPhanCong()
        {
            return phanCongDAL.GetAllPhanCong();
        }

        public PhanCongDTO GetPhanCongBySTT(int stt)
        {
            return phanCongDAL.GetPhanCongBySTT(stt);
        }

        public bool InsertPhanCong(PhanCongDTO pc)
        {
            return phanCongDAL.InsertPhanCong(pc);
        }

        public bool UpdatePhanCong(PhanCongDTO pc)
        {
            return phanCongDAL.UpdatePhanCong(pc);
        }

        public bool DeletePhanCong(int stt)
        {
            return phanCongDAL.DeletePhanCong(stt);
        }
        public List<KeyValuePair<string, string>> LayDanhSachNamHoc()
        {
            return phanCongDAL.LayDanhSachNamHoc();
        }
        public List<KeyValuePair<string, string>> LayDanhSachLop()
        {
            return phanCongDAL.LayDanhSachLop();
        }
        public int GenSTT()
        {
            return phanCongDAL.GenSTT();
        }
        public List<PhanCongDTO> SearchPhanCong(string searchTerm)
        {
            return phanCongDAL.SearchPhanCong(searchTerm);
        }
    }
}
