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

namespace GUI_CSharp
{
    public partial class Trangchu : MaterialForm
    {
        public Trangchu()
        {
            InitializeComponent();
            this.materialTabControl1.Selected += new TabControlEventHandler(this.MaterialTabControl_Selected);
            generate_ListTKB();
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
                //ThemPhanCong a = new ThemPhanCong();
                ThemPhanCong_mul a = new ThemPhanCong_mul();
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

        private void listTKB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void generate_ListTKB()
        {
            // Đặt thuộc tính của ListView
            listTKB.View = View.Details;
            listTKB.FullRowSelect = true;
            listTKB.GridLines = true;

            // Thêm các cột vào ListView, đảm bảo rằng ListView đã có 7 cột (Thứ 2 - Chủ Nhật)
            string[] columns = { "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7", "Chủ Nhật" };
            foreach (string columnName in columns)
            {
                listTKB.Columns.Add(columnName, -2, HorizontalAlignment.Center);
            }

            // Thêm 11 dòng vào ListView
            for (int i = 1; i <= 11; i++)
            {
                // Cột đầu tiên luôn chứa số từ 1 đến 11
                ListViewItem item = new ListViewItem(i.ToString());

                // Thêm dữ liệu cho các cột còn lại
                for (int j = 1; j < columns.Length; j++)
                {
                    if (i == 6)
                    {
                        item.SubItems.Add(" "); // Nếu là dòng thứ 6 thì để trống
                    }
                    else
                    {
                        item.SubItems.Add(i.ToString()); // Thêm số vào các cột còn lại
                    }
                }
                listTKB.Items.Add(item); // Thêm dòng vào listTKB
            }
        }

    }
}
