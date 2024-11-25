//Календарь

//using OfficeOpenXml;
//using System.Drawing;
//FileInfo fileInfo = new FileInfo("Календарь.xlsx");
//if (!fileInfo.Exists) fileInfo.Create();

//ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
//ExcelPackage newBook = new ExcelPackage(fileInfo);

//newBook.Workbook.Worksheets.Add("Календарь 2024");
//ExcelWorkSheets worksheet2 = newBook.Workbook.Worksheets.Add["Календарь 2024"];

//DateTime start = new DateTime(DateTime.Now.Year, 1, 1);
//DateTime finish = new DateTime(DateTime.Now.Year, 12, 31);

//int row = 0;
//int colum = 2;
//int currentMonth,predMonth=1;

//for (DateTime i = start; i <= finish;i.AddDays(1))
//{
//    currentMonth = i.Month;
//    if (currentMonth!= predMonth)
//    {
//        row = 2;
//        colum++;
//    }

//    worksheet.Cells[2 + row, colum].Value = i.Day;
//    worksheet.Cells[2 + row, colum].AddComment(i.

//    worksheet.Cells[2+ row, colum].Value = i.Month;

//    if (i.DayOfWeek==DayOfWeek.Sunday||i.DayOfWeek==DayOfWeek.Saturday)
//        worksheet.Cells[2 + row, colum].Style.Fill.PatternType = ExcelFillStyle.Solid;
//        worksheet.Cells[2+row, colum].Style.Fill.Background.SetColor(Color.Violet);


//    row++;
//    predMonth = currentMonth;
//    i = i.AddDays(1);
//}
//newBook.Save();
//newBook.SaveAs(fileInfo);



using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Drawing;

FileInfo fileInfo = new FileInfo("Календарь" + DateTime.Now.Year + ".xlsx");
ExcelPackage.LicenseContext =
    OfficeOpenXml.LicenseContext.NonCommercial;
ExcelPackage newBook = new ExcelPackage(fileInfo);
newBook.Workbook.Worksheets.Add("Календарь " + DateTime.Now.Year);
ExcelWorksheet worksheet =
    newBook.Workbook.Worksheets["Календарь " + DateTime.Now.Year];
DateTime start = new DateTime(DateTime.Now.Year, 1, 1);
DateTime finish = new DateTime(DateTime.Now.Year, 12, 31);
int row = 0;
int column = 2;
int currentMonth, predMonth = 1;
for (DateTime i = start; i <= finish;)
{
    currentMonth = i.Month;
    if (currentMonth != predMonth)
    {
        row = 0;
        column++;
    }
    worksheet.Cells[2 + row, column].Value = i.Day;
 
    worksheet.Cells[2 + row, column].AddComment(i.DayOfWeek.ToString());
    if (i.DayOfWeek == DayOfWeek.Sunday || i.DayOfWeek == DayOfWeek.Saturday)
    {
        worksheet.Cells[2 + row, column].Style.Fill.PatternType =
            ExcelFillStyle.Solid;
        worksheet.Cells[2 + row, column].Style.Fill.
            BackgroundColor.SetColor(Color.Violet);
    }
    row++;
    predMonth = currentMonth;
    i = i.AddDays(1);
}
newBook.Save();
newBook.SaveAs(fileInfo);