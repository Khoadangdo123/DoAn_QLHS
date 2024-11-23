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
    public partial class SuaTT : MaterialForm
    {
        ThanhTichBLL thanhTichBLL = new ThanhTichBLL();
        public SuaTT(string maThanhTich)
        {
            InitializeComponent();
            LoadThanhTichByMa(maThanhTich);

            cbDiemCong.Items.AddRange(new object[] { 1, 2, 3, 4, 5 });
            cbDiemCong.SelectedIndex = 0; // Set default selected value
        }

        private void LoadThanhTichByMa(string maThanhTich)
        {
            ThanhTichDTO thanhTich = thanhTichBLL.GetThanhTichByMa(maThanhTich);
            if (thanhTich != null)
            {
                txMaTT.Text = thanhTich.MaThanhTich;
                txTenTT.Text = thanhTich.TenThanhTich;
                cbDiemCong.SelectedItem = thanhTich.DiemThuong;
            }
        }
        private void btnSuaTT_Click(object sender, EventArgs e)
        {
            ThanhTichDTO thanhTich = new ThanhTichDTO
            {
                MaThanhTich = txMaTT.Text,
                TenThanhTich = txTenTT.Text,
                DiemThuong = Convert.ToDouble(cbDiemCong.SelectedItem)
            };

            if (thanhTichBLL.UpdateThanhTich(thanhTich))
            {
                MessageBox.Show("Sửa thành tích thành công!");
            }
            else
            {
                MessageBox.Show("Sửa thành tích thất bại!");
            }
        }
    }
}
