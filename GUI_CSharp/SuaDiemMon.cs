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
using DocumentFormat.OpenXml.Drawing;
using GUI_CSharp.DTO;

namespace GUI_CSharp
{
    public partial class SuaDiemMon : MaterialForm
    {
        private DiemMonBLL diemMonBLL = new DiemMonBLL();
        public SuaDiemMon(string maHocSinh)
        {
            InitializeComponent();
            LoadDiemMonByMa(maHocSinh);
        }

        private void LoadDiemMonByMa(string maHocSinh)
        {
            KQ_HocSinh_MonHocDTO diemMon = diemMonBLL.GetDiemMonByMa(maHocSinh);

            if (diemMon != null)
            {
                txMaHS.Text = diemMon.MaHocSinh;
                txMonhoc.Text = diemMon.TenMonHoc;
                txDiemMieng.Text = diemMon.DiemMiengTB.ToString();
                txDiem15.Text = diemMon.Diem15PhutTB.ToString();
                txDiem45.Text = diemMon.Diem45PhutTB.ToString();
                txDiemthi.Text = diemMon.DiemThi.ToString();

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KQ_HocSinh_MonHocDTO diemMon = new KQ_HocSinh_MonHocDTO
            {
                MaHocSinh = txMaHS.Text,
                DiemMiengTB = Convert.ToDouble(txDiemMieng.Text),
                Diem15PhutTB = Convert.ToDouble(txDiem15.Text),
                Diem45PhutTB = Convert.ToDouble(txDiem45.Text),
                DiemThi = Convert.ToDouble(txDiemthi.Text),
            };

            if (diemMonBLL.UpdateDiemMon(diemMon))
            {
                MessageBox.Show("Câp nhật điểm môn của học sinh có mã " + diemMon.MaHocSinh + " thành công!");
            }
            else
            {
                MessageBox.Show("Câp nhật điểm môn của học sinh có mã " + diemMon.MaHocSinh + " thất bại!");

            }
        }
    }
}
