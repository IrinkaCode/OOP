//Вам дается CSV-файл InventoryControl.csv
//Считайте его данные в список объектов класса Good (создайте его) и, используя LINQ, только те товары, количество которых - четное

////1 вариант
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;

//string filePath = @"C:\Users\pil02\Desktop\inventoryControl.csv";

//var lines = File.ReadAllLines(filePath);

//// Преобразуем строки в список объектов Good
//var goods = lines.Skip(1) 
//                 .Select(line => line.Split(','))
//                 .Select(parts => new Good
//                 {
//                     Name = parts[0],
//                     Quantity = int.Parse(parts[1])
//                 })
//                 .ToList();

//var evenQuantityGoods = goods.Where(g => g.Quantity % 2 == 0);

//foreach (var good in evenQuantityGoods)
//{
//    Console.WriteLine($"Name: {good.Name}, Quantity: {good.Quantity}");
//}

//class Good
//{
//    public string? Name { get; set; }
//    public int Quantity { get; set; }
//}


////2 вариант
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using System.Linq;

string filePath = @"C:\Users\pil02\Desktop\inventoryControl.csv";
List<Good> goods;

using (var reader = new StreamReader(filePath))
using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
{
    goods = csv.GetRecords<Good>().ToList();
}

// Выводим товары с четным количеством
var evenQuantityGoods = goods.Where(g => g.Quantity % 2 == 0);
foreach (var good in evenQuantityGoods)
{
    Console.WriteLine($"Name: {good.Name}, Quantity: {good.Quantity}");
}

public class Good
{
    public string? Name { get; set; }
    public int Quantity { get; set; }
}