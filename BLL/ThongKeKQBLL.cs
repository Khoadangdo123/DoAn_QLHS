using DAL;
using DTO;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThongKeKQBLL
    {
        private ThongKeKQDAL thongKeKQDAL = new ThongKeKQDAL();

        public List<ThongKeKQDTO> GetThongKeKQ_HS()
        {
            return thongKeKQDAL.GetThongKeKQ_HS();
        }

        public List<ThongKeKQDTO> TimKiemThongKeKQ_HS(string keyword)
        {
            return thongKeKQDAL.TimKiemThongKeKQ_HS(keyword);
        }

        public List<ThongKeKQDTO> FilterTKKQ_HS(string lop, string namhoc)
        {
            return thongKeKQDAL.FilterTKKQ_HS(lop, namhoc);
        }

        public void ExportToExcel(List<ThongKeKQDTO> data, string filePath)
        {
            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("ThongKeKQ");

                // Write header
                worksheet.Cells[1, 1].Value = "STT";
                worksheet.Cells[1, 2].Value = "Mã học sinh";
                worksheet.Cells[1, 3].Value = "Tên học sinh";
                worksheet.Cells[1, 4].Value = "Lớp";
                worksheet.Cells[1, 5].Value = "Năm học";
                worksheet.Cells[1, 6].Value = "Kết quả";

                for (int i = 0; i < data.Count; i++)
                {
                    var hs = data[i];
                    worksheet.Cells[i + 2, 1].Value = hs.STT;
                    worksheet.Cells[i + 2, 2].Value = hs.MaHocSinh;
                    worksheet.Cells[i + 2, 3].Value = hs.HoTen;
                    worksheet.Cells[i + 2, 4].Value = hs.Lop;
                    worksheet.Cells[i + 2, 5].Value = hs.NamHoc;
                    worksheet.Cells[i + 2, 6].Value = hs.KetQua;
                }

                // Auto fit columns
                worksheet.Cells.AutoFitColumns();

                // Save the Excel file
                FileInfo excelFile = new FileInfo(filePath);
                package.SaveAs(excelFile);
            }
        }
    }
}
