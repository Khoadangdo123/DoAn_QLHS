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
    public partial class ThemVP : MaterialForm
    {
        private ViPhamBLL viPhamBLL = new ViPhamBLL();
        public ThemVP()
        {
            InitializeComponent();

            string maViPham_New = viPhamBLL.GenMaVP();
            txMaVP.Text = maViPham_New;

            cbDiemtru.Items.AddRange(new object[] { 1, 2, 3, 4, 5 });
            cbDiemtru.SelectedIndex = 0; // Set default selected value
        }
        

        private void btnThemVP_Click(object sender, EventArgs e)
        {
            ViPhamDTO viPham = new ViPhamDTO
            {
                MaViPham = txMaVP.Text,
                TenViPham = txTenVP.Text,
                DiemTru = Convert.ToDouble(cbDiemtru.SelectedItem)
            };
            


            if (viPhamBLL.InsertViPham(viPham))
            {
                MessageBox.Show("Thêm vi phạm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm vi phạm thất bại!");
            }
        }
    }
}
