﻿
﻿using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;
using System;
using Lesson25._2;

StreamReader reader = new StreamReader("output.csv");
CsvReader csvReader = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture));
List<Inventory> records = csvReader.GetRecords<Inventory>().ToList();
reader.Close();
do
{
    Console.Clear();

    foreach (Inventory record in records)
    {
        Console.WriteLine($"Name:{record.Name}, Quantity:{record.Quattity}," + $" Price:{record.Price}, Description:{record.Description}");
    }
    Console.WriteLine("Выберите действие:\n"+ "1. Вычислить среднее арифметическое количества\n" + "2.Вывести max и min\n" + "3.Общее количество записей: ");
    int n = int .Parse(Console.ReadLine()!);
    switch (n)
    {
        case 1: 
            {
                Console.WriteLine("Выберите поле. 1 - количество, 2 - цена");
                int m = int.Parse(Console.ReadLine()!);
                if(m==1) Console.WriteLine($"Среднее по количеству:"+$" {records.Average(p=>p.Quattity)}");
                else Console.WriteLine($"Среднее по цене:" + $" {records.Average(p => p.Price)}");
                Console.ReadKey();
            } break;

        case 2:
            {
                Console.WriteLine("Выберите поле. 1 - количество, 2 - цена");
                int m = int.Parse(Console.ReadLine()!);
                if (m == 1) Console.WriteLine($"Макс по количеству:" + $" {records.Max(p => p.Quattity)}");
                else Console.WriteLine($"Мин по цене:" + $" {records.Min(p => p.Price)}");
                Console.ReadKey();
            }
            break;

        case 3: Console.WriteLine($"Общее количество записей:{records.Count} ");
            Console.ReadKey();
            break; 
    }
}
while(true);


