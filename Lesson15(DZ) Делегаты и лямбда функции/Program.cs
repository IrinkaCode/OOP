//Создайте класс Building с следующими свойствами:
//BuildingName(название здания, строковое)
//Height(высота здания в метрах, числовое)
//Floors(количество этажей, числовое)
//TotalArea(общая площадь в квадратных метрах, числовое)
//Locaon(местоположение здания, строковое)
//Определите метод CalculateVolume(), который будет вычислять объем здания. Объем можно приближенно рассчитать, умножив высоту здания на его общую площадь. Метод должен возвращать объем в кубических метрах.
//Создайте массив из 3 зданий, задав разные характеристики для каждого.
//Определите делегат с сигнатурой для метода CalculateVolume.
//Создайте метод, который принимает массив зданий и делегат, а затем вызывает метод CalculateVolume для каждого здания в массиве с помощью делегата. Выведите результаты расчетов на экран.

using Lesson15_DZ__Делегаты_и_лямбда_функции;

Building[] buildings = new Building[]
{
    new Building
    {
        BuildingName = "Небоскреб",
        Height = 200.0,
        Floors = 50,
        TotalArea = 10000.0,
        Location = "Центр города"
    },
    new Building
    {
        BuildingName = "Офисное здание",
        Height = 50.0,
        Floors = 12,
        TotalArea = 2500.0,
        Location = "Деловой район"
    },
    new Building
    {
        BuildingName = "Жилой дом",
        Height = 30.0,
        Floors = 9,
        TotalArea = 1800.0,
        Location = "Жилой квартал"
    }
};

// Вызываем метод CalculateAndDisplayVolumes с использованием делегата
CalculateAndDisplayVolumes(buildings, building => building.CalculateVolume());
static void CalculateAndDisplayVolumes(Building[] buildings, VolumeCalculator volumeCalculator)
{
    foreach (var building in buildings)
    {
        double volume = volumeCalculator(building);
        Console.WriteLine($"Объем здания '{building.BuildingName}': {volume} кубических метров");
    }
}


