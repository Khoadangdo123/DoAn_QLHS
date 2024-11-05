using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using BLL;

namespace GUI_CSharp
{
    public partial class Dangnhap : MaterialForm
    {
        public Dangnhap()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Teal700, TextShade.WHITE);
            
        }

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (check_matKhau.Checked)
            {
                txtMatkhau.Password = false;
            }
            else
            {
                txtMatkhau.Password = true;
            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            TaiKhoanBLL dn = new TaiKhoanBLL();
            String textTaiKhoan = txtTaikhoan.Text;
            String textMatKhau = txtMatkhau.Text;
            if (dn.taikhoan(textTaiKhoan, textMatKhau)[0] == "1")
            {
                MessageBox.Show("Yêu cầu không để trống tài khoản", "Thông báo");
            }
            else if (dn.taikhoan(textTaiKhoan, textMatKhau)[0] == "2")
            {
                MessageBox.Show("Yêu cầu không để trống mật khẩu", "Thông báo");
            }
            else if (dn.taikhoan(textTaiKhoan, textMatKhau)[0] == "3")
            {
                MessageBox.Show("Yêu cầu không để trống tài khoản và mật khẩu", "Thông báo");
            }
            else if (dn.taikhoan(textTaiKhoan, textMatKhau)[0] == "4")
            {
                String textMaLoaiNguoiDung = dn.taikhoan(textTaiKhoan, textMatKhau)[1];
                String textMaNguoiDung = dn.taikhoan(textTaiKhoan, textMatKhau)[2];
                String textTenNguoiDung = dn.taikhoan(textTaiKhoan, textMatKhau)[3];
                MessageBox.Show("Đăng Nhập Thành Công", "Thông báo");
                this.Hide();
                Trangchu a = new Trangchu(textMaLoaiNguoiDung, textMaNguoiDung, textTenNguoiDung);
                a.Show();
                a.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Bạn nhập sai mật khẩu và tài khoản", "Thông báo");
            }

            //MessageBox.Show("Đăng Nhập Thành Công", "Thông báo");
            //this.Hide();
            //Trangchu a = new Trangchu("textMaLoaiNguoiDung", "textMaNguoiDung", "textTenNguoiDung");
            //a.Show();
            //a.FormClosed += (s, args) => this.Close();

        }

        private void txTaikhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
