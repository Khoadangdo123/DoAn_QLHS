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
using System.Runtime.CompilerServices;
using BLL;
using GUI_CSharp.DTO;
using OfficeOpenXml;
using System.IO;
using System.Windows.Input;
using DTO;



namespace GUI_CSharp
{
    public partial class Trangchu : MaterialForm
    {
        private HocSinhBLL hocSinhBLL = new HocSinhBLL();
        private PhanLopBLL phanLopBLL = new PhanLopBLL();
        private DiemMonBLL diemMonBLL = new DiemMonBLL();
        private GiaoVienBLL giaoVienBLL = new GiaoVienBLL();
        private PhanCongBLL phanCongBLL = new PhanCongBLL();
        private ThongKeKQBLL thongKeKQBLL = new ThongKeKQBLL();
        private ThongKeKQLopBLL thongKeKQLopBLL = new ThongKeKQLopBLL();
        private ThongKeHocSinhBLL thongKeHocSinhBLL = new ThongKeHocSinhBLL();
        private LopBLL lopBLL = new LopBLL();
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
            LoadThongKeHocSinh();
            LoadComboBoxData();
            LoadThongKeKQ_HS();
            LoadThongKeKQ_Lop();
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
        private void LoadGiaoVienList()
        {
            List<GiaoVienDTO> giaoVienList = giaoVienBLL.GetAllGiaoVien();
            listGV.Items.Clear();
            foreach (var gv in giaoVienList)
            {
                ListViewItem item = new ListViewItem(gv.MaGiaoVien);
                item.SubItems.Add(gv.TenGiaoVien);
                item.SubItems.Add(gv.DiaChi);
                item.SubItems.Add(gv.MaMonHoc);
                item.SubItems.Add(gv.DienThoai);
                listGV.Items.Add(item);
            }
        }
        private void LoadPhanCongList()
        {
            List<PhanCongDTO> phanCongList = phanCongBLL.GetAllPhanCong();
            listPhancong.Items.Clear();
            foreach (var pc in phanCongList)
            {

                string tenNamHoc = cbNamhoc_Phanlop.SelectedValue.ToString();
                string tenLop = phanLopBLL.LayDanhSachLop().FirstOrDefault(l => l.Key == pc.MaLop).Value;
                string tenMonHoc = diemMonBLL.LayDanhSachMonHoc().FirstOrDefault(mh => mh.Key == pc.MaMonHoc).Value;
                string tenGiaoVien = giaoVienBLL.GetAllGiaoVien().FirstOrDefault(gv => gv.MaGiaoVien == pc.MaGiaoVien).TenGiaoVien;

                ListViewItem item = new ListViewItem(pc.STT.ToString());
                item.SubItems.Add(tenNamHoc);
                item.SubItems.Add(tenLop);
                item.SubItems.Add(tenMonHoc);
                item.SubItems.Add(tenGiaoVien);
                listPhancong.Items.Add(item);
            }
        }

        // Hàm Load danh sách thống kê học sinh
        private void LoadThongKeHocSinh()
        {
            List<ThongKeHocSinhDTO> thongKeHocSinhList = thongKeHocSinhBLL.GetThongKeHocSinh();
            DisplayHocSinhList(thongKeHocSinhList);
        }

        private void DisplayHocSinhList(List<ThongKeHocSinhDTO> thongKeHocSinhList)
        {
            listTKHS.Items.Clear();

            foreach (var hs in thongKeHocSinhList)
            {
                var listViewItem = new ListViewItem(hs.STT.ToString());
                listViewItem.SubItems.Add(hs.MaHS);
                listViewItem.SubItems.Add(hs.TenHS);
                listViewItem.SubItems.Add(hs.NgaySinh.ToString("dd/MM/yyyy"));
                listViewItem.SubItems.Add(hs.GioiTinh == 0 ? "Nam" : "Nữ");
                listViewItem.SubItems.Add(hs.Khoi);
                listViewItem.SubItems.Add(hs.Lop);
                listViewItem.SubItems.Add(hs.NamHoc);

                listTKHS.Items.Add(listViewItem);
            }
        }

