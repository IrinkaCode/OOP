//using Lesson12_Интерфейсы;

//Person person=new Person();
//person.Name = "Вася";
//person.Move();

//Car car=new Car();
//car.Name = "Мерседес";
//car.Move(); 


using Lesson12_Интерфейсы;

TaskManager taskManager = new TaskManager();
while(true)
{
    Console.Clear();
    Console.WriteLine("Меню:\n" +
        "1-Создать задачу\n" +
        "2-Создать событие\n" +
        "3- Удалить задачу или событие по названию");
    Console.WriteLine("Поменять сортировку: 1 - по дате 2 - по приоритету");
    int m;
    int.TryParse(Console.ReadLine(), out m);
    switch(m)
    {
        case 1:
            {
                taskManager.Events.Sort();
                taskManager.Tasks.Sort();
            }
            break;
            case 2:
            {

            }
            break;
    }

    taskManager.Events.Sort();
    taskManager.Tasks.Sort(new TaskPriorityComparer());

    taskManager.Print();
    Console.WriteLine("Выберите вариант: ");
    int n;
    int.TryParse(Console.ReadLine(), out n);
    switch(n)
    {
        case 1 :
            {
                Console.Write("Введите название задачи: ");
                string name= Console.ReadLine()!;
                Console.Write("Введите дату задачи: ");
                DateTime date = DateTime.Parse(Console.ReadLine()!);
                Console.WriteLine("Введите приоритет: Low, Medium,High");
                string priorityString = Console.ReadLine()!;
                Priority priority=(Priority)Enum.Parse(typeof(Priority), priorityString);
                Lesson12_Интерфейсы.Task task = new Lesson12_Интерфейсы.Task
                {
                    Name = name,
                    DueDate = date,
                    Priority = priority
                };
                taskManager.AddTask(task);
            }
            break;
            case 2 :
            {
                Console.Write("Введите название задачи: ");
                string name = Console.ReadLine()!;
                Console.Write("Введите дату задачи: ");
                DateTime date = DateTime.Parse(Console.ReadLine()!);
                Console.WriteLine("Введите приоритет: Low, Medium,High");
                string priorityString = Console.ReadLine()!;
                Priority priority = (Priority)Enum.Parse(typeof(Priority), priorityString);
                Console.Write("Введите местоположение: ");
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
            case 3 :
            {
                Console.Write("Введите название задачи: ");
                string name = Console.ReadLine()!;
                taskManager.RemoveTaskEvent(name);
            }
            break;
            case 4 :
            {

            }
            break;
            case 5 :
            {

            }
            break;
    }
}