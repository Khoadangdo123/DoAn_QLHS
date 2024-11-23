using BLL;
using GUI_CSharp.DTO;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_CSharp
{
    public partial class SuaHL : MaterialForm
    {
        HocLucBLL hocLucBLL = new HocLucBLL();
        public SuaHL(string maHocLuc)
        {
            InitializeComponent();
            LoadHocLucByMa(maHocLuc);

            
        }

        private void LoadHocLucByMa(string maHocLuc)
        {
            HocLucDTO hocLuc = hocLucBLL.GetHocLucByMa(maHocLuc);
            if (hocLuc != null)
            {
                txMaHL.Text = hocLuc.MaHocLuc;
                txTenHL.Text = hocLuc.TenHocLuc;
                diemCantren.Text = hocLuc.DiemCanTren.ToString();
                diemCanduoi.Text = hocLuc.DiemCanDuoi.ToString();
                diemKhongche.Text = hocLuc.DiemKhongChe.ToString();
            }
        }
        private void btnSuaHL_Click(object sender, EventArgs e)
        {
            HocLucDTO hocLuc = new HocLucDTO
            {
                MaHocLuc = txMaHL.Text,
                TenHocLuc = txTenHL.Text,
                DiemCanTren = float.Parse(diemCantren.Text),
                DiemCanDuoi = float.Parse(diemCanduoi.Text),
                DiemKhongChe = float.Parse(diemKhongche.Text)
            };

            if (hocLucBLL.UpdateHocLuc(hocLuc))
            {
                MessageBox.Show("Sửa học lực thành công!");
            }
            else
            {
                MessageBox.Show("Sửa học lực thất bại!");
            }
        }
    }
}
