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
    public partial class SuaVP : MaterialForm
    {
        ViPhamBLL viPhamBLL = new ViPhamBLL();
        public SuaVP(string maViPham)
        {
            InitializeComponent();
            LoadViPhamByMa(maViPham);

            cbDiemTru.Items.AddRange(new object[] { 1, 2, 3, 4, 5 });
            cbDiemTru.SelectedIndex = 0; // Set default selected value
        }

        private void LoadViPhamByMa(string maViPham)
        {
            ViPhamDTO viPham = viPhamBLL.GetViPhamByMa(maViPham);
            if (viPham != null)
            {
                txMaVP.Text = viPham.MaViPham;
                txMaVP.Text = viPham.MaViPham;
                cbDiemTru.SelectedItem = viPham.DiemTru;
            }
        }
        private void btnSuaVP_Click(object sender, EventArgs e)
        {
            ViPhamDTO viPham = new ViPhamDTO
            {
                MaViPham = txMaVP.Text,
                TenViPham = txTenVP.Text,
                DiemTru = Convert.ToDouble(cbDiemTru.SelectedItem)
            };

            if (viPhamBLL.UpdateViPham(viPham))
            {
                MessageBox.Show("Sửa vi phạm thành công!");
            }
            else
            {
                MessageBox.Show("Sửa vi phạm thất bại!");
            }
        }


    }
}
