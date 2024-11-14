using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;
using GUI_CSharp.DTO;

namespace GUI_CSharp
{
    public partial class ThemGV : MaterialSkin.Controls.MaterialForm
    {
        private GiaoVienBLL giaoVienBLL = new GiaoVienBLL();
        private MonHocBLL monHocBLL = new MonHocBLL();

        public ThemGV()
        {
            InitializeComponent();
            LoadMonHoc();
            string maGiaoVien_New = giaoVienBLL.GenMaGV();
            txMaGV.Text = maGiaoVien_New;
        }

        private void LoadMonHoc()
        {
            List<MonHocDTO> monHocList = monHocBLL.GetAllMonHoc();
            cbMonGiangday.DataSource = monHocList;
            cbMonGiangday.DisplayMember = "TenMonHoc";
            cbMonGiangday.ValueMember = "MaMonHoc";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                GiaoVienDTO gv = new GiaoVienDTO
                {
                    MaGiaoVien = txMaGV.Text,
                    TenGiaoVien = txTenGV.Text,
                    DiaChi = txDiachi.Text,
                    DienThoai = txSdt.Text,
                    MaMonHoc = cbMonGiangday.SelectedValue.ToString()
                };

                Console.WriteLine($"MaGiaoVien: {gv.MaGiaoVien}, TenGiaoVien: {gv.TenGiaoVien}, DiaChi: {gv.DiaChi}, DienThoai: {gv.DienThoai}, MaMonHoc: {gv.MaMonHoc}");

                bool result = giaoVienBLL.InsertGiaoVien(gv);
                if (result)
                {
                    MessageBox.Show("Thêm giáo viên thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm giáo viên thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}
