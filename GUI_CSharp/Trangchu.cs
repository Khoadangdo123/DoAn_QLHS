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
using Org.BouncyCastle.Math.Field;

namespace GUI_CSharp
{
    public partial class Trangchu : MaterialForm
    {
        String MaLoaiNguoiDungBtn = null;
        QuanLyLopHocBLL quanLyLopHocBLL = new QuanLyLopHocBLL();

        public Trangchu(String MaLoaiNguoiDung, String MaNguoiDung, String TenNguoiDung)
        {
            InitializeComponent();

            List<string> results = quanLyLopHocBLL.getDataListLopHoc();
            LoadDataToMaterialListView(results);
            this.materialTabControl1.Selected += new TabControlEventHandler(this.MaterialTabControl_Selected);
            label10.Text = TenNguoiDung;
            if (MaLoaiNguoiDung == "LND002")
            {
                this.materialTabControl1.Controls.Remove(tabPage4);
                MaLoaiNguoiDungBtn = "LND002";
                tabGiaovien.Visible = false;
            } else if (MaLoaiNguoiDung == "LND001")
            {

            } else if (MaLoaiNguoiDung == "LND003")
            {

            } else
            {

            }

        }

        public void LoadDataToMaterialListView(List<string> dataList)
        {
            listLop.Items.Clear();

            foreach (string item in dataList)
            {
                // Tách các thuộc tính bằng dấu phẩy
                string[] parts = item.Split(',');

                // Tạo một ListViewItem với giá trị đầu tiên (Mã Lớp)
                ListViewItem listViewItem = new ListViewItem(parts[0].Trim());

                // Thêm các giá trị tiếp theo vào subitems (Tên Lớp và Sĩ Số)
                listViewItem.SubItems.Add(parts[1].Trim());
                listViewItem.SubItems.Add(parts[2].Trim());
                listViewItem.SubItems.Add(parts[3].Trim());
                listViewItem.SubItems.Add(parts[4].Trim());
                listViewItem.SubItems.Add(parts[5].Trim());
                listViewItem.SubItems.Add(parts[6].Trim());
                // Thêm ListViewItem vào MaterialListView
                listLop.Items.Add(listViewItem);
            }
        }

        public void MaterialTabControl_Selected(object sender, TabControlEventArgs e)
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
                if (MaLoaiNguoiDungBtn == "LND002")
                {
                    cardListGV.Visible = false;
                    cardListPhancong.Visible = true;
                    //btnThemGV.Visible = false;
                    //btnXoaGV.Visible = false;
                    //btnSuaGV.Visible = false;
                    //btnLoadListGV.Visible = false;
                    //txTimkiemGV.Visible = false;
                    //btnTimkiemGV.Visible = false;

                } else
                {
                    cardListGV.Visible = true;
                    cardListPhancong.Visible = false;
                }
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

            if (listLop.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listLop.SelectedItems[0];

                string maLop = selectedItem.SubItems[0].Text;
                string tenLop = selectedItem.SubItems[1].Text;
                string khoiLop = selectedItem.SubItems[2].Text;
                string siSo = selectedItem.SubItems[3].Text;
                string namHoc = selectedItem.SubItems[4].Text;
                string giaoVien = selectedItem.SubItems[5].Text;
                string hocKy = selectedItem.SubItems[6].Text;


                SuaLop suaData = new SuaLop(
                        maLop, tenLop,
                        khoiLop, siSo,
                        namHoc, giaoVien,
                        hocKy
                    );

                suaData.Show();
            }
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
            ThemHS a = new ThemHS();
            a.Show();
        }

        private void btnSuaHS_Click(object sender, EventArgs e)
        {
            SuaHS a = new SuaHS();
            a.Show();
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

        }

        private void button2_Click(object sender, EventArgs e)
        {

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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.materialTabControl1.SelectedTab = this.materialTabControl1.TabPages[0];
        }

        private void dangxuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Dangnhap dn = new Dangnhap();
                dn.Show();
                dn.FormClosed += (s, args) => this.Close();
            } else
            {

            }
            
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void listLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listLop.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listLop.SelectedItems[0];

                string maLop = selectedItem.SubItems[0].Text;
                string tenLop = selectedItem.SubItems[1].Text;
                string khoiLop = selectedItem.SubItems[2].Text;
                int siSo = int.Parse(selectedItem.SubItems[3].Text);
                string namHoc = selectedItem.SubItems[4].Text;
                string giaoVien = selectedItem.SubItems[5].Text;
                string hocKy = selectedItem.SubItems[6].Text;


                //SuaLop suaData = new SuaLop(
                //        maLop, tenLop,
                //        khoiLop, siSo,
                //        namHoc, giaoVien,
                //        hocKy
                //    );
            }
        }

        private void btnXoalop_Click(object sender, EventArgs e)
        {
            if (listLop.SelectedItems.Count > 0)
            {
                string maLop = listLop.SelectedItems[0].Text;
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng đã chọn?",
                                            "Xác nhận xóa",
                                            MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    // Xóa dòng trong cơ sở dữ liệu
                    QuanLyLopHocBLL dataService = new QuanLyLopHocBLL();
                    dataService.deleteListLopHoc(maLop);

                    // Làm mới dữ liệu trong MaterialListView
                    List<string> results = quanLyLopHocBLL.getDataListLopHoc();
                    LoadDataToMaterialListView(results);
                }

            }
        }

        private void txTimkiemLop_TextChanged(object sender, EventArgs e)
        {
            SearchListDanhSachLop(txTimkiemLop.Text);
        }

        private void SearchListDanhSachLop(string keyword)
        {
            listLop.Items.Clear();
            List<string> results = quanLyLopHocBLL.getDataListLopHoc();
            LoadDataToMaterialListView(results);

            if (!string.IsNullOrWhiteSpace(keyword)) { 
                keyword = keyword.ToLower();
                foreach (ListViewItem item in listLop.Items)
                {
                    bool itemMatched = false;
                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        // Kiểm tra nếu từ khóa xuất hiện trong subitem
                        if (subItem.Text.ToLower().Contains(keyword))
                        {
                            itemMatched = true;
                            break;
                        }
                    }

                    if (!itemMatched) {
                        item.Remove();
                    }
                }
            }
        }

        private void btnTimkiemLop_Click(object sender, EventArgs e)
        {
            SearchListDanhSachLop(txTimkiemLop.Text);
        }

        private void btnLoadListLop_Click(object sender, EventArgs e)
        {
            List<string> results = quanLyLopHocBLL.getDataListLopHoc();
            LoadDataToMaterialListView(results);
        }
    }
}
