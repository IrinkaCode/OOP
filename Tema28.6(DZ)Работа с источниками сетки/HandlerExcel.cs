using OfficeOpenXml;
using System.Data;
using System.IO;

public class HandlerExcel
{
    public DataTable LoadExcel(string filePath)
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        using (var package = new ExcelPackage(new FileInfo(filePath)))
        {
            if (package.Workbook.Worksheets.Count == 0)
            {
                throw new InvalidOperationException("Файл Excel не содержит рабочих листов.");
            }

            var worksheet = package.Workbook.Worksheets[0];

            if (worksheet.Dimension == null)
            {
                throw new InvalidOperationException("Рабочий лист не содержит данных.");
            }

            var dataTable = new DataTable();

            for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
            {
                dataTable.Columns.Add(worksheet.Cells[1, col].Text);
            }

            for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
            {
                var newRow = dataTable.NewRow();
                for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                {
                    newRow[col - 1] = worksheet.Cells[row, col].Text;
                }
                dataTable.Rows.Add(newRow);
            }

            return dataTable;
        }
    }

    public void SaveExcel(string filePath, DataTable dataTable)
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        using (var package = new ExcelPackage())
        {
            var worksheet = package.Workbook.Worksheets.Add("Sheet1");

            for (int col = 0; col < dataTable.Columns.Count; col++)
            {
                worksheet.Cells[1, col + 1].Value = dataTable.Columns[col].ColumnName;
            }

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    worksheet.Cells[row + 2, col + 1].Value = dataTable.Rows[row][col];
                }
            }

            FileInfo excelFile = new FileInfo(filePath);
            package.SaveAs(excelFile);
        }
    }
}
