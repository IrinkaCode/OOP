//Библиотека EPPlus. Введение
//Задача.
//Создайте класс Клиент со следующими сущностями:
//Свойства:
//● Имя(строка)
//● Фамилия(строка)
//● Email(строка)
//Конструктор, инициализирующий свойства принимаемыми значениями
//Этот класс будет представлять клиентов.
//Создайте массив клиентов на 10 человек.
//Примеры клиентов:
//Иван Иванов, ivan@example.com
//Петр Петров, peter@example.com
//Мария Сидорова, maria@example.com
//Анна Кузнецова, anna@example.com
//Алексей Смирнов, alex@example.com
//Наталья Васильева, natalia@example.com
//Сергей Морозов, sergey@example.com
//Ольга Павлова, olga@example.com
//Денис Жуков, denis@example.com
//Екатерина Макарова, ekaterina@example.com
//Создайте новый Excel-файл, назовите его "СписокКлиентов.xlsx".
//Создайте в нем лист "Клиенты" и запишите в него набор данных из массива клиентов.
//Затем сохраните файл на диске.

//using OfficeOpenXml;
//using System.Diagnostics.Metrics;
//using System.Drawing.Drawing2D;

//Client[] mas =
//{
//    new Client("Иван", "Иванов", "ivan@example.com"),
//    new Client("Петр", "Петров", "peter@example.com"),
//    new Client("Мария", "Сидорова", "maria@example.com"),
//    new Client("Анна", "Кузнецова", "anna@example.com"),
//    new Client("Алексей", "Смирнов", "alex@example.com"),
//    new Client("Наталья", "Васильева", "natalia@example.com"),
//    new Client("Сергей","Морозов", "sergey@example.com"),
//    new Client("Ольга", "Павлова", "olga@example.com"),
//    new Client("Денис", "Жуков", "denis@example.com"),
//    new Client("Екатерина", "Макарова", "ekaterina@example.com")

//};

//FileInfo fileInfo = new FileInfo("Клиенты.xlsx");
//if (!fileInfo.Exists) fileInfo.Create();
//ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
//ExcelPackage newBook = new ExcelPackage("Клиенты.xlsx");

//newBook.Workbook.Worksheets.Add("Клиенты");
//ExcelWorksheet worksheet = newBook.Workbook.Worksheets["Клиенты"];

//worksheet.Cells["A1"].Value = "Имя";
//worksheet.Cells["B1"].Value = "Фамилия";
//worksheet.Cells["C1"].Value = "Email";

//for (int i = 0; i < mas.Length; i++)
//{
//    worksheet.Cells[2 + i, 1].Value = mas[i].Name;
//    worksheet.Cells[2 + i, 2].Value = mas[i].LastName;
//    worksheet.Cells[2 + i, 3].Value = mas[i].Email;

//}


//newBook.Save();
////newBook.SaveAs(fileInfo);
//Console.WriteLine("Таблица создана");

//class Client
//{
//    public string? Name { get; set; }
//    public string? LastName { get; set; }
//    public string? Email { get; set; }
//    public Client(string? name, string? lastName, string? email)
//    {
//        Name = name;
//        LastName = lastName;
//        Email = email;
//    }

//}

using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Drawing;
using System.IO;

Client[] mas =
{
    new Client("Иван", "Иванов", "ivan@example.com"),
    new Client("Петр", "Петров", "peter@example.com"),
    new Client("Мария", "Сидорова", "maria@example.com"),
    new Client("Анна", "Кузнецова", "anna@example.com"),
    new Client("Алексей", "Смирнов", "alex@example.com"),
    new Client("Наталья", "Васильева", "natalia@example.com"),
    new Client("Сергей","Морозов", "sergey@example.com"),
    new Client("Ольга", "Павлова", "olga@example.com"),
    new Client("Денис", "Жуков", "denis@example.com"),
    new Client("Екатерина", "Макарова", "ekaterina@example.com")
};

FileInfo fileInfo = new FileInfo("Клиенты.xlsx");

ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
using (ExcelPackage newBook = new ExcelPackage(fileInfo))
{
    ExcelWorksheet worksheet = newBook.Workbook.Worksheets.Add("Клиенты");
    worksheet.Cells["A1"].Value = "Имя";
    worksheet.Cells["B1"].Value = "Фамилия";
    worksheet.Cells["C1"].Value = "Email";

    for (int i = 0; i < mas.Length; i++)
    {
        worksheet.Cells[2 + i, 1].Value = mas[i].Name;
        worksheet.Cells[2 + i, 2].Value = mas[i].LastName;
        worksheet.Cells[2 + i, 3].Value = mas[i].Email;
    }

    worksheet.Cells["A1:C1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
    worksheet.Cells["A1:C1"].Style.Fill.BackgroundColor.SetColor(Color.Violet);
    worksheet.Cells["A1:C1"].Style.Font.Bold = true;

    worksheet.Column(1).Width = 20; 
    worksheet.Column(2).Width = 25; 
    worksheet.Column(3).Width = 30; 

    newBook.Save(); 
}

Console.WriteLine("Таблица создана");

class Client
{
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }

    public Client(string? name, string? lastName, string? email)
    {
        Name = name;
        LastName = lastName;
        Email = email;
    }
}