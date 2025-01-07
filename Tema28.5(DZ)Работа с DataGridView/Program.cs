// Работа с DataGridView
//Список задач.
//Создайте список задач с помощью DataGridView.
//У каждой задачи должна быть колонка:
//● Названия
//● Статуса
//● Времени
//● Приоритета
//Реализуйте возможность добавления новых задач, отмечания задач как выполненных

using System;
using System.Collections.Generic;

class Task
{
    public string? Name { get; set; }
    public string? Status { get; set; }
    public string? Time { get; set; }
    public string? Priority { get; set; }

    public override string ToString()
    {
        return $"{Name} | {Status} | {Time} | {Priority}";
    }
}

class Program
{
    static List<Task> tasks = new List<Task>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Список задач:");
            DisplayTasks();
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Изменить статус задачи");
            Console.WriteLine("3. Выход");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ChangeTaskStatus();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Нажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void DisplayTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Нет задач.");
            return;
        }

        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }
    }

    static void AddTask()
    {
        Console.Write("Введите название задачи: ");
        string name = Console.ReadLine()!;

        Console.Write("Введите статус (Выполнена/В процессе/Не выполнена): ");
        string status = Console.ReadLine()!;

        Console.Write("Введите время: ");
        string time = Console.ReadLine()!;

        Console.Write("Введите приоритет (Низкий/Средний/Высокий): ");
        string priority = Console.ReadLine()!;

        tasks.Add(new Task { Name = name, Status = status, Time = time, Priority = priority });
        Console.WriteLine("Задача добавлена. Нажмите любую клавишу для продолжения...");
        Console.ReadKey();
    }

    static void ChangeTaskStatus()
    {
        Console.Write("Введите номер задачи для изменения статуса (начиная с 1): ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
        {
            var task = tasks[index - 1];
            task.Status = task.Status == "Выполнена" ? "Не выполнена" : "Выполнена";
            Console.WriteLine("Статус задачи изменен. Нажмите любую клавишу для продолжения...");
        }
        else
        {
            Console.WriteLine("Неверный номер задачи. Нажмите любую клавишу для продолжения...");
        }
        Console.ReadKey();
    }
}