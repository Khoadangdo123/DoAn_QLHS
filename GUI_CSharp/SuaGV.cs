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
    public partial class SuaGV : MaterialForm
    {

        private GiaoVienBLL giaoVienBLL = new GiaoVienBLL();
        private MonHocBLL monHocBLL = new MonHocBLL();
        public SuaGV(string maGiaoVien)
        {
            InitializeComponent();
            LoadMonHoc();
            LoadGiaoVienById(maGiaoVien);


        }
        public void LoadGiaoVienById(string maGiaoVien)
        {
           GiaoVienDTO giaoVienDTO = giaoVienBLL.GetGiaoVienByMaGiaoVien(maGiaoVien);
            txMaGV.Text = giaoVienDTO.MaGiaoVien;
            txTenGV.Text = giaoVienDTO.TenGiaoVien;
            txDiachi.Text = giaoVienDTO.DiaChi;
            txSdt.Text = giaoVienDTO.DienThoai;
            cbMonGiangday.SelectedValue = giaoVienDTO.MaMonHoc;
        }

        private void LoadMonHoc()
        {
            List<MonHocDTO> monHocList = monHocBLL.GetAllMonHoc();
            cbMonGiangday.DataSource = monHocList;
            cbMonGiangday.DisplayMember = "TenMonHoc";
            cbMonGiangday.ValueMember = "MaMonHoc";
        }
        private void btnSua_Click(object sender, EventArgs e)
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

                bool result = giaoVienBLL.UpdateGiaoVien(gv);
                if (result)
                {
                    MessageBox.Show("Sửa giáo viên thành công!");
                }
                else
                {
                    MessageBox.Show("Sửa giáo viên thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
