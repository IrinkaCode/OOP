//Составить описание класса для представления времени. Предусмотреть возможности установки времени и изменения его отдельных полей (час, минута, секунда) с проверкой допустимости вводимых значений. В случае недопустимых значений полей выбрасываются исключения. Создать методы изменения времени на заданное количество часов, минут и секунд.

using Lesson1_DZ_;
using System.Runtime.CompilerServices;

DateTime currentTime = DateTime.Now;
Console.Write("Текущее время: " + currentTime.ToString("HH:mm:ss"));
Console.WriteLine();
Console.Write("Введите часы: ");
int hours = int.Parse(Console.ReadLine()!);
Console.Write("Введите минуты: ");
int minutes = int.Parse(Console.ReadLine()!);
Console.Write("Введите секунды: ");
int seconds = int.Parse(Console.ReadLine()!);

DateTime newTime = currentTime.AddHours(hours).AddMinutes(minutes).AddSeconds(seconds);
Console.WriteLine("Новое время: " + newTime.ToString("HH:mm:ss"));


//Описать класс, представляющий треугольник. Предусмотреть методы для создания объектов, вычисления площади, периметра и точки пересечения медиан. Описать методы для получения состояния объекта.

//using Lesson1_DZ_;

//Console.Write("Введите сторону А: ");
//double A = double.Parse(Console.ReadLine()!);
//Console.Write("Введите сторону В: ");
//double B = double.Parse(Console.ReadLine()!);
//Console.Write("Введите сторону С: ");
//double C = double.Parse(Console.ReadLine()!);

//Triangle triangle = new Triangle(A,B,C);
//Console.WriteLine($"Периметр: {triangle.Perimeter()}");
//Console.WriteLine($"Площадь: {triangle.Area():F2}");
//(double x, double y) = triangle.MedianIntersection();
//Console.WriteLine($"Точка пересечения медиан: ({x:F2}, {y:F2})");