        // Hàm load Danh sách tổng kết kết quả của học sinh
        private void LoadThongKeKQ_HS()
        {
            List<ThongKeKQDTO> thongKeKQList = thongKeKQBLL.GetThongKeKQ_HS();
            DisplayKQList(thongKeKQList);
        }

        private void DisplayKQList(List<ThongKeKQDTO> thongKeKQList)
        {
            listTKKQ_HS.Items.Clear();

            foreach (var kq in thongKeKQList)
            {
                var listViewItem = new ListViewItem(kq.STT.ToString());
                listViewItem.SubItems.Add(kq.MaHocSinh);
                listViewItem.SubItems.Add(kq.HoTen);
                listViewItem.SubItems.Add(kq.Lop);
                listViewItem.SubItems.Add(kq.NamHoc);
                listViewItem.SubItems.Add(kq.KetQua);

                listTKKQ_HS.Items.Add(listViewItem);
            }
        }

        // Hàm load danh sách thống kê kết quả lớp
        private void LoadThongKeKQ_Lop()
        {
            List<ThongKeKQLopDTO> thongKeKQList = thongKeKQLopBLL.GetThongKeKQ_Lop();
            DisplayKQList_Lop(thongKeKQList);
        }

        private void DisplayKQList_Lop(List<ThongKeKQLopDTO> thongKeKQList)
        {
            listTKKQ_Lop.Items.Clear();

            foreach (var kq in thongKeKQList)
            {
                var listViewItem = new ListViewItem(kq.STT.ToString());
                listViewItem.SubItems.Add(kq.Lop);
                listViewItem.SubItems.Add(kq.Khoi);
                listViewItem.SubItems.Add(kq.NamHoc);
                listViewItem.SubItems.Add(kq.LenLop.ToString());
                listViewItem.SubItems.Add(kq.ThiLai.ToString());
                listViewItem.SubItems.Add(kq.RenLuyenHe.ToString());
                listViewItem.SubItems.Add(kq.OLai.ToString());

                listTKKQ_Lop.Items.Add(listViewItem);
            }
        }

        // Lọc DS thống kê từ năm học và lớp
        private void btnHienThiDSTKHS_Click(object sender, EventArgs e)
        {
            string lop = cbLop_TKHS.SelectedItem?.ToString();
            string namhoc = cbNamhoc_TKHS.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(lop) && string.IsNullOrEmpty(namhoc))
            {
                MessageBox.Show("Vui lòng chọn trường thông tin cần xem", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                List<ThongKeHocSinhDTO> thongKeHocSinhList = thongKeHocSinhBLL.FilterHocSinh(lop, namhoc);

                if (thongKeHocSinhList.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DisplayHocSinhList(thongKeHocSinhList);
                }
                cbLop_TKHS.SelectedItem = null;
                cbNamhoc_TKHS.SelectedItem = null;
            }
        }

        // lọc ds thống kê kết quả học sinh từ lớp và năm học
        private void btnHienthi_TKKQ_HS_Click(object sender, EventArgs e)
        {
            string lop = cbLop_TKKQ_HS.SelectedItem?.ToString();
            string namhoc = cbNamhoc_TKKQ_HS.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(lop) && string.IsNullOrEmpty(namhoc))
            {
                MessageBox.Show("Vui lòng chọn trường thông tin cần xem", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                List<ThongKeKQDTO> thongKeKQList = thongKeKQBLL.FilterTKKQ_HS(lop, namhoc);
                if (thongKeKQList.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DisplayKQList(thongKeKQList);
                }
                cbLop_TKKQ_HS.SelectedItem = null;
                cbNamhoc_TKKQ_HS.SelectedItem = null;
            }
        }

