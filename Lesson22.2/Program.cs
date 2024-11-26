//Календарь
//using OfficeOpenXml;
//using OfficeOpenXml.Style;
//using System.Drawing;

//FileInfo fileInfo = new FileInfo("Календарь" + DateTime.Now.Year + ".xlsx");
//ExcelPackage.LicenseContext =
//    OfficeOpenXml.LicenseContext.NonCommercial;
//ExcelPackage newBook = new ExcelPackage(fileInfo);
//newBook.Workbook.Worksheets.Add("Календарь " + DateTime.Now.Year);
//ExcelWorksheet worksheet =
//    newBook.Workbook.Worksheets["Календарь " + DateTime.Now.Year];
//DateTime start = new DateTime(DateTime.Now.Year, 1, 1);
//DateTime finish = new DateTime(DateTime.Now.Year, 12, 31);
//int row = 0;
//int column = 2;
//int currentMonth, predMonth = 1;
//for (DateTime i = start; i <= finish;)
//{
//    currentMonth = i.Month;
//    if (currentMonth != predMonth)
//    {
//        row = 0;
//        column++;
//    }
//    worksheet.Cells[2 + row, column].Value = i.Day;
//    worksheet.Cells[2 + row, column].AddComment(i.DayOfWeek.ToString());
//    if (i.DayOfWeek == DayOfWeek.Sunday || i.DayOfWeek == DayOfWeek.Saturday)
//    {
//        worksheet.Cells[2 + row, column].Style.Fill.PatternType =
//            ExcelFillStyle.Solid;
//        worksheet.Cells[2 + row, column].Style.Fill.
//            BackgroundColor.SetColor(Color.Violet);
//    }
//    row++;
//    predMonth = currentMonth;
//    i = i.AddDays(1);
//}
//newBook.Save();
//newBook.SaveAs(fileInfo);

////Второй вариант
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;

FileInfo fileInfo = new FileInfo("Календарь " + DateTime.Now.Year + ".xlsx");

ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
ExcelPackage newBook = new ExcelPackage(fileInfo);

var worksheet = newBook.Workbook.Worksheets.Add("Календарь " + DateTime.Now.Year);

string[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };

for (int month = 1; month < 12; month++)
{
    //название месяца
    worksheet.Cells[1, month + 1].Value = months[month];
    worksheet.Cells[1, month + 1].Style.Font.Bold = true;


    DateTime firstDay = new DateTime(DateTime.Now.Year, month + 1, 1);

    int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, month + 1);

    // дни
    for (int day = 1; day <= daysInMonth; day++)
    {
        DateTime currentDate = new DateTime(DateTime.Now.Year, month + 1, day);
        int row = day + 1; 

       
        worksheet.Cells[row, month + 1].Value = day;
        worksheet.Cells[row, month + 1].AddComment(currentDate.DayOfWeek.ToString());

        //выходные

        if (currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday)
        {
            worksheet.Cells[row, month + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
            worksheet.Cells[row, month + 1].Style.Fill.BackgroundColor.SetColor(Color.Violet);
            worksheet.Cells[row, month + 1].Style.Font.Bold = true; 
        }
    }
}
try
{
    newBook.Save();
    Console.WriteLine("Календарь успешно создан!");
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка при сохранении файла: {ex.Message}");
}
//newBook.Save();
//Console.WriteLine("Календарь успешно создан!");



