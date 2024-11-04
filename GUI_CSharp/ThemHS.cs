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
using OfficeOpenXml;
using System.IO;
using System.Globalization;

namespace GUI_CSharp
{
    public partial class ThemHS : MaterialForm
    {
        private HocSinhBLL hocSinhBLL = new HocSinhBLL();
        private DanTocBLL danTocBLL = new DanTocBLL();
        private TonGiaoBLL tonGiaoBLL = new TonGiaoBLL();
        private NgheNghiepBLL ngheNghiepBLL = new NgheNghiepBLL();
        public ThemHS()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; 
            LoadDanhSachDanToc();
            LoadDanhSachTonGiao();
            LoadDanhNgheNghiep();
            string maHocSinh_New = hocSinhBLL.GenMaHS();
            txMaHS.Text = maHocSinh_New;
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

        private void btnThem_Click(object sender, EventArgs e)
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

            if (hocSinhBLL.AddHocSinh(hocSinh))
            {
                MessageBox.Show("Thêm học sinh thành công!");
            }
            else
            {
                MessageBox.Show("Thêm học sinh thất bại.");

            }
        }

        private void txMaHS_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbDantoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maDanToc = ((KeyValuePair<string, string>)cbDantoc.SelectedItem).Key;
        }

        private void btnExcel_Click(object sender, EventArgs e)
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
                            string hoTen = worksheet.Cells[row, 1].Text; // Cột 2: Họ tên
                            string dateString = worksheet.Cells[row, 2].Text; // Cột 3: Ngày sinh
                            string diaChi = worksheet.Cells[row, 3].Text; // Cột 4: Địa chỉ
                            string maDanToc = worksheet.Cells[row, 4].Text; // Cột 5: Mã dân tộc
                            string maTonGiao = worksheet.Cells[row, 5].Text; // Cột 6: Mã tôn giáo
                            string hoTenCha = worksheet.Cells[row, 6].Text; // Cột 7: Họ tên cha
                            string maNgheCha = worksheet.Cells[row, 7].Text; // Cột 8: Mã nghề cha
                            string hoTenMe = worksheet.Cells[row, 8].Text; // Cột 9: Họ tên mẹ
                            string maNgheMe = worksheet.Cells[row, 9].Text; // Cột 10: Mã nghề mẹ
                            string email = worksheet.Cells[row, 10].Text; // Cột 11: Email

                            DateTime ngaySinh;
                            if (!DateTime.TryParse(dateString, out ngaySinh))
                            {
                                MessageBox.Show($"Ngày sinh '{dateString}' không hợp lệ tại dòng {row}.", "Lỗi Ngày Sinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue; // Bỏ qua dòng này và tiếp tục với dòng tiếp theo
                            }

                            if (ngaySinh >= ngaySinh_HS.MinDate && ngaySinh <= ngaySinh_HS.MaxDate)
                            {
                                ngaySinh_HS.Value = ngaySinh; // Đây là DateTimePicker
                            }
                            else
                            {
                                MessageBox.Show($"Ngày sinh '{dateString}' vượt quá giới hạn cho phép.", "Lỗi Ngày Sinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue; // Bỏ qua dòng này nếu ngày sinh không hợp lệ
                            }

                            txTenHS.Text = hoTen;
                            ngaySinh_HS.Value = ngaySinh;
                            txDiachi_HS.Text = diaChi;

                            cbDantoc.SelectedValue = maDanToc;
                            cbTongiao.SelectedValue = maTonGiao;
                            txTencha.Text = hoTenCha;
                            cbNghecha.SelectedValue = maNgheCha;
                            txTenme.Text = hoTenMe;
                            cbNgheme.SelectedValue = maNgheMe;
                            txEmail.Text = email;

                            btnThem_Click(sender, e);


                        }
                    }
                }
            }
        }
    }
}
