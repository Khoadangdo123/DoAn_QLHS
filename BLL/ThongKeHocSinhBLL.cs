using DAL;
using GUI_CSharp.DTO;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThongKeHocSinhBLL
    {
        private ThongKeHocSinhDAL thongKeHocSinhDAL = new ThongKeHocSinhDAL();

        public List<ThongKeHocSinhDTO> GetThongKeHocSinh()
        {
            return thongKeHocSinhDAL.GetThongKeHocSinhData();
        }

        public List<ThongKeHocSinhDTO> SearchHocSinh(string keyword)
        {
            return thongKeHocSinhDAL.SearchHocSinh(keyword);
        }

        public List<ThongKeHocSinhDTO> FilterHocSinh(string lop, string namhoc)
        {
            return thongKeHocSinhDAL.FilterHocSinh(lop, namhoc);
        }

        public void ExportToExcel(List<ThongKeHocSinhDTO> thongKeHocSinhList, string filePath)
        {
            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("ThongKeHocSinh");

                // Add headers
                worksheet.Cells[1, 1].Value = "STT";
                worksheet.Cells[1, 2].Value = "Mã học sinh";
                worksheet.Cells[1, 3].Value = "Họ và tên";
                worksheet.Cells[1, 4].Value = "Ngày sinh";
                worksheet.Cells[1, 5].Value = "Giới tính";
                worksheet.Cells[1, 6].Value = "Khối";
                worksheet.Cells[1, 7].Value = "Lớp";
                worksheet.Cells[1, 8].Value = "Năm học";

                // Add data
                for (int i = 0; i < thongKeHocSinhList.Count; i++)
                {
                    var hs = thongKeHocSinhList[i];
                    worksheet.Cells[i + 2, 1].Value = hs.STT;
                    worksheet.Cells[i + 2, 2].Value = hs.MaHS;
                    worksheet.Cells[i + 2, 3].Value = hs.TenHS;
                    worksheet.Cells[i + 2, 4].Value = hs.NgaySinh.ToString("dd/MM/yyyy");
                    worksheet.Cells[i + 2, 5].Value = hs.GioiTinh == 0 ? "Nam" : "Nữ";
                    worksheet.Cells[i + 2, 6].Value = hs.Khoi;
                    worksheet.Cells[i + 2, 7].Value = hs.Lop;
                    worksheet.Cells[i + 2, 8].Value = hs.NamHoc;
                }

                // Save the file
                FileInfo fileInfo = new FileInfo(filePath);
                package.SaveAs(fileInfo);
            }
        }
    }

}
