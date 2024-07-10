// Построить три класса (базовый и 3 потомка), описывающих некоторых хищных животных (один из потомков), всеядных(второй потомок) и травоядных (третий потомок). Описать в базовом классе абстрактный метод для расчета количества и типа пищи, необходимого для пропитания животного в зоопарке.
//1.Упорядочить всю последовательность животных по убыванию количества пищи. При совпадении значений – упорядочивать данные по алфавиту по имени. Вывести идентификатор животного, имя, тип и количество потребляемой пищи для всех элементов списка.
//2. Вывести первые 5 имен животных из полученного в пункте а) списка.
//3. Вывести последние 3 идентификатора животных из полученного в пункте 1. списка.
//4. Организовать запись и чтение коллекции в/из файл.
//5. Организовать обработку некорректного формата входного файла.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Lesson13_DZ__Абстрактные_классы;

List<Animal> animals = new List<Animal>
         {
           new Predator { Name="Tiger",Eats=100 },
           new Predator { Name = "Leo",Eats=200},
           new Predator { Name = "Fox",Eats=300},
           new Predator { Name = "Wolf",Eats=150},
           new Predator { Name = "Leopard",Eats=250},
           new Omnivorous { Name = "Bear",Eats=300 },
           new Omnivorous { Name = "Monkey",Eats=150},
           new Omnivorous { Name = "Raccoon",Eats = 100},
           new Omnivorous { Name = "Boar",Eats = 200},
           new Omnivorous { Name = "Rat",Eats = 130},
           new Herbivorous { Name = "Elephant",Eats=500 },
           new Herbivorous { Name = "Cow",Eats=300 },
           new Herbivorous { Name = "Sheep",Eats=200 },
           new Herbivorous { Name = "Rabbit",Eats=250 },
           new Herbivorous { Name = "Horse",Eats=400 },

         };

var sortedAnimals = animals.OrderByDescending(a => a.CalculateFoodRequired()).ThenBy(a => a.Name);

foreach (var animal in sortedAnimals)
{
    Console.WriteLine($"Идентификатор: {animal.GetHashCode()}, Имя: {animal.Name}, Тип: {animal.GetType().Name}, Количество потребляемой пищи: {animal.CalculateFoodRequired()}");
}

var topFiveNames = sortedAnimals.Take(5).Select(a => a.Name);
Console.WriteLine("Первые 5 имен животных:");
foreach (var name in topFiveNames)
{
    Console.WriteLine(name);
}

var lastThreeIds = sortedAnimals.Reverse().Take(3).Select(a => a.GetHashCode());
Console.WriteLine("Последние 3 идентификатора животных:");
foreach (var id in lastThreeIds)
{
    Console.WriteLine(id);
}

// запись коллекции в файл 
using (StreamWriter writer = new StreamWriter("animals.txt"))
{

    foreach (var animal in animals)
    {
        writer.WriteLine($"{animal.GetType().Name},{animal.Name}");
    }

}
try
{
    using (StreamReader reader = new StreamReader("animals.txt"))
    {
        string line;

        while ((line = reader.ReadLine()) != null)
        {
            string[] values = line.Split(',');
            if (values.Length == 2)
            {
                switch (values[0])
                {
                    case nameof(Predator):
                        animals.Add(new Predator { Name = values[1] });
                        break;
                    case nameof(Omnivorous):
                        animals.Add(new Omnivorous { Name = values[1] });
                        break;

                    case nameof(Herbivorous):
                        animals.Add(new Herbivorous { Name = values[1] });
                        break;
                }
            }
            else
            {
                throw new InvalidDataException($"Invalid format in file on line '{line}'");
            }
        }
    }
}
catch (InvalidDataException ex)
{
    Console.WriteLine(ex.Message);
}

