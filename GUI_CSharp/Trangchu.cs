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

namespace GUI_CSharp
{
    public partial class Trangchu : MaterialForm
    {
        private HocSinhBLL hocSinhBLL = new HocSinhBLL();
        private PhanLopBLL phanLopBLL = new PhanLopBLL();
        public Trangchu()
        {
            InitializeComponent();
            this.materialTabControl1.Selected += new TabControlEventHandler(this.MaterialTabControl_Selected);
            LoadDataTableHocSinh();
            LoadDanhSachNamHoc();
            LoadDanhSachHocKy();
            LoadDanhSachKhoiLop();
            LoadDanhSachLop();
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
                SuaDiemMon a = new SuaDiemMon();
                a.Show();
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
    }
}
