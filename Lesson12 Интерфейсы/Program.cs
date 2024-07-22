﻿//using Lesson12_Интерфейсы;

//Person person=new Person();
//person.Name = "Вася";
//person.Move();

//Car car=new Car();
//car.Name = "Мерседес";
//car.Move(); 


//using Lesson12_Интерфейсы;
//using System.Diagnostics.Tracing;
//using System.IO;


//TaskManager taskManager = new TaskManager();
//while (true)
//{
//    Console.Clear();
//    Console.WriteLine("Меню:\n" +
//        "1- Создать задачу\n" +
//        "2- Создать событие\n" +
//        "3- Удалить задачу или событие по названию" +
//        "4- Редактировать" +
//        "5- Сохранить" +
//        "6- Загрузить");
//    if (taskManager.Tasks.Count != 0 || taskManager.Events.Count != 0)
//    {

//        Console.WriteLine("Поменять сортировку: 1 - по дате 2 - по приоритету");
//        int m;
//        int.TryParse(Console.ReadLine(), out m);
//        switch (m)
//        {
//            case 1:
//                {
//                    taskManager.Events.Sort();
//                    taskManager.Tasks.Sort();
//                }
//                break;
//            case 2:
//                {

//                }
//                break;
//        }
//    }
//    taskManager.Events.Sort();
//    taskManager.Tasks.Sort(new TaskPriorityComparer());

//    taskManager.Print();
//    Console.WriteLine("Выберите вариант: ");
//    int n;
//    int.TryParse(Console.ReadLine(), out n);
//    switch (n)
//    {
//        case 1:
//            {
//                Console.Write("Введите название задачи: ");
//                string name = Console.ReadLine()!;
//                Console.Write("Введите дату задачи: ");
//                DateTime date = DateTime.Parse(Console.ReadLine()!);
//                Console.WriteLine("Введите приоритет: Low, Medium,High");
//                string priorityString = Console.ReadLine()!;
//                Priority priority = (Priority)Enum.Parse(typeof(Priority), priorityString);
//                Lesson12_Интерфейсы.Task task = new Lesson12_Интерфейсы.Task
//                {
//                    Name = name,
//                    DueDate = date,
//                    Priority = priority
//                };
//                taskManager.AddTask(task);
//            }
//            break;
//        case 2:
//            {
//                Console.Write("Введите название задачи: ");
//                string name = Console.ReadLine()!;
//                Console.Write("Введите дату задачи: ");
//                DateTime date = DateTime.Parse(Console.ReadLine()!);
//                Console.WriteLine("Введите приоритет: Low, Medium,High");
//                string priorityString = Console.ReadLine()!;
//                Priority priority = (Priority)Enum.Parse(typeof(Priority), priorityString);
//                Console.Write("Введите местоположение: ");
//                string location = Console.ReadLine()!;
//                Event @event = new Event
//                {
//                    Name = name,
//                    DueDate = date,
//                    Priority = priority,
//                    Location = location
//                };
//                taskManager.AddEvent(@event);
//            }
//            break;
//        case 3:
//            {
//                Console.Write("Введите название задачи: ");
//                string name = Console.ReadLine()!;
//                taskManager.RemoveTaskEvent(name);
//            }
//            break;
//        case 4:
//            {

//            }
//            break;
//        case 5:
//            {

//            }
//            break;
//        case 6:
//            {

//            }
//            break;
//    }
//}

using Lesson12_Интерфейсы;
using System.Diagnostics.Tracing;
using System.IO;

