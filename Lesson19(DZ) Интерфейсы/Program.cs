// Создать консольное приложение, которое позволяет пользователю управлять задачами и событиями в календаре, используя интерфейсы,классы и перечисления.
using Lesson19_DZ__Интерфейсы;
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
                Lesson19_DZ__Интерфейсы.Task task = new Lesson19_DZ__Интерфейсы.Task
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
                    foreach (Lesson19_DZ__Интерфейсы.Task t in taskManager.Tasks)
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
                        Lesson19_DZ__Интерфейсы.Task task = new Lesson19_DZ__Интерфейсы.Task
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
