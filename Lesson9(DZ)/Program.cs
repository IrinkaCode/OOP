//1. Создать класс Liquid (жидкость), имеющий поля названия и плотности. Определить методы переназначения и изменения плотности. Создать производный класс Alcohol (спирт), имеющий крепость. Определить методы переназначения и изменения крепости.

using Lesson9_DZ_;

// Создание объекта Liquid
Liquid water = new Liquid("Water", 1.0);
Console.WriteLine($"Name: {water.Name}, Density: {water.Density}");

// Изменение плотности
water.ChangeDensity(0.998);
Console.WriteLine($"Name: {water.Name}, Density: {water.Density}");

// Создание объекта Alcohol
Alcohol vodka = new Alcohol("Vodka", 0.8, 40.0);
Console.WriteLine($"Name: {vodka.Name}, Density: {vodka.Density}, Strength: {vodka.Strength}");

// Изменение крепости
vodka.ChangeStrength(45.0);
Console.WriteLine($"Name: {vodka.Name}, Density: {vodka.Density}, Strength: {vodka.Strength}");


