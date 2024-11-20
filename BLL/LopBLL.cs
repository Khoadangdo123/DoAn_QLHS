using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LopBLL
    {
        private LopDAL LopDAL = new LopDAL();

        public List<string> GetKhoiList()
        {
            return LopDAL.GetKhoiList();
        }

        public List<string> GetLopList()
        {
            return LopDAL.GetLopList();
        }
        public List<string> GetNamhocList()
        {
            return LopDAL.GetNamhocList();
        }
    }
}