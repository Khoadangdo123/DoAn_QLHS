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
    public partial class SuaHK : MaterialForm
    {
        HanhKiemBLL hanhKiemBLL = new HanhKiemBLL();
        public SuaHK(string maHanhKiem)
        {
            InitializeComponent();
            LoadHanhKiemByMa(maHanhKiem);
        }

        private void LoadHanhKiemByMa(string maHanhKiem)
        {
            HanhKiemDTO hanhKiem = hanhKiemBLL.GetHanhKiemByMa(maHanhKiem);
            if (hanhKiem != null)
            {
                txMaHK.Text = hanhKiem.MaHanhKiem;
                txTenHK.Text = hanhKiem.TenHanhKiem;
                diemCantren.Text = hanhKiem.DiemCanTren.ToString();
                diemCanduoi.Text = hanhKiem.DiemCanDuoi.ToString();
            }
        }
        private void btnSuaHK_Click(object sender, EventArgs e)
        {
            HanhKiemDTO hanhKiem = new HanhKiemDTO
            {
                MaHanhKiem = txMaHK.Text,
                TenHanhKiem = txTenHK.Text,
                DiemCanTren = float.Parse(diemCantren.Text),
                DiemCanDuoi = float.Parse(diemCanduoi.Text)
            };

            if (hanhKiemBLL.UpdateHanhKiem(hanhKiem))
            {
                MessageBox.Show("Sửa hạnh kiểm thành công!");
            }
            else
            {
                MessageBox.Show("Sửa hạnh kiểm thất bại!");
            }
        }
    }
}
