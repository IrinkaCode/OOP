//Домашнее задание тема 29

using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Globalization;


// Создание StreamWriter для записи в файл "output.csv".
StreamWriter writer = new StreamWriter("output.csv");

// Создание CsvWriter с настройками и привязка к StreamWriter.
CsvWriter csvWrite = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture));

// Создание списка объектов Person с данными.
List<Person> record = new List<Person>()
    {
        new Person { Name = "John" , Age = 30 },
        new Person { Name = "Alice" , Age = 25 }
    };

// Запись данных из списка record в файл "output.csv" с использованием CsvWriter.
csvWrite.WriteRecords(record);

// Закрытие StreamWriter и файла "output.csv".
writer.Close();

// Создание StreamReader для чтения из файла "output.csv".
StreamReader reader = new StreamReader("output.csv");

// Создание CsvReader с настройками и привязка к созданному StreamReader.
CsvReader csvRead = new CsvReader(reader, new
CsvConfiguration(CultureInfo.InvariantCulture));

// Чтение данных из файла "output.csv" и преобразование их в список объектов Person.
List<Person> records = csvRead.GetRecords<Person>().ToList();

// Не забываем закрыть поток файла после работы с ним
reader.Close();

// Отображение данных из списка на консоль.
foreach (Person person in records)
{
    Console.WriteLine($"Имя: {person.Name} \n Возраст:{person.Age}");
}

//// Создание StreamReader для чтения из файла "output.csv".
//StreamReader reader = new StreamReader("output.csv");
//CsvConfiguration csvConfig = new
//CsvConfiguration(CultureInfo.InvariantCulture)
//{
//    Delimiter = ";"
//};
//// Создание CsvReader с настройками
//CsvReader csvRead = new CsvReader(reader, csvConfig);

CsvConfiguration csvConfig = new
CsvConfiguration(CultureInfo.InvariantCulture)
{
    Delimiter = ";",
    HasHeaderRecord = false, // Если данные не содержат заголовков.
    HeaderValidated = null // Позволяет управлять обработкой заголовков.
};





public class Person
{
    [Name("UserName")]
    public string? Name { get; set; }

    [Name("UserAge")]
    public int Age { get; set; }
}

public sealed class PersonMap : ClassMap<Person>
{
    public PersonMap()
    {
        Map(m => m.Name).Name("Full Name");
        Map(m => m.Age).Name("Age");
    }
}
