//1. Массивы (Arrays): Создайте массив целых чисел и наполните его несколькими значениями от -10 до 10.

using System.Collections.Generic;

int[] numbers = new int[] { -5, 2, -8, 7, 0, -3, 9, -1, 4, -6 };

//2. Списки (List): Создайте список строк и добавьте в него несколько элементов произвольных имен.

List<string> names = new List<string>
{
    "Иван",
    "Алиса",
    "Михаил",
    "Елена",
    "Олег"
};

//3.Инициализация стека целых чисел и добавление нескольких элементов:

Stack<int> intStack = new Stack<int>();
intStack.Push(10);
intStack.Push(20);
intStack.Push(30);
foreach (int num in intStack)
{
    Console.WriteLine(num);
}
Console.WriteLine();

//4.Демонстрация операций добавления и извлечения элементов из стека:
Console.WriteLine("Элементы в стеке:");
foreach (int item in intStack)
{
    Console.WriteLine(item);
}

Console.WriteLine("\nИзвлечение элементов из стека:");
Console.WriteLine(intStack.Pop()); // Извлечение и вывод последнего элемента
Console.WriteLine(intStack.Peek()); // Вывод последнего элемента без извлечения
Console.WriteLine();

//5.Создание очереди строк и добавление в нее элементов:

Queue<string> stringQueue = new Queue<string>();
stringQueue.Enqueue("Яблоко");
stringQueue.Enqueue("Груша");
stringQueue.Enqueue("Апельсин");

//6.Создание словаря, связывающего строки с целыми числами:

Dictionary<string, int> ageDictionary = new Dictionary<string, int>();
ageDictionary["Alice"] = 25;
ageDictionary["Bob"] = 30;
int aliceAge = ageDictionary["Alice"]; 
if (ageDictionary.ContainsKey("Charlie"))
{
    int charlieAge = ageDictionary["Charlie"]; 
}
foreach (KeyValuePair<string, int> pair in ageDictionary)
{
    Console.WriteLine($"Имя: {pair.Key}, Возраст: {pair.Value}");
}
Console.WriteLine();

//7.Создание множества целых чисел и добавление в него элементов:

HashSet<int> intSet = new HashSet<int>();
intSet.Add(10);
intSet.Add(20);
intSet.Add(30);
intSet.Add(40);
foreach (int num in intSet)
{
    Console.WriteLine(num);
}
Console.WriteLine();

//8.Создание коллекции KeyValuePair, связывающей имена и возраст, и работа с ней:

List<KeyValuePair<string, int>> nameAgeList = new List<KeyValuePair<string, int>>();
nameAgeList.Add(new KeyValuePair<string, int>("Иван", 25));
nameAgeList.Add(new KeyValuePair<string, int>("Мария", 30));
nameAgeList.Add(new KeyValuePair<string, int>("Петр", 35));

foreach (KeyValuePair<string, int> pair in nameAgeList)
{
    Console.WriteLine($"Имя: {pair.Key}, Возраст: {pair.Value}");
}



