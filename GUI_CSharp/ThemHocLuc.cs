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
using GUI_CSharp.DTO;


namespace GUI_CSharp
{
    public partial class ThemHocLuc : MaterialForm
    {
        HocLucBLL hocLucBLL = new HocLucBLL();
        public ThemHocLuc()
        {
            InitializeComponent();
            string maHocLuc_New = hocLucBLL.GenMaHL();
            txMaHL.Text = maHocLuc_New;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HocLucDTO hocLuc = new HocLucDTO
            {
                MaHocLuc = txMaHL.Text,
                TenHocLuc = txTenHL.Text,
                DiemCanTren = double.Parse(diemCantren.Text),
                DiemCanDuoi = double.Parse(diemCanduoi.Text),
                DiemKhongChe = double.Parse(diemKhongche.Text)
            };

            if (hocLucBLL.AddHocLuc(hocLuc))
            {
                MessageBox.Show("Thêm học lực thành công!");
            }
            else
            {
                MessageBox.Show("Thêm học lực thất bại!");
            }
        }

        
    }
}
