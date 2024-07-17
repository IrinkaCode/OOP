////1. Массивы (Arrays): Создайте массив целых чисел и наполните его несколькими значениями от -10 до 10.

//using System.Collections.Generic;

//int[] numbers = new int[] { -5, 2, -8, 7, 0, -3, 9, -1, 4, -6 };
//foreach (int num in numbers)
//{
//    Console.Write(num+ ",");
//}
//Console.WriteLine();

////2. Списки (List): Создайте список строк и добавьте в него несколько элементов произвольных имен.

//List<string> names = new List<string>
//{
//    "Иван",
//    "Алиса",
//    "Михаил",
//    "Елена",
//    "Олег"
//};
//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}
//Console.WriteLine();

////3.Инициализация стека целых чисел и добавление нескольких элементов:

//Stack<int> intStack = new Stack<int>();
//intStack.Push(10);
//intStack.Push(20);
//intStack.Push(30);
//foreach (int num in intStack)
//{
//    Console.WriteLine(num);
//}
//Console.WriteLine();

////4.Демонстрация операций добавления и извлечения элементов из стека:
//Console.WriteLine("Элементы в стеке:");
//foreach (int item in intStack)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("\nИзвлечение элементов из стека:");
//Console.WriteLine(intStack.Pop()); // Извлечение и вывод последнего элемента
//Console.WriteLine(intStack.Peek()); // Вывод последнего элемента без извлечения
//Console.WriteLine();

////5.Создание очереди строк и добавление в нее элементов:

//Queue<string> stringQueue = new Queue<string>();
//stringQueue.Enqueue("Яблоко");
//stringQueue.Enqueue("Груша");
//stringQueue.Enqueue("Апельсин");
//foreach (string num in stringQueue)
//{
//    Console.WriteLine(num);
//}
//Console.WriteLine();

////6.Создание словаря, связывающего строки с целыми числами:

//Dictionary<string, int> ageDictionary = new Dictionary<string, int>();
//ageDictionary["Alice"] = 25;
//ageDictionary["Bob"] = 30;
//int aliceAge = ageDictionary["Alice"]; 
//if (ageDictionary.ContainsKey("Charlie"))
//{
//    int charlieAge = ageDictionary["Charlie"]; 
//}
//foreach (KeyValuePair<string, int> pair in ageDictionary)
//{
//    Console.WriteLine($"Имя: {pair.Key}, Возраст: {pair.Value}");
//}
//Console.WriteLine();

////7.Создание множества целых чисел и добавление в него элементов:

//HashSet<int> intSet = new HashSet<int>();
//intSet.Add(10);
//intSet.Add(20);
//intSet.Add(30);
//intSet.Add(40);
//foreach (int num in intSet)
//{
//    Console.WriteLine(num);
//}
//Console.WriteLine();

////8.Создание коллекции KeyValuePair, связывающей имена и возраст, и работа с ней:

//List<KeyValuePair<string, int>> nameAgeList = new List<KeyValuePair<string, int>>();
//nameAgeList.Add(new KeyValuePair<string, int>("Иван", 25));
//nameAgeList.Add(new KeyValuePair<string, int>("Мария", 30));
//nameAgeList.Add(new KeyValuePair<string, int>("Петр", 35));

//foreach (KeyValuePair<string, int> pair in nameAgeList)
//{
//    Console.WriteLine($"Имя: {pair.Key}, Возраст: {pair.Value}");
//}



//Урок 2
//. Календарь событий:
//Разработайте календарь событий. События могут быть добавлены,удалены и просмотрены. Используйте List или Diconary для хранения событий.

using Lesson16_DZ__Коллекции;

List<Event> eventList = new List<Event>();

while (true)
{
    Console.Clear();
    Console.WriteLine("Меню:\n" +
        "1 - Добавить событие\n" +
        "2 - Удалить событие\n" +
        "3 - Просмотреть список событий");
    Console.Write("Выберите пункт меню: ");

    int n;
    if (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.WriteLine("Некорректный ввод. Нажмите Enter, чтобы продолжить.");
        Console.ReadLine();
        continue;
    }

    switch (n)
    {
        case 1:
            {
                Console.Write("Введите название события: ");
                string name = Console.ReadLine()!;
                eventList.Add(new Event { Name = name });
                Console.WriteLine("Событие добавлено.");
                Console.ReadLine();
            }
            break;
        case 2:
            {
                if (eventList.Count == 0)
                {
                    Console.WriteLine("Список событий пуст.");
                    Console.ReadLine();
                    break;
                }

                Console.WriteLine("Список событий:");
                for (int i = 0; i < eventList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {eventList[i].Name}");
                }
                Console.Write("Введите номер события, которое нужно удалить: ");

                int index;
                if (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > eventList.Count)
                {
                    Console.WriteLine("Некорректный ввод. Нажмите Enter, чтобы продолжить.");
                    Console.ReadLine();
                    break;
                }

                Event eventToRemove = eventList[index - 1];
                eventList.RemoveAt(index - 1);
                Console.WriteLine($"Событие \"{eventToRemove.Name}\" удалено.");
                Console.ReadLine();
            }
            break;
        case 3:
            {
                if (eventList.Count == 0)
                {
                    Console.WriteLine("Список событий пуст.");
                    Console.ReadLine();
                    break;
                }

                Console.WriteLine("Список событий:");
                for (int i = 0; i < eventList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {eventList[i].Name}");
                }
                Console.ReadLine();
            }
            break;
        default:
            Console.WriteLine("Некорректный ввод. Нажмите Enter, чтобы продолжить.");
            Console.ReadLine();
            break;
    }
}