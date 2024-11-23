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
    public partial class ThemHanhKiem : MaterialForm
    {
        private HanhKiemBLL hanhKiemBLL = new HanhKiemBLL();

        public ThemHanhKiem()
        {
            InitializeComponent();

            string maHanhKiem_New = hanhKiemBLL.GenMaHK();
            txMaHK.Text = maHanhKiem_New;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HanhKiemDTO hanhKiem = new HanhKiemDTO
            {
                MaHanhKiem = txMaHK.Text,
                TenHanhKiem = txTenHK.Text,
                DiemCanTren = float.Parse(diemCantren.Text),
                DiemCanDuoi = float.Parse(diemCanduoi.Text)
            };

            if (hanhKiemBLL.AddHanhKiem(hanhKiem))
            {
                MessageBox.Show("Thêm hạnh kiểm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm hạnh kiểm thất bại!");
            }
        }
    }
}
