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
    public partial class SuaLop : MaterialForm
    {
        public SuaLop()
        {
            InitializeComponent();

        }

        public SuaLop(string malop, string tenlop, 
            string khoilop, string siso,
            string namhoc, string giaovien,
            string hocky
        )
        {
            InitializeComponent();

            
            QuanLyLopHocBLL list = new QuanLyLopHocBLL();

            // Add items to the combo box
            
            //cbKhoilop.Items.Add("KHOI10");
            //cbKhoilop.Items.Add("KHOI11");
            //cbKhoilop.Items.Add("KHOI12");

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

            txHocKy.DataSource = list.getHocKyList();
            txHocKy.DisplayMember = "TenHocKy";
            txHocKy.ValueMember = "MaHocKy";


            txMalop.Text = malop.ToString();
            txTenlop.Text = tenlop.ToString();
            txSiso.Text = siso.ToString();
            cbKhoilop.SelectedItem = khoilop.ToString();
            cbNamhoc.SelectedItem = namhoc.ToString();
            cbGiaovien.SelectedItem = giaovien.ToString();
            txHocKy.SelectedItem = hocky.ToString();

        }

        public void btnSua_Click(object sender, EventArgs e)
        {

            // Kiểm tra Mã Lớp Học
            if (string.IsNullOrWhiteSpace(txMalop.Text))
            {
                MessageBox.Show("Mã lớp không được để trống.");
                return;
            }
            string textMaLop = txMalop.Text;

            // Kiểm tra Tên Lớp Học
            if (string.IsNullOrWhiteSpace(txTenlop.Text))
            {
                MessageBox.Show("Tên lớp không được để trống.");
                return;
            }
            string textTenLop = txTenlop.Text;

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
            if (txHocKy.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn học kỳ.");
                return;
            }
            string textHocKy = txHocKy.SelectedValue.ToString();

            // Nếu tất cả các kiểm tra đều hợp lệ, gọi phương thức updateListLopHoc
            try
            {
                QuanLyLopHocBLL qllhChucNang = new QuanLyLopHocBLL();
                qllhChucNang.updateListLopHoc(
                    textMaLop, textTenLop,
                    textKhoiLop, textNamHoc,
                    textSiSo, textGiaoVien,
                    textHocKy
                );
                MessageBox.Show("Cập nhật lớp học thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình cập nhật: " + ex.Message);
            }

            //string textMaLop = txMalop.Text;
            //string textTenLop = txTenlop.Text;
            //string textKhoiLop = cbKhoilop.SelectedValue.ToString();
            //int textSiSo = int.Parse(txSiso.Text.ToString());
            //string textNamHoc = cbNamhoc.SelectedValue.ToString();
            //string textGiaoVien = cbGiaovien.SelectedValue.ToString();
            //string textHocKy = txHocKy.SelectedValue.ToString();
            //QuanLyLopHocBLL qllhChucNang = new QuanLyLopHocBLL();
            //qllhChucNang.updateListLopHoc(
            //    textMaLop, textTenLop,
            //    textKhoiLop, textNamHoc,
            //    textSiSo, textGiaoVien,
            //    textHocKy
            // );
        }
    }
}