TaskManager taskManager = new TaskManager();
while (true)
{
    Console.Clear();
    Console.WriteLine("Меню:\n" +
        "1-Создать задачу\n" +
        "2-Создать событие\n" +
        "3-Удалить задачу или событие по названию\n" +
        "4-Редактировать\n" +
        "5-Сохранить\n" +
        "6-Загрузить");
    if (taskManager.Tasks.Count != 0 || taskManager.Events.Count != 0)
    {
        Console.Write("Поменять сортировку: 1- по дату 2 - по приоритету:");
        int m;
        int.TryParse(Console.ReadLine(), out m);
        switch (m)
        {
            case 1:
                {
                    taskManager.Events.Sort();
                    taskManager.Tasks.Sort();
                }
                break;
            case 2:
                {
                    taskManager.Tasks.Sort(new TaskPriorityComparer());
                }
                break;
        }
        taskManager.Print();
    }
    Console.Write("Выберите вариант:");
    int n;
    int.TryParse(Console.ReadLine(), out n);
    switch (n)
    {
        case 1:
            {
                Console.Write("Введите название задачи:");
                string name = Console.ReadLine()!;
                Console.Write("Введите дату задачи:");
                DateTime date = DateTime.Parse(Console.ReadLine()!);
                Console.WriteLine("Введите приритет Low,Medium,High");
                string priorityString = Console.ReadLine()!;
                Priority priority = (Priority)Enum.Parse(typeof(Priority), priorityString);
                Lesson12_Интерфейсы.Task task = new Lesson12_Интерфейсы.Task
                {
                    Name = name,
                    DueDate = date,
                    Priority = priority
                };
                taskManager.AddTask(task);
            }
            break;
        case 2:
            {
                Console.Write("Введите название задачи:");
                string name = Console.ReadLine()!;
                Console.Write("Введите дату задачи:");
                DateTime date = DateTime.Parse(Console.ReadLine()!);
                Console.WriteLine("Введите приритет Low,Medium,High");
                string priorityString = Console.ReadLine()!;
                Priority priority = (Priority)Enum.Parse(typeof(Priority), priorityString);
                Console.Write("Введите местоположение:");
                string location = Console.ReadLine()!;
                Event @event = new Event
                {
                    Name = name,
                    DueDate = date,
                    Priority = priority,
                    Location = location
                };
                taskManager.AddEvent(@event);
            }
            break;
        case 3:
            {
                Console.Write("Введите название задачи:");
                string name = Console.ReadLine()!;
                taskManager.RemoveTaskEvent(name);
            }
            break;
        case 4:
            {
                Console.Write("Введите название задачи:");
                string name = Console.ReadLine()!;
                int index = taskManager.findTask(name);
                Console.Write("Введите новое название задачи:");
                name = Console.ReadLine()!;
                Console.Write("Введите дату задачи:");
                DateTime date = DateTime.Parse(Console.ReadLine()!);
                Console.WriteLine("Введите приритет Low,Medium,High");
                string priorityString = Console.ReadLine()!;
                Priority priority = (Priority)Enum.Parse(typeof(Priority), priorityString);
                taskManager.Tasks[index].Name = name;
                taskManager.Tasks[index].DueDate = date;
                taskManager.Tasks[index].Priority = priority;
            }
            break;
        case 5:
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open("tasks.dat", FileMode.OpenOrCreate)))
                {
                    foreach (Lesson12_Интерфейсы.Task t in taskManager.Tasks)
                    {
                        writer.Write(t.Name);
                        writer.Write(t.DueDate.ToString());
                        writer.Write(t.Priority.ToString());
                    }
                }
                break;
            }
        case 6:
            {
                using (BinaryReader reader = new BinaryReader(File.Open("tasks.dat", FileMode.Open)))
                {
                    while (reader.PeekChar() > -1)
                    {
                        string name = reader.ReadString();
                        DateTime date = DateTime.Parse(reader.ReadString());
                        Priority priority = (Priority)Enum.Parse(typeof(Priority), reader.ReadString());
                        Lesson12_Интерфейсы.Task task = new Lesson12_Интерфейсы.Task
                        {
                            Name = name,
                            DueDate = date,
                            Priority = priority
                        };
                        taskManager.Tasks.Add(task);
                    }
                }
            }
            break;

    }
}
