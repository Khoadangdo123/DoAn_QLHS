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

    public partial class ThemPhanCong : MaterialForm
    {
        private GiaoVienBLL giaoVienBLL = new GiaoVienBLL();
        private MonHocBLL monHocBLL = new MonHocBLL();
        private PhanCongBLL phanCongBLL = new PhanCongBLL();
        public ThemPhanCong()
        {

            InitializeComponent();
            LoadDanhSachNamHoc();
            LoadLopHoc();
            LoadMonHoc();
            LoadGiaoVien();
            string stt_New = phanCongBLL.GenSTT().ToString();
            txSttPhancong.Text = stt_New;
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

            // Old
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbPhancongNamhoc.SelectedValue == null ||
                cbPhancongGV.SelectedValue == null ||
                cbPhancongMonhoc.SelectedValue == null ||
                cbPhancongMalop.SelectedValue == null ||
                string.IsNullOrEmpty(txSoTiet.Text)) 

            {
                MessageBox.Show("Không được để trống !");
                return;
            }
            try
            {
                string selectedMaNamHoc = cbPhancongNamhoc.SelectedValue.ToString();
                string selectedMaGiaoVien = cbPhancongGV.SelectedValue.ToString();
                string selectedMaMonHoc = cbPhancongMonhoc.SelectedValue.ToString();
                string selectedMaLop = cbPhancongMalop.SelectedValue.ToString();
                string selectedSoTiet = txSoTiet.Text;
                DateTime selectedDate = dateTimePicker1.Value;

                if (string.IsNullOrEmpty(selectedMaNamHoc) || string.IsNullOrEmpty(selectedMaGiaoVien) ||
                    string.IsNullOrEmpty(selectedMaMonHoc) || string.IsNullOrEmpty(selectedMaLop) || string.IsNullOrEmpty(selectedSoTiet)) 
                {
                    MessageBox.Show("Please select valid values for all fields.");
                    return;
                }

                PhanCongDTO pc = new PhanCongDTO
                {
                    MaGiaoVien = selectedMaGiaoVien,
                    MaMonHoc = selectedMaMonHoc,
                    MaLop = selectedMaLop,
                    MaNamHoc = selectedMaNamHoc,
                    SoTiet = int.Parse(selectedSoTiet),
                    NgayPhanCong = selectedDate

                };

                bool result = phanCongBLL.InsertPhanCong(pc);
                if (result)
                {
                    MessageBox.Show("Thêm phân công thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm phân công thất bại! Duplicate entry or foreign key constraint violation.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPhancongGV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
