using DAL;
using Google.Protobuf.Reflection;
using GUI_CSharp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaiKhoanBLL
    {
        public string[] taikhoan(String txttaiKhoan, String txtmatKhau)
        {
            if (txttaiKhoan == "" && txtmatKhau != "")
            {
                string[] infotk = { "1" };
                return infotk;
            }
            else if (txttaiKhoan != "" && txtmatKhau == "")
            {
                string[] infotk = { "2" };
                return infotk;
            }
            else if (txttaiKhoan == "" && txtmatKhau == "")
            {
                string[] infotk = { "3" };
                Console.WriteLine(infotk[0]);
                return infotk;
            }
            else
            {
                NguoiDungDTO nd = new NguoiDungDTO("", "", "", txttaiKhoan, txtmatKhau);

                TaiKhoanAccess dbaccc = new TaiKhoanAccess();
                String textTaiKhoan = dbaccc.TaiKhoanAccessNd(nd).TenDangNhap;
                String textMatKhau = dbaccc.TaiKhoanAccessNd(nd).MatKhau;
                String textTenNguoiDung = dbaccc.TaiKhoanAccessNd(nd).TenNguoiDung;
                String textMaLoaiNguoiDung = dbaccc.TaiKhoanAccessNd(nd).MaLoai;
                String textMaNguoiDung = dbaccc.TaiKhoanAccessNd(nd).MaNguoiDung;
                
                if (
                    (txttaiKhoan == textTaiKhoan) &&
                    (txtmatKhau == textMatKhau)
                   )
                {
                    string[] infotk = { "4", textMaLoaiNguoiDung, textMaNguoiDung, textTenNguoiDung };
                    return infotk;
                }
                else
                {
                    string[] infotk = { "5" };
                    return infotk;
                }
            }
        }

    }
}
