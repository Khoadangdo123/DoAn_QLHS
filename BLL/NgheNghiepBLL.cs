using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class NgheNghiepBLL
    {
        private NgheNghiepDAL ngheNghiepDAL = new NgheNghiepDAL();

        public List<KeyValuePair<string, string>> LayDanhSachNgheNghiep()
        {
            return ngheNghiepDAL.LayDanhSachNgheNghiep();
        }
    }
}
