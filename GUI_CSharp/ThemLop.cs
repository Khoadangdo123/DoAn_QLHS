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

namespace GUI_CSharp
{
    public partial class ThemLop : MaterialForm
    {
        public ThemLop()
        {
            InitializeComponent();
            QuanLyLopHocBLL list = new QuanLyLopHocBLL();

            // Add items to the combo box
            cbKhoilop.DataSource = list.getKhoiLopList();
            cbKhoilop.DisplayMember = "TenKhoiLop";
            cbKhoilop.ValueMember = "MaKhoiLop";


            //foreach (var namhocdata in list.getNamHocList())
            //{
            //    cbNamhoc.Items.Add(namhocdata);
            //}

            cbNamhoc.DataSource = list.getNamHocListData();
            cbNamhoc.DisplayMember = "TenNamHoc";
            cbNamhoc.ValueMember = "MaNamHoc";

            cbGiaovien.DataSource = list.getGiaoVienList();
            cbGiaovien.DisplayMember = "HoTen";
            cbGiaovien.ValueMember = "MaGiaoVien";

            //txHocKy.Items.Add("HK1");
            //txHocKy.Items.Add("HK2");

            materialComboBox1.DataSource = list.getHocKyList();
            materialComboBox1.DisplayMember = "TenHocKy";
            materialComboBox1.ValueMember = "MaHocKy";

            //foreach (var namhoc in list.getNamHocList())
            //{
            //    cbNamhoc.Items.Add(namhoc);
            //}

            //cbGiaovien.DataSource = list.getGiaoVienList();
            //cbGiaovien.DisplayMember = "HoTen";
            //cbGiaovien.ValueMember = "MaGiaoVien";


            //materialComboBox1.Items.Add("HK1");
            //materialComboBox1.Items.Add("HK2");
        }

        private void cbGiaovien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbKhoilop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private static Random random = new Random();

        public string TaoMaLop(string maKhoi, string namHoc)
        {
            // Lấy 2 chữ số cuối của mã khối
            string khoiFormatted = maKhoi.Substring(maKhoi.Length - 2);

            // Lấy 2 chữ số cuối của năm học
            string namHocFormatted = namHoc.Substring(namHoc.Length - 2);

            // Tạo số ngẫu nhiên có 3 chữ số
            string soNgauNhien = random.Next(0, 1000).ToString("D3");  // Tạo số ngẫu nhiên từ 000 đến 999

            // Kết hợp các thành phần để tạo mã lớp
            string maLop = $"LOP{khoiFormatted}{namHocFormatted}{soNgauNhien}";
            return maLop;
        }

        private void materialCard_Paint(object sender, PaintEventArgs e)
        {
            // Xử lý sự kiện ở đây nếu cần
        }


        private void btnThem_Click(object sender, EventArgs e)
        {

            QuanLyLopHocBLL qllhChucNang = new QuanLyLopHocBLL();

            // Kiểm tra Mã Lớp Học
            //if (string.IsNullOrWhiteSpace(txMalop.Text))
            //{
            //    MessageBox.Show("Mã lớp không được để trống.");
            //    return;
            //}
            //string textMaLopHoc = txMalop.Text;
            string textMaLopHoc = TaoMaLop(
                cbKhoilop.SelectedValue.ToString(),
                cbNamhoc.SelectedValue.ToString()
            );

            // Trùng lặp
            while (qllhChucNang.checkMaLopHocList(textMaLopHoc))
            {
                textMaLopHoc = TaoMaLop(
                    cbKhoilop.SelectedValue.ToString(),
                    cbNamhoc.SelectedValue.ToString()
                );
            }

            // Kiểm tra Tên Lớp Học
            if (string.IsNullOrWhiteSpace(txTenlop.Text))
            {
                MessageBox.Show("Tên lớp không được để trống.");
                return;
            }
            string textTenLopHoc = txTenlop.Text;

            // Kiểm tra Khối Lớp
            if (cbKhoilop.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khối lớp.");
                return;
            }
            string textKhoiLop = cbKhoilop.SelectedValue.ToString();

            // Kiểm tra Sĩ Số
            if (string.IsNullOrWhiteSpace(txSiso.Text))
            {
                MessageBox.Show("Sĩ số không được để trống.");
                return;
            }

            int textSiSo;
            if (!int.TryParse(txSiso.Text, out textSiSo) || textSiSo <= 0)
            {
                MessageBox.Show("Sĩ số phải là một số nguyên dương.");
                return;
            }

            // Kiểm tra Năm Học
            if (cbNamhoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn năm học.");
                return;
            }
            string textNamHoc = cbNamhoc.SelectedValue.ToString();

            // Kiểm tra Giáo Viên
            if (cbGiaovien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn giáo viên.");
                return;
            }
            string textGiaoVien = cbGiaovien.SelectedValue.ToString();

            // Kiểm tra Học Kỳ
            if (materialComboBox1.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn học kỳ.");
                return;
            }
            string textHocKy = materialComboBox1.SelectedValue.ToString();


            try
            {
                qllhChucNang.insertListLopHoc(
                    textMaLopHoc, textTenLopHoc,
                    textKhoiLop, textNamHoc,
                    textSiSo, textGiaoVien,
                    textHocKy
                );
                MessageBox.Show("Thêm lớp học thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }


            //string textMaLopHoc = txMalop.Text;
            //string textTenLopHoc = txTenlop.Text;
            //string textKhoiLop = cbKhoilop.SelectedValue.ToString();
            //int textSiSo = int.Parse(txSiso.Text.ToString());
            //string textNamHoc = cbNamhoc.SelectedValue.ToString();
            //string textGiaoVien = cbGiaovien.SelectedValue.ToString();
            //string textHocKy = materialComboBox1.SelectedValue.ToString();
            //QuanLyLopHocBLL qllhChucNang = new QuanLyLopHocBLL();
            //qllhChucNang.insertListLopHoc(
            //    textMaLopHoc, textTenLopHoc,
            //    textKhoiLop, textNamHoc,
            //    textSiSo, textGiaoVien,
            //    textHocKy
            // );
            Trangchu a = new Trangchu();
            a.LoadDanhSachLop();

        }
    }
}
