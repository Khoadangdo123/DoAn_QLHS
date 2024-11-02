using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class TonGiaoBLL
    {
        private TonGiaoDAL tonGiaoDAL = new TonGiaoDAL();

        public List<KeyValuePair<string, string>> LayDanhSachTonGiao()
        {
            return tonGiaoDAL.LayDanhSachTonGiao();
        }
    }
}
