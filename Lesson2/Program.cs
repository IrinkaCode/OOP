//Создать класс «Двигатель автомобиля», включающий данные-элементы: марка автомобиля, объем топливного бака, расход бензина на 100 км.
//Функции-элементы:
//создание и инициализация (конструктор),
//заправка автомобиля (количество бензина – в аргументе),
//расход бензина (пройденный путь – в аргументе),
//выдача сообщения о том, сколько км можно проехать на оставшемся бензине,
//деструктор.

//using Lesson2;

//Console.Write("Введите марку автомобиля: ");
//string brand = Console.ReadLine()!;

//Console.Write("Введите обьем топливного бака: ");
//double volume = double.Parse(Console.ReadLine()!);

//Console.Write("Введите расход бензина на 100 км: ");
//double expend = double.Parse(Console.ReadLine()!);

//Console.Write("Введите текущее количество топлива в баке: ");
//double current = double.Parse(Console.ReadLine()!);

//Auto auto = new Auto(current, brand, volume, expend);

//Console.Write("Введите обьем заправки: ");
//double addFill = double.Parse(Console.ReadLine()!);

//auto.Fide(addFill);
//Console.WriteLine($"Количество в баке: {auto.Current:F2}");

//Console.Write("Введите количество километров: ");
//double km = double.Parse(Console.ReadLine()!);

//Console.WriteLine($"Расход на {km} равен: {auto.Way(km):F2} литров");

//Console.WriteLine($"Еще можно проехать {auto.Remains():F2} км проехать");


//Создать класс «Склад пиломатериалов», включающий данные-элементы: № склада, фамилия директора, максимальный объем хранимых пиломатериалов. Функции-элементы:
//создание и инициализация (конструктор),
//ввезенные материалы, м3 (количество – в аргументе),
//вывезенные материалы, м3 (в аргументе),
//выдача сообщения, сколько можно еще завезти материалов и сколько есть в наличии,
//деструктор.

using Lesson2;

//Console.Write("Введите номер склада: ");
//int number = int.Parse(Console.ReadLine()!);

//Console.Write("Введите фамилию директора: ");
//string lastName = Console.ReadLine()!;

//Console.Write("Введите максимальный обьем хранимых пиломатериалов: ");
//double maxVolume = double.Parse(Console.ReadLine()!);

//Console.Write("Введите количество ввезенного материала: ");
//double addMaterial = double.Parse(Console.ReadLine()!);

//Console.Write("Введите количество вывезенного материала: ");
//double removeMaterial = double.Parse(Console.ReadLine()!);

//Console.Write("Введите текущий обьем: ");
//double current = double.Parse(Console.ReadLine()!);

//Sklad sklad = new Sklad(number, lastName, maxVolume, current);
//sklad.DisplayInfo();

Sklad sklad = new Sklad(1, "Иванов", 1000, 100);
sklad.AddMaterials(500.0);
sklad.RemoveMaterials(200.0);
sklad.DisplayInfo();