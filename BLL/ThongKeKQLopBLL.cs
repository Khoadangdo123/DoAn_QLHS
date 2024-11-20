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
    public class ThongKeKQLopBLL
    {
        private ThongKeKQLopDAL thongKeKQDAL = new ThongKeKQLopDAL();

        public List<ThongKeKQLopDTO> GetThongKeKQ_Lop()
        {
            return thongKeKQDAL.GetThongKeKQ_Lop();
        }

        public List<ThongKeKQLopDTO> FilterTKKQ_Lop(string lop, string namhoc)
        {
            return thongKeKQDAL.FilterTKKQ_Lop(lop, namhoc);
        }

        public void ExportToExcel(List<ThongKeKQLopDTO> data, string filePath)
        {
            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("ThongKeKQLop");

                worksheet.Cells[1, 1].Value = "STT";
                worksheet.Cells[1, 2].Value = "Lớp";
                worksheet.Cells[1, 3].Value = "Khối";
                worksheet.Cells[1, 4].Value = "Năm học";
                worksheet.Cells[1, 5].Value = "Lên lớp";
                worksheet.Cells[1, 6].Value = "Thi lại";
                worksheet.Cells[1, 7].Value = "Rèn luyện hè";
                worksheet.Cells[1, 8].Value = "Ở lại lớp";

                for (int i = 0; i < data.Count; i++)
                {
                    var kql = data[i];
                    worksheet.Cells[i + 2, 1].Value = kql.STT;
                    worksheet.Cells[i + 2, 2].Value = kql.Lop;
                    worksheet.Cells[i + 2, 3].Value = kql.Khoi;
                    worksheet.Cells[i + 2, 4].Value = kql.NamHoc;
                    worksheet.Cells[i + 2, 5].Value = kql.LenLop;
                    worksheet.Cells[i + 2, 6].Value = kql.ThiLai;
                    worksheet.Cells[i + 2, 7].Value = kql.RenLuyenHe;
                    worksheet.Cells[i + 2, 8].Value = kql.OLai;
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
