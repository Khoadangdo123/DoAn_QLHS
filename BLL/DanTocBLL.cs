using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class DanTocBLL
    {
        private DanTocDAL danTocDAL = new DanTocDAL();

        public List<KeyValuePair<string, string>> LayDanhSachDanToc()
        {
            return danTocDAL.LayDanhSachDanToc();
        }
    }
}
