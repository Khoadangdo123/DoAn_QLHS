using DAL;
using GUI_CSharp.DTO;
using System.Collections.Generic;

namespace BLL
{
    public class MonHocBLL
    {
        private MonHocDAL monHocDAL = new MonHocDAL();

        public List<MonHocDTO> GetAllMonHoc()
        {
            return monHocDAL.GetAllMonHoc();
        }
    }
}
