//1. Создать класс Liquid (жидкость), имеющий поля названия и плотности. Определить методы переназначения и изменения плотности. Создать производный класс Alcohol (спирт), имеющий крепость. Определить методы переназначения и изменения крепости.

//using Lesson9_DZ_;

//// Создание объекта Liquid
//Liquid water = new Liquid("Water", 1.0);
//Console.WriteLine($"Name: {water.Name}, Density: {water.Density}");

//// Изменение плотности
//water.ChangeDensity(0.998);
//Console.WriteLine($"Name: {water.Name}, Density: {water.Density}");

//// Создание объекта Alcohol
//Alcohol vodka = new Alcohol("Vodka", 0.8, 40.0);
//Console.WriteLine($"Name: {vodka.Name}, Density: {vodka.Density}, Strength: {vodka.Strength}");

//// Изменение крепости
//vodka.ChangeStrength(45.0);
//Console.WriteLine($"Name: {vodka.Name}, Density: {vodka.Density}, Strength: {vodka.Strength}");


//2. Создать класс Pair (пара чисел); определить методы изменения полей и вычисления произведения чисел. Определить производный класс Rectangle (прямоугольник) с полями-сторонами. Определить методы вычисления периметра и площади прямоугольника.

using Lesson9_DZ_;

// Создание объекта Pair
Pair pair = new Pair(5, 10);
Console.WriteLine($"Пара: ({pair.GetX()}, {pair.GetY()})");
Console.WriteLine($"Произведение: {pair.Multiply()}");

// Создание объекта Rectangle
Rectangle rect = new Rectangle(4, 6);
Console.WriteLine($"Прямоугольник: ({rect.GetX()}, {rect.GetY()})");
Console.WriteLine($"Периметр: {rect.GetPerimeter()}");
Console.WriteLine($"Площадь: {rect.GetArea()}");