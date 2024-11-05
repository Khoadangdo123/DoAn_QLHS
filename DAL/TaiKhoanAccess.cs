using GUI_CSharp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoanAccess
    {
        public NguoiDungDTO TaiKhoanAccessNd(NguoiDungDTO nd)
        {
            DatabaseAccess connect = new DatabaseAccess();
            NguoiDungDTO info = connect.Kiemtralogic(nd);
            return info;
        }
    }
}
