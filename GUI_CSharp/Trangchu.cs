﻿using System;
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
using System.Runtime.CompilerServices;
using BLL;
using GUI_CSharp.DTO;
using OfficeOpenXml;
using System.IO;



namespace GUI_CSharp
{
    public partial class Trangchu : MaterialForm
    {
        private HocSinhBLL hocSinhBLL = new HocSinhBLL();
        private PhanLopBLL phanLopBLL = new PhanLopBLL();
        private DiemMonBLL diemMonBLL = new DiemMonBLL();
        public Trangchu()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            this.materialTabControl1.Selected += new TabControlEventHandler(this.MaterialTabControl_Selected);
            LoadDataTableHocSinh();
            LoadDataTableDiemMon();
            LoadDanhSachNamHoc();
            LoadDanhSachHocKy();
            LoadDanhSachKhoiLop();
            LoadDanhSachLop();
            LoadDanhSachMonHoc();
        }

        //Load -- Hoc Sinh
        private void LoadDataTableHocSinh()
        {
            List<HocSinhDTO> listHocSinh = hocSinhBLL.GetAllHocSinh();

            listHS.Items.Clear();

            foreach (var hs in listHocSinh)
            {
                ListViewItem item = new ListViewItem(hs.MaHocSinh);

                item.SubItems.Add(hs.HoTen);
                item.SubItems.Add(hs.convertGioiTinh);
                item.SubItems.Add(hs.NgaySinh.ToShortDateString());
                item.SubItems.Add(hs.DiaChi);
                item.SubItems.Add(hs.TenDanToc);
                item.SubItems.Add(hs.TenTonGiao);
                item.SubItems.Add(hs.HoTenCha);
                item.SubItems.Add(hs.TenNgheCha);
                item.SubItems.Add(hs.HoTenMe);
                item.SubItems.Add(hs.TenNgheMe);
                item.SubItems.Add(hs.Email);

                listHS.Items.Add(item);
            }

            listHS.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        //Load - Diem Mon Hoc
        private void LoadDataTableDiemMon()
        {
            List<KQ_HocSinh_MonHocDTO> listDiemMon = diemMonBLL.GetTableDiemMon();

            listDiem_Monhoc.Items.Clear();

            foreach (var dm in listDiemMon)
            {
                ListViewItem item = new ListViewItem(dm.MaHocSinh);

                item.SubItems.Add(dm.TenHocSinh);
                item.SubItems.Add(dm.DiemMiengTB.ToString());
                item.SubItems.Add(dm.Diem15PhutTB.ToString());
                item.SubItems.Add(dm.Diem45PhutTB.ToString());
                item.SubItems.Add(dm.DiemThi.ToString());
                item.SubItems.Add(dm.DiemTBHK.ToString());

                listDiem_Monhoc.Items.Add(item);
            }

            listDiem_Monhoc.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        //Load -- Phan Lop
        private void LoadDanhSachNamHoc()
        {
            List<KeyValuePair<string, string>> namHocList = phanLopBLL.LayDanhSachNamHoc();

            // Old
            cbNamhoc_Phanlop.DataSource = new BindingSource(namHocList, null);
            cbNamhoc_Phanlop.DisplayMember = "Value";
            cbNamhoc_Phanlop.ValueMember = "Key";

            // New
            cbNamhoc_Phanlop2.DataSource = new BindingSource(namHocList, null);
            cbNamhoc_Phanlop2.DisplayMember = "Value";
            cbNamhoc_Phanlop2.ValueMember = "Key";

            // New
            cbNamhoc_diem.DataSource = new BindingSource(namHocList, null);
            cbNamhoc_diem.DisplayMember = "Value";
            cbNamhoc_diem.ValueMember = "Key";
        }

        private void LoadDanhSachHocKy()
        {
            List<KeyValuePair<string, string>> hocKyList = phanLopBLL.LayDanhSachHocKy();

            // Old
            cbHocky_Phanlop.DataSource = new BindingSource(hocKyList, null);
            cbHocky_Phanlop.DisplayMember = "Value";
            cbHocky_Phanlop.ValueMember = "Key";

            // New
            cbHocky_Phanlop2.DataSource = new BindingSource(hocKyList, null);
            cbHocky_Phanlop2.DisplayMember = "Value";
            cbHocky_Phanlop2.ValueMember = "Key";

            cbHocky_diem.DataSource = new BindingSource(hocKyList, null);
            cbHocky_diem.DisplayMember = "Value";
            cbHocky_diem.ValueMember = "Key";
        }

        private void LoadDanhSachKhoiLop()
        {
            List<KeyValuePair<string, string>> khoiLopList = phanLopBLL.LayDanhSachKhoiLop();

            // Old
            cbKhoilop_Phanlop.DataSource = new BindingSource(khoiLopList, null);
            cbKhoilop_Phanlop.DisplayMember = "Value";
            cbKhoilop_Phanlop.ValueMember = "Key";

            // New
            cbKhoilop_Phanlop2.DataSource = new BindingSource(khoiLopList, null);
            cbKhoilop_Phanlop2.DisplayMember = "Value";
            cbKhoilop_Phanlop2.ValueMember = "Key";
        }

        private void LoadDanhSachLop()
        {
            List<KeyValuePair<string, string>> lopList = phanLopBLL.LayDanhSachLop();

            // Old
            cbLop_Phanlop.DataSource = new BindingSource(lopList, null);
            cbLop_Phanlop.DisplayMember = "Value";
            cbLop_Phanlop.ValueMember = "Key";

            // New
            cbLop_Phanlop2.DataSource = new BindingSource(lopList, null);
            cbLop_Phanlop2.DisplayMember = "Value";
            cbLop_Phanlop2.ValueMember = "Key";

            cbLop_diem.DataSource = new BindingSource(lopList, null);
            cbLop_diem.DisplayMember = "Value";
            cbLop_diem.ValueMember = "Key";
        }

        private void LoadDanhSachMonHoc()
        {
            List<KeyValuePair<string, string>> monHocList = diemMonBLL.LayDanhSachMonHoc();

            cbMon_diem.DataSource = new BindingSource(monHocList, null);
            cbMon_diem.DisplayMember = "Value";
            cbMon_diem.ValueMember = "Key";
        }


        private void MaterialTabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 8)
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    Dangnhap dn = new Dangnhap();
                    dn.Show();
                    dn.FormClosed += (s, args) => this.Close();
                }
                else
                {
                    this.materialTabControl1.SelectedTab = this.materialTabControl1.TabPages[0];
                }
            }

            // Lớp học
            if (e.TabPageIndex == 1)
            {
                cardLop1.Visible = true;
            }

            // Giáo viên
            if (e.TabPageIndex == 2)
            {
                cardListGV.Visible = true;
                cardListPhancong.Visible = false;
            }


            // Học sinh
            if (e.TabPageIndex == 3)
            {
                cardLopcu.Visible = false;
                cardLopmoi.Visible = false;
                cardAction_Phanlop.Visible = false;
                cardListHS.Visible = true;
                cardActionHS.Visible = true;
            }

            // Môn học
            if (e.TabPageIndex == 4)
            {

            }

            // Kết quả
            if (e.TabPageIndex == 5)
            {
                listDiem_Monhoc.Visible = true;
                cardXemdiem_Mon.Visible = true;
                listDiemTongKetHK.Visible = false;
                cardXemdiem_Tongket.Visible = false;
            }

            // Nội quy
            if (e.TabPageIndex == 6)
            {
                cardTT_VP.Visible = true;
                cardHL_HK.Visible = false;
            }

        }

        // Lớp học
        private void btnThemlop_Click_1(object sender, EventArgs e)
        {
            ThemLop a = new ThemLop();
            a.Show();
        }

        private void btnSualop_Click(object sender, EventArgs e)
        {
            SuaLop a = new SuaLop();
            a.Show();
        }

        // Kết quả
        private void tabDiemMon_Click(object sender, EventArgs e)
        {
            listDiem_Monhoc.Visible = true;
            cardXemdiem_Mon.Visible = true;
            listDiemTongKetHK.Visible = false;
            cardXemdiem_Tongket.Visible = false;
            listDiemTongketCN.Visible = false;
        }
        private void tabDiemTongKet_Click(object sender, EventArgs e)
        {
            cardXemdiem_Mon.Visible = false;
            cardXemdiem_Tongket.Visible = true;
            listDiem_Monhoc.Visible = false;
            listDiemTongKetHK.Visible = true;
            listDiemTongketCN.Visible = false;
            labelHocKy.Visible = true;
            labelCanam.Visible = false;
            cbLop_Tongket.Visible = true;
            cbNamhoc_Tongket.Visible = true;
            cbHocky_Tongket.Visible = true;
            btnLoadlistDiemTongketHK.Visible = true;
            btnLoadlistDiemTongketCN.Visible = false;
        }
        private void btnTongketHK_Click(object sender, EventArgs e)
        {
            labelHocKy.Visible = true;
            labelCanam.Visible = false;
            cbLop_Tongket.Visible = true;
            cbNamhoc_Tongket.Visible = true;
            cbHocky_Tongket.Visible = true;
            btnLoadlistDiemTongketHK.Visible = true;
            btnLoadlistDiemTongketCN.Visible = false;
        }
        private void btnTongketCN_Click(object sender, EventArgs e)
        {
            labelHocKy.Visible = false;
            labelCanam.Visible = true;
            cbLop_Tongket.Visible = true;
            cbNamhoc_Tongket.Visible = true;
            btnLoadlistDiemTongketCN.Visible = true;
            btnLoadlistDiemTongketHK.Visible = false;
            cbHocky_Tongket.Visible = false;
        }

        private void btnLoadlistDiemTongketCN_Click(object sender, EventArgs e)
        {
            listDiemTongketCN.Visible = true;
            listDiemTongKetHK.Visible = false;

        }

        private void btnLoadlistDiemTongketHK_Click(object sender, EventArgs e)
        {
            listDiemTongketCN.Visible = false;
            listDiemTongKetHK.Visible = true;
        }

        private void btnSuaKQ_Click(object sender, EventArgs e)
        {
            if (listDiem_Monhoc.Visible == true)
            {
                if (listDiem_Monhoc.SelectedItems.Count > 0)
                {

                    string maHocSinh = listDiem_Monhoc.SelectedItems[0].SubItems[0].Text;
                    SuaDiemMon a = new SuaDiemMon(maHocSinh);
                    a.Show();
                    LoadDataTableDiemMon();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một học sinh để sửa.");
                }
            }
            if (listDiemTongKetHK.Visible == true)
            {
                SuaDiemTongKet a = new SuaDiemTongKet();
                a.Show();
            }
            if (listDiemTongketCN.Visible == true)
            {
                SuaDiemTongKet a = new SuaDiemTongKet();
                a.Show();
            }
        }

        // Giáo viên
        private void tabGiaovien_Click(object sender, EventArgs e)
        {
            cardListGV.Visible = true;
            cardListPhancong.Visible = false;

        }

        private void tabPhancong_Click(object sender, EventArgs e)
        {
            cardListPhancong.Visible = true;
            cardListGV.Visible = false;

        }
        private void btnThemGV_Click(object sender, EventArgs e)
        {
            if (cardListGV.Visible == true)
            {
                ThemGV a = new ThemGV();
                a.Show();
            }
            else
            {
                ThemPhanCong a = new ThemPhanCong();
                a.Show();
            }
        }

        private void btnSuaGV_Click(object sender, EventArgs e)
        {
            if (cardListGV.Visible == true)
            {
                SuaGV a = new SuaGV();
                a.Show();
            }
            else
            {
                SuaPhanCong a = new SuaPhanCong();
                a.Show();
            }
        }



        // Học sinh
        private void tabPhanlop_Click(object sender, EventArgs e)
        {
            cardLopcu.Visible = true;
            cardLopmoi.Visible = true;
            cardAction_Phanlop.Visible = true;
            cardListHS.Visible = false;
            cardActionHS.Visible = false;
        }

        private void tabHS_Click(object sender, EventArgs e)
        {
            cardLopcu.Visible = false;
            cardLopmoi.Visible = false;
            cardAction_Phanlop.Visible = false;
            cardListHS.Visible = true;
            cardActionHS.Visible = true;
        }
        private void btnThemHS_Click(object sender, EventArgs e)
        {
            ThemHS themHSForm = new ThemHS();
            themHSForm.Show();
            LoadDataTableHocSinh();

        }

        private void btnSuaHS_Click(object sender, EventArgs e)
        {
            if (listHS.SelectedItems.Count > 0)
            {

                string maHocSinh = listHS.SelectedItems[0].SubItems[0].Text;
                SuaHS suaHSForm = new SuaHS(maHocSinh);
                suaHSForm.Show();
                LoadDataTableHocSinh();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một học sinh để sửa.");
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btnPhanlop.BackColor = Color.Teal;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnPhanlop.BackColor = Color.DarkSlateGray;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            btnLuu_Phanlop.BackColor = Color.Teal;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            btnLuu_Phanlop.BackColor = Color.DarkSlateGray;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string maNamHoc = cbNamhoc_Phanlop.SelectedValue.ToString();
            string maHocKy = cbHocky_Phanlop.SelectedValue.ToString();
            string maKhoiLop = cbKhoilop_Phanlop.SelectedValue.ToString();
            string maLop = cbLop_Phanlop.SelectedValue.ToString();

            List<HocSinhDTO> danhSachHocSinh = phanLopBLL.LayDanhSachHocSinh(maNamHoc, maHocKy, maKhoiLop, maLop);

            listPhanlop2.Items.Clear();
            foreach (var hocSinh in danhSachHocSinh)
            {
                ListViewItem item = new ListViewItem(hocSinh.MaHocSinh);
                item.SubItems.Add(hocSinh.HoTen);
                listPhanlop2.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string maNamHoc = cbNamhoc_Phanlop2.SelectedValue.ToString();
            string maHocKy = cbHocky_Phanlop2.SelectedValue.ToString();
            string maKhoiLop = cbKhoilop_Phanlop2.SelectedValue.ToString();
            string maLop = cbLop_Phanlop2.SelectedValue.ToString();

            List<string> maHocSinhList = new List<string>();
            foreach (ListViewItem item in listPhanlop2.SelectedItems)
            {
                maHocSinhList.Add(item.Text);
            }

            if (maHocSinhList.Count > 0)
            {
                phanLopBLL.CapNhatPhanLop(maHocSinhList, maNamHoc, maHocKy, maKhoiLop, maLop);
                MessageBox.Show("Cập nhật phân lớp thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật phân lớp thất bại!");
            }
        }


        // Nội quy
        private void btnThemTT_Click(object sender, EventArgs e)
        {
            ThemTT a = new ThemTT();
            a.Show();
        }

        private void btnThemVP_Click(object sender, EventArgs e)
        {
            ThemVP a = new ThemVP();
            a.Show();
        }

        private void tabTT_VP_Click(object sender, EventArgs e)
        {
            cardTT_VP.Visible = true;
            cardHL_HK.Visible = false;
        }

        private void tabHL_HK_Click(object sender, EventArgs e)
        {
            cardHL_HK.Visible = true;
            cardTT_VP.Visible = false;
        }

        private void btnThemHL_Click(object sender, EventArgs e)
        {
            ThemHocLuc a = new ThemHocLuc();
            a.Show();
        }

        private void btnThemHK_Click(object sender, EventArgs e)
        {
            ThemHanhKiem a = new ThemHanhKiem();
            a.Show();
        }

        private void btnQLHS_Click(object sender, EventArgs e)
        {
            this.materialTabControl1.SelectedTab = this.materialTabControl1.TabPages[3];
        }

        private void btnQLDiem_Click(object sender, EventArgs e)
        {
            this.materialTabControl1.SelectedTab = this.materialTabControl1.TabPages[4];
        }

        private void btnQLGV_Click(object sender, EventArgs e)
        {
            this.materialTabControl1.SelectedTab = this.materialTabControl1.TabPages[2];
        }

        private void btnQLThongKe_Click(object sender, EventArgs e)
        {
            this.materialTabControl1.SelectedTab = this.materialTabControl1.TabPages[6];
        }

        private void listHS_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaHS_Click(object sender, EventArgs e)
        {
            if (listHS.SelectedItems.Count > 0)
            {
                string maHocSinh = listHS.SelectedItems[0].SubItems[0].Text;

                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa học sinh mã " + maHocSinh + " không?",
                                                     "Xác nhận xóa",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    if (hocSinhBLL.DeleteHocSinh(maHocSinh))
                    {
                        MessageBox.Show("Xóa học sinh mã " + maHocSinh + " thành công!");
                        LoadDataTableHocSinh();
                    }
                    else
                    {
                        MessageBox.Show("Xóa học sinh mã " + maHocSinh + " thất bại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một học sinh để xóa.");
            }
        }

        private void btnLoadListHS_Click(object sender, EventArgs e)
        {
            LoadDataTableHocSinh();
        }

        private void txTimkiemHS_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimkiemHS_Click(object sender, EventArgs e)
        {
            string searchTerm = txTimkiemHS.Text.Trim();
            var results = hocSinhBLL.SearchHocSinh(searchTerm);

            listHS.Items.Clear();

            if (results.Count > 0)
            {
                foreach (var hocSinh in results)
                {
                    ListViewItem item = new ListViewItem(hocSinh.MaHocSinh);
                    item.SubItems.Add(hocSinh.HoTen);
                    item.SubItems.Add(hocSinh.GioiTinh == 0 ? "Nam" : "Nữ");
                    item.SubItems.Add(hocSinh.NgaySinh.ToShortDateString());
                    item.SubItems.Add(hocSinh.DiaChi);
                    item.SubItems.Add(hocSinh.MaDanToc);
                    item.SubItems.Add(hocSinh.MaTonGiao);
                    item.SubItems.Add(hocSinh.HoTenCha);
                    item.SubItems.Add(hocSinh.MaNgheCha);
                    item.SubItems.Add(hocSinh.HoTenMe);
                    item.SubItems.Add(hocSinh.MaNgheMe);
                    item.SubItems.Add(hocSinh.Email);

                    listHS.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy học sinh nào khớp với yêu cầu tìm kiếm.");
            }
        }

        private void cbNamhoc_Phanlop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void search_ThongTinPhanLop_Click(object sender, EventArgs e)
        {
            string maNamHoc = cbNamhoc_Phanlop.SelectedValue.ToString();
            string maHocKy = cbHocky_Phanlop.SelectedValue.ToString();
            string maKhoiLop = cbKhoilop_Phanlop.SelectedValue.ToString();
            string maLop = cbLop_Phanlop.SelectedValue.ToString();

            List<HocSinhDTO> danhSachHocSinh = phanLopBLL.LayDanhSachHocSinh(maNamHoc, maHocKy, maKhoiLop, maLop);

            listPhanlop.Items.Clear();
            foreach (var hocSinh in danhSachHocSinh)
            {
                ListViewItem item = new ListViewItem(hocSinh.MaHocSinh);
                item.SubItems.Add(hocSinh.HoTen);  
                listPhanlop.Items.Add(item);
            }
        }

        private void btnLoadListKQ_Click(object sender, EventArgs e)
        {
            LoadDataTableDiemMon();
        }

        private void btnTimkiemKQ_Click(object sender, EventArgs e)
        {
            string searchTerm = txTimkiemKQ.Text.Trim();
            var results = diemMonBLL.SearchDiemMon(searchTerm);

            listDiem_Monhoc.Items.Clear();

            if (results.Count > 0)
            {
                foreach (var dm in results)
                {
                    ListViewItem item = new ListViewItem(dm.MaHocSinh);
                    item.SubItems.Add(dm.TenHocSinh);
                    item.SubItems.Add(dm.DiemMiengTB.ToString());
                    item.SubItems.Add(dm.Diem15PhutTB.ToString());
                    item.SubItems.Add(dm.Diem45PhutTB.ToString());
                    item.SubItems.Add(dm.DiemThi.ToString());
                    item.SubItems.Add(dm.DiemTBHK.ToString());

                    listDiem_Monhoc.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy học sinh nào khớp với yêu cầu tìm kiếm.");
            }
        }

        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileInfo = new FileInfo(openFileDialog.FileName);
                    using (var package = new ExcelPackage(fileInfo))
                    {
                        // Lấy worksheet đầu tiên
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.First();

                        // Đảm bảo rằng worksheet có ít nhất một hàng
                        if (worksheet.Dimension == null || worksheet.Dimension.End.Row < 2)
                        {
                            MessageBox.Show("File Excel không có dữ liệu hợp lệ.");
                            return;
                        }

                        // Đọc dữ liệu từ hàng thứ 2 (giả sử hàng đầu tiên là tiêu đề)
                        for (int row = 2; row <= worksheet.Dimension.End.Row; row++) // Bắt đầu từ dòng 2
                        {
                            // Đọc dữ liệu từ các cột tương ứng
                            KQ_HocSinh_MonHocDTO diemMon = new KQ_HocSinh_MonHocDTO
                            {
                                MaHocSinh = worksheet.Cells[row, 1].Text,
                                MaLop = worksheet.Cells[row, 2].Text,
                                MaNamHoc = worksheet.Cells[row, 3].Text,
                                MaMonHoc = worksheet.Cells[row, 4].Text,
                                MaHocKy = worksheet.Cells[row, 5].Text,
                                DiemMiengTB = Convert.ToDouble(worksheet.Cells[row, 6].Text),
                                Diem15PhutTB = Convert.ToDouble(worksheet.Cells[row, 7].Text),
                                Diem45PhutTB = Convert.ToDouble(worksheet.Cells[row, 8].Text),
                                DiemThi = Convert.ToDouble(worksheet.Cells[row, 9].Text),
                                DiemTBHK = Convert.ToDouble(worksheet.Cells[row, 10].Text),

                            };
                            
                            if (diemMonBLL.AddDiemMon(diemMon))
                            {
                                MessageBox.Show("Thêm điểm môn học của học sinh có mã " + diemMon.MaHocSinh + " thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Thêm điểm môn học của học sinh có mã " + diemMon.MaHocSinh + " thất bại!");

                            }

                        }
                    }
                }
            }
        }

        private void cardXemdiem_Tongket_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShowDiem_Click(object sender, EventArgs e)
        {
            string maNamHoc = cbNamhoc_diem.SelectedValue.ToString();
            string maHocKy = cbHocky_diem.SelectedValue.ToString();
            string maMonHoc = cbMon_diem.SelectedValue.ToString();
            string maLop = cbLop_diem.SelectedValue.ToString();

            List<KQ_HocSinh_MonHocDTO> danhSachDiemMon = diemMonBLL.GetDiemMonByConditions(maMonHoc, maLop, maNamHoc, maHocKy);

            listDiem_Monhoc.Items.Clear();
            foreach (var dm in danhSachDiemMon)
            {
                ListViewItem item = new ListViewItem(dm.MaHocSinh);
                item.SubItems.Add(dm.TenHocSinh);
                item.SubItems.Add(dm.DiemMiengTB.ToString());
                item.SubItems.Add(dm.Diem15PhutTB.ToString());
                item.SubItems.Add(dm.Diem45PhutTB.ToString());
                item.SubItems.Add(dm.DiemThi.ToString());
                item.SubItems.Add(dm.DiemTBHK.ToString());

                listDiem_Monhoc.Items.Add(item);
            }
        }
    }
}
