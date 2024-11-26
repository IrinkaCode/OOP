//Потоки с параметрами

//Thread thread = new Thread(ShowMessage);
//thread.Start("Привет");


//static void ShowMessage(object? message)
//{
//    Console.WriteLine(message);
//}

//Thread firstThread = new Thread(new ParameterizedThreadStart(ShowMessage));
//Thread secondThread = new Thread(ShowMessage);
//Thread thirdThread = new Thread(message => Console.WriteLine(message));

//firstThread.Start("Строка");
//secondThread.Start(25);
//thirdThread.Start(true);

//static void ShowMessage(object? message)
//{
//    if (message is string)
//    {
//        Console.WriteLine($"Строка: {message}");
//    }
//    else if (message is int)
//    {
//        Console.WriteLine($"Число: {message}");
//    }
//    else if (message is bool)
//    {
//        Console.WriteLine($"Логический тип: {message}");
//    }
//    else
//    {
//        Console.WriteLine("Неизвестный тип");
//    }
//}


// инициируем потоки
Thread firstThread = new Thread(Print);
Thread secondThread = new Thread(Print);
// запускаем потоки
firstThread.Start(new Person());
secondThread.Start("Строка");

static void PrintPersonData(Person person)
{
    person.Name = "Виктор";
    person.Age = 22;
    Console.WriteLine($"Имя: {person.Name} \n Возраст: {person.Age}");
}

static void PrintValue(CustomArray array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(10);
    }
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

static void Print(object? message)
{
    //if (message is not Person)
    //{
    //    throw new Exception("Передан не подходящий объект");
    //}
    //else
    //{
    //    PrintPersonData((Person)message);
    //}
    if (message is Person)
    {
        PrintPersonData((Person)message);
    }
    else if (message is CustomArray)
    {
        PrintValue((CustomArray)message);
    }
    else
    {
        throw new Exception("Передан не подходящий объект");
    }
}

class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }
}

class CustomArray
{
    private double[] data; // Поле массива
    public int Length { get { return data.Length; } } // Свойство длины
    public double this[int index] // Индексатор
    {
        get { return data[index]; }
        set { data[index] = value; }
    }
    public CustomArray(int length) // Конструктор
    {
        data = new double[length];
    }
}