        // lọc ds thống kê kết quả lớp từ lớp và năm học
        private void btnHienthi_TKKQ_Lop_Click(object sender, EventArgs e)
        {
            string lop = cbLop_TKKQ_Lop.SelectedItem?.ToString();
            string namhoc = cbNamhoc_TKKQ_Lop.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(lop) || string.IsNullOrEmpty(namhoc))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin cần xem", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                List<ThongKeKQLopDTO> thongKeKQListLop = thongKeKQLopBLL.FilterTKKQ_Lop(lop, namhoc);
                if (thongKeKQListLop.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DisplayKQList_Lop(thongKeKQListLop);
                }
                cbLop_TKKQ_Lop.SelectedItem = null;
                cbNamhoc_TKKQ_Lop.SelectedItem = null;
            }
        }

        // get dữ liệu cho combobox
        private void LoadComboBoxData()
        {
            List<string> khoiList = lopBLL.GetKhoiList();
            List<string> lopList = lopBLL.GetLopList();
            List<string> namhocList = lopBLL.GetNamhocList();

            cbLop_TKHS.Items.Clear();
            cbNamhoc_TKHS.Items.Clear();

            cbLop_TKKQ_HS.Items.Clear();
            cbNamhoc_TKKQ_HS.Items.Clear();

            cbLop_TKKQ_Lop.Items.Clear();
            cbNamhoc_TKKQ_Lop.Items.Clear();

            cbLop_TKHS.Items.AddRange(lopList.Distinct().ToArray());
            cbNamhoc_TKHS.Items.AddRange(namhocList.ToArray());

            cbLop_TKKQ_HS.Items.AddRange(lopList.Distinct().ToArray());
            cbNamhoc_TKKQ_HS.Items.AddRange(namhocList.ToArray());

            cbLop_TKKQ_Lop.Items.AddRange(lopList.Distinct().ToArray());
            cbNamhoc_TKKQ_Lop.Items.AddRange(namhocList.ToArray());
        }

        // Tìm kiếm DS thống kê học sinh
        private void btnTimkiemTKHS_Click(object sender, EventArgs e)
        {
            string keyword = txTimkiemTKHS.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                List<ThongKeHocSinhDTO> thongKeHocSinhList = thongKeHocSinhBLL.SearchHocSinh(keyword);

                if (thongKeHocSinhList.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DisplayHocSinhList(thongKeHocSinhList);
                }
                txTimkiemTKHS.Text = "";
            }
        }

        // tìm kiếm thống kê kết quả học sinh
        private void btnTimkiem_TKKQ_HS_Click(object sender, EventArgs e)
        {
            string keyword = txTimkiem_TKKQ_HS.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                List<ThongKeKQDTO> thongKeKQList = thongKeKQBLL.TimKiemThongKeKQ_HS(keyword);

                if (thongKeKQList.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DisplayKQList(thongKeKQList);
                }
                txTimkiem_TKKQ_HS.Text = "";
            }
        }

        // Btn Load danh sách thống kê học sinh
        private void btnLoadListTKHS_Click(object sender, EventArgs e)
        {
            LoadThongKeHocSinh();
        }
        // Btn Load danh sách thống kê kết quả học sinh
        private void btnLoad_TKKQ_HS_Click(object sender, EventArgs e)
        {
            LoadThongKeKQ_HS();
        }
        // btn load danh sách thống kê kết quả lớp
        private void btnLoad_TKKQ_Lop_Click(object sender, EventArgs e)
        {
            LoadThongKeKQ_Lop();
        }

        // xuất excel thống kê kết quả lớp
        private void btnXuatExcel_TKKQ_Lop_Click(object sender, EventArgs e)
        {
            List<ThongKeKQLopDTO> thongKeKQList = thongKeKQLopBLL.GetThongKeKQ_Lop();
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Save an Excel File";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    thongKeKQLopBLL.ExportToExcel(thongKeKQList, filePath);
                    MessageBox.Show("Xuất thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Xuất excel thống kê học sinh
        private void btnXuatExcel_TKHS_Click(object sender, EventArgs e)
        {
            List<ThongKeHocSinhDTO> thongKeHocSinhList = thongKeHocSinhBLL.GetThongKeHocSinh();

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Save an Excel File";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    thongKeHocSinhBLL.ExportToExcel(thongKeHocSinhList, filePath);
                    MessageBox.Show("Xuất thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnXuatExcel_TKKQ_HS_Click(object sender, EventArgs e)
        {
            List<ThongKeKQDTO> thongKeKQList = thongKeKQBLL.GetThongKeKQ_HS();
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Save an Excel File";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    thongKeKQBLL.ExportToExcel(thongKeKQList, filePath);
                    MessageBox.Show("Xuất thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void MaterialTabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 7)
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

            // Kết quả học tập
            if (e.TabPageIndex == 4)
            {

            }

            // Nội quy
            if (e.TabPageIndex == 5)
            {

            }

            // Thống kê
            if (e.TabPageIndex == 6)
            {
                listTKKQ_HS.Visible = false;
                listTKHS.Visible = true;
                cardActionTKHS.Visible = true;
                cardActionTKKQ.Visible = false;
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
            LoadGiaoVienList();

        }

        private void tabPhancong_Click(object sender, EventArgs e)
        {
            cardListPhancong.Visible = true;
            cardListGV.Visible = false;
            LoadPhanCongList();

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
            if (listGV.SelectedItems.Count > 0)
            {
                EditGiaoVien();
            }
            else if (listPhancong.SelectedItems.Count > 0)
            {
                EditPhanCong();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một giáo viên hoặc một phân công để sửa.");
            }
        }

        private void EditGiaoVien()
        {
            string maGiaoVien = listGV.SelectedItems[0].SubItems[0].Text;
            SuaGV suaGVForm = new SuaGV(maGiaoVien);
            suaGVForm.Show();
            LoadGiaoVienList();
        }

        private void EditPhanCong()
        {
            string sttString = listPhancong.SelectedItems[0].SubItems[0].Text; // Assuming the STT is in the first subitem
            int stt;
            if (int.TryParse(sttString, out stt))
            {
                SuaPhanCong suaPhanCongForm = new SuaPhanCong(stt);
                suaPhanCongForm.Show();
                LoadPhanCongList();
            }
            else
            {
                MessageBox.Show("STT không hợp lệ.");
            }
        }

        private void btnLoadListGV_Click(object sender, EventArgs e)
        {
            LoadGiaoVienList();
        }
        private void btnLoadListPhanCong_Click(object sender, EventArgs e)
        {
            LoadPhanCongList();
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

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            if (listGV.SelectedItems.Count > 0)
            {
                DeleteGiaoVien();
            }
            else if (listPhancong.SelectedItems.Count > 0)
            {
                DeletePhanCong();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một giáo viên hoặc một phân công để xóa.");
            }
        }

        private void DeleteGiaoVien()
        {
            string maGiaoVien = listGV.SelectedItems[0].SubItems[0].Text;
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa giáo viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bool isDeleted = giaoVienBLL.DeleteGiaoVien(maGiaoVien);
                if (isDeleted)
                {
                    MessageBox.Show("Xóa giáo viên thành công.");
                    LoadGiaoVienList();
                }
                else
                {
                    MessageBox.Show("Xóa giáo viên thất bại.");
                }
            }
        }
        private void btnTimkiemGV_Click(object sender, EventArgs e)
        {
            string searchTerm = txTimkiemGV.Text.Trim();
            var results = giaoVienBLL.SearchGiaoVien(searchTerm);

            listGV.Items.Clear();

            if (results.Count > 0)
            {
                foreach (var giaoVien in results)
                {
                    ListViewItem item = new ListViewItem(giaoVien.MaGiaoVien);
                    item.SubItems.Add(giaoVien.TenGiaoVien);
                    item.SubItems.Add(giaoVien.DiaChi);
                    item.SubItems.Add(giaoVien.DienThoai);
                    item.SubItems.Add(giaoVien.MaMonHoc);

                    listGV.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy giáo viên nào khớp với yêu cầu tìm kiếm.");
            }
        }
        //private void btnTimkiemPC_Click(object sender, EventArgs e)
        //{
        //    string searchTerm = txTimkiemGV.Text.Trim();
        //    var results = phanCongBLL.SearchPhanCong(searchTerm);

        //    listPhancong.Items.Clear();

        //    if (results.Count > 0)
        //    {
        //        foreach (var phanCong in results)
        //        {
        //            ListViewItem item = new ListViewItem(phanCong.MaGiaoVien);
        //            item.SubItems.Add(phanCong.MaNamHoc);
        //            item.SubItems.Add(phanCong.MaLop);
        //            item.SubItems.Add(phanCong.MaMonHoc);

        //            listPhancong.Items.Add(item);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Không tìm thấy phân công nào khớp với yêu cầu tìm kiếm.");
        //    }
        //}



        private void DeletePhanCong()
        {
            string sttString = listPhancong.SelectedItems[0].SubItems[0].Text; // Assuming the STT is in the first subitem
            int stt;
            if (int.TryParse(sttString, out stt))
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa phân công này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool isDeleted = phanCongBLL.DeletePhanCong(stt);
                    if (isDeleted)
                    {
                        MessageBox.Show("Xóa phân công thành công.");
                        LoadPhanCongList();
                    }
                    else
                    {
                        MessageBox.Show("Xóa phân công thất bại.");
                    }
                }
            }
            else
            {
                MessageBox.Show("STT không hợp lệ.");
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

        private void tabThongkeHS_Click(object sender, EventArgs e)
        {
            listTKKQ_HS.Visible = false;
            listTKHS.Visible = true;
            cardActionTKHS.Visible = true;
            cardActionTKKQ.Visible = false;
        }

        private void tabThongkeKQ_Click(object sender, EventArgs e)
        {
            listTKKQ_HS.Visible = true;
            listTKHS.Visible = false;
            cardActionTKHS.Visible = false;
            cardActionTKKQ.Visible = true;

            txTimkiem_TKKQ_HS.Visible = true;
            btnTimkiem_TKKQ_HS.Visible = true;
            btnLoad_TKKQ_HS.Visible = true;
            cbLop_TKKQ_HS.Visible = true;
            cbNamhoc_TKKQ_HS.Visible = true;
            btnHienthi_TKKQ_HS.Visible = true;
            btnXuatExcel_TKKQ_HS.Visible = true;
            listTKKQ_HS.Visible = true;

            btnLoad_TKKQ_Lop.Visible = false;
            cbLop_TKKQ_Lop.Visible = false;
            cbNamhoc_TKKQ_Lop.Visible = false;
            btnHienthi_TKKQ_Lop.Visible = false;
            btnXuatExcel_TKKQ_Lop.Visible = false;
            listTKKQ_Lop.Visible = false;
        }

        private void tabTKKQ_HS_Click(object sender, EventArgs e)
        {
            txTimkiem_TKKQ_HS.Visible = true;
            btnTimkiem_TKKQ_HS.Visible = true;
            btnLoad_TKKQ_HS.Visible = true;
            cbLop_TKKQ_HS.Visible = true;
            cbNamhoc_TKKQ_HS.Visible = true;
            btnHienthi_TKKQ_HS.Visible = true;
            btnXuatExcel_TKKQ_HS.Visible = true;
            listTKKQ_HS.Visible = true;

            btnLoad_TKKQ_Lop.Visible = false;
            cbLop_TKKQ_Lop.Visible = false;
            cbNamhoc_TKKQ_Lop.Visible = false;
            btnHienthi_TKKQ_Lop.Visible = false;
            btnXuatExcel_TKKQ_Lop.Visible =false;
            listTKKQ_Lop.Visible = false;
        }

        private void tabTKKQ_KhoiLop_Click(object sender, EventArgs e)
        {
            txTimkiem_TKKQ_HS.Visible = false;
            btnTimkiem_TKKQ_HS.Visible = false;
            btnLoad_TKKQ_HS.Visible = false;
            cbLop_TKKQ_HS.Visible = false;
            cbNamhoc_TKKQ_HS.Visible = false;
            btnHienthi_TKKQ_HS.Visible = false;
            btnXuatExcel_TKKQ_HS.Visible = false;
            listTKKQ_HS.Visible = false;

            btnLoad_TKKQ_Lop.Visible = true;
            cbLop_TKKQ_Lop.Visible = true;
            cbNamhoc_TKKQ_Lop.Visible = true;
            btnHienthi_TKKQ_Lop.Visible = true;
            btnXuatExcel_TKKQ_Lop.Visible = true;
            listTKKQ_Lop.Visible = true;

        }

        
    }
}
