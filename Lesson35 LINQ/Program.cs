//LINQ


using System.Linq;

List<Car>GetCars()
{
    return new List<Car>
    {
        new Car { VIN="ABC123",Make="Ford",Model= "F-259",Year=2000 },
        new Car { VIN="ABC456",Make="VW",Model= "F-2598",Year=2003 },
        new Car { VIN="ABC789",Make="BMW",Model= "E39",Year=1995 },
        new Car { VIN="CDE123",Make="Audi",Model= "F-257",Year=1989 },
        new Car { VIN="ABC456",Make="Tesla",Model= "F4567",Year=2020 },
    };
}

bool result = GetCars().All(c => c.Year > 1960);
Console.WriteLine(result);
result = GetCars().Any(c => c.Year > 1960);
Console.WriteLine(result);

var cars = GetCars();
//var carsByVin = cars.ToDictionary(c => c.VIN);
//Console.WriteLine(carsByVin["ABC456"].Make);

var carsLookUp = cars.ToLookup(c => c.Make);
IEnumerable<Car> list = carsLookUp["Ford"];
foreach (var car in list)
{
    Console.WriteLine(car.Year);
}

var numbers = Enumerable.Range(1, 1000);
//foreach(var car in numbers)
//{
//    Console.WriteLine(car);
//}

var zip = numbers.Zip(cars, (i, c) => new
{
    Number = i,
    CarMake = c.Make
});
foreach (var car in zip)
{
    Console.WriteLine(car);
}




class Car
{
    public string VIN { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
}


