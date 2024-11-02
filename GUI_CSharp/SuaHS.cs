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
    public partial class SuaHS : MaterialForm
    {
        private HocSinhBLL hocSinhBLL = new HocSinhBLL();
        private DanTocBLL danTocBLL = new DanTocBLL();
        private TonGiaoBLL tonGiaoBLL = new TonGiaoBLL();
        private NgheNghiepBLL ngheNghiepBLL = new NgheNghiepBLL();
        public SuaHS(string maHocSinh)
        {
            InitializeComponent();
            LoadDanhSachDanToc();
            LoadDanhSachTonGiao();
            LoadDanhNgheNghiep();
            LoadHocSinhByMa(maHocSinh);
        }

        private void LoadHocSinhByMa(string maHocSinh)
        {
            HocSinhDTO hocSinh = hocSinhBLL.GetHocSinhByMa(maHocSinh);

            if (hocSinh != null)
            {
                txMaHS.Text = hocSinh.MaHocSinh;
                txTenHS.Text = hocSinh.HoTen;
                gioiTinh_nam.Checked = hocSinh.GioiTinh == 0;
                gioiTinh_nu.Checked = hocSinh.GioiTinh == 1;
                ngaySinh_HS.Value = hocSinh.NgaySinh;
                txDiachi_HS.Text = hocSinh.DiaChi;
                cbDantoc.SelectedValue = hocSinh.MaDanToc;
                cbTongiao.SelectedValue = hocSinh.MaTonGiao;
                txTencha.Text = hocSinh.HoTenCha;
                cbNghecha.SelectedValue = hocSinh.MaNgheCha;
                txTenme.Text = hocSinh.HoTenMe;
                cbNgheme.SelectedValue = hocSinh.MaNgheMe;
                txEmail.Text = hocSinh.Email;
            }
        }

        private void LoadDanhSachDanToc()
        {
            List<KeyValuePair<string, string>> danTocList = danTocBLL.LayDanhSachDanToc();

            cbDantoc.DataSource = new BindingSource(danTocList, null);
            cbDantoc.DisplayMember = "Value";
            cbDantoc.ValueMember = "Key";
        }

        private void LoadDanhSachTonGiao()
        {
            List<KeyValuePair<string, string>> tongiaoList = tonGiaoBLL.LayDanhSachTonGiao();

            cbTongiao.DataSource = new BindingSource(tongiaoList, null);
            cbTongiao.DisplayMember = "Value";
            cbTongiao.ValueMember = "Key";
        }

        private void LoadDanhNgheNghiep()
        {
            List<KeyValuePair<string, string>> nghenghiepList = ngheNghiepBLL.LayDanhSachNgheNghiep();

            cbNghecha.DataSource = new BindingSource(nghenghiepList, null);
            cbNghecha.DisplayMember = "Value";
            cbNghecha.ValueMember = "Key";

            cbNgheme.DataSource = new BindingSource(nghenghiepList, null);
            cbNgheme.DisplayMember = "Value";
            cbNgheme.ValueMember = "Key";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HocSinhDTO hocSinh = new HocSinhDTO
            {

                MaHocSinh = txMaHS.Text,
                HoTen = txTenHS.Text,
                GioiTinh = gioiTinh_nam.Checked ? 0 : 1,
                NgaySinh = ngaySinh_HS.Value,
                DiaChi = txDiachi_HS.Text,
                MaDanToc = ((KeyValuePair<string, string>)cbDantoc.SelectedItem).Key,
                MaTonGiao = ((KeyValuePair<string, string>)cbTongiao.SelectedItem).Key,
                HoTenCha = txTencha.Text,
                MaNgheCha = ((KeyValuePair<string, string>)cbNghecha.SelectedItem).Key,
                HoTenMe = txTenme.Text,
                MaNgheMe = ((KeyValuePair<string, string>)cbNgheme.SelectedItem).Key,
                Email = txEmail.Text
            };

            if (hocSinhBLL.UpdateHocSinh(hocSinh))
            {
                MessageBox.Show("Câp nhật học sinh mã " + hocSinh.MaHocSinh + " thành công!");
            }
            else
            {
                MessageBox.Show("Câp nhật học sinh mã " + hocSinh.MaHocSinh + " thất bại!");

            }
        }
    }
}
