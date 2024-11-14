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
    public partial class SuaPhanCong : MaterialForm
    {
        private GiaoVienBLL giaoVienBLL = new GiaoVienBLL();
        private MonHocBLL monHocBLL = new MonHocBLL();
        private PhanCongBLL phanCongBLL = new PhanCongBLL();
        public SuaPhanCong(int stt)
        {

            InitializeComponent();
            LoadDanhSachNamHoc();
            LoadLopHoc();
            LoadMonHoc();
            LoadGiaoVien();
            LoadPhanCongBySTT(stt);

        }
        private void LoadMonHoc()
        {
            List<MonHocDTO> monHocList = monHocBLL.GetAllMonHoc();
            cbPhancongMonhoc.DataSource = monHocList;
            cbPhancongMonhoc.DisplayMember = "TenMonHoc";
            cbPhancongMonhoc.ValueMember = "MaMonHoc";
        }
        private void LoadDanhSachNamHoc()
        {
            List<KeyValuePair<string, string>> namHocList = phanCongBLL.LayDanhSachNamHoc();

            cbPhancongNamhoc.DataSource = new BindingSource(namHocList, null);
            cbPhancongNamhoc.DisplayMember = "Value";
            cbPhancongNamhoc.ValueMember = "Key";
        }
        private void LoadGiaoVien()
        {
            List<GiaoVienDTO> giaoVienList = giaoVienBLL.GetAllGiaoVien();
            cbPhancongGV.DataSource = giaoVienList;
            cbPhancongGV.DisplayMember = "TenGiaoVien";
            cbPhancongGV.ValueMember = "MaGiaoVien";
        }
        private void LoadLopHoc()
        {
            List<KeyValuePair<string, string>> lopList = phanCongBLL.LayDanhSachLop();

            cbPhancongMalop.DataSource = new BindingSource(lopList, null);
            cbPhancongMalop.DisplayMember = "Value";
            cbPhancongMalop.ValueMember = "Key";

        }
        private void LoadPhanCongBySTT(int stt)
        {
            PhanCongDTO phanCongDTO = phanCongBLL.GetPhanCongBySTT(stt);
            txSttPhancong.Text = phanCongDTO.STT.ToString();
            cbPhancongNamhoc.SelectedValue = phanCongDTO.MaNamHoc;
            cbPhancongMalop.SelectedValue = phanCongDTO.MaLop;
            cbPhancongMonhoc.SelectedValue = phanCongDTO.MaMonHoc;
            cbPhancongGV.SelectedValue = phanCongDTO.MaGiaoVien;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedSTT = int.Parse(txSttPhancong.Text);
                string selectedMaNamHoc = cbPhancongNamhoc.SelectedValue.ToString();
                string selectedMaGiaoVien = cbPhancongGV.SelectedValue.ToString();
                string selectedMaMonHoc = cbPhancongMonhoc.SelectedValue.ToString();
                string selectedMaLop = cbPhancongMalop.SelectedValue.ToString();

                PhanCongDTO phanCongDTO = new PhanCongDTO
                {
                    STT = selectedSTT,
                    MaNamHoc = selectedMaNamHoc,
                    MaGiaoVien = selectedMaGiaoVien,
                    MaMonHoc = selectedMaMonHoc,
                    MaLop = selectedMaLop
                };

                bool result = phanCongBLL.UpdatePhanCong(phanCongDTO);
                if (result)
                {
                    MessageBox.Show("Sửa phân công thành công!");
                }
                else
                {
                    MessageBox.Show("Sửa phân công thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
