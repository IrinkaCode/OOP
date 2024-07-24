//Создайте программу для управления списком сотрудников и их задачами.
//Вам нужно использовать все три интерфейса: ICloneable, IComparable, и
//IEnumerable.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Lesson19_2_DZ_;
using System.Threading.Tasks;
using System.Text;
using Task = Lesson19_2_DZ_.Task;


List<Employee> employees = new List<Employee>
{
            new Employee
            {
                Name = "Иван Иванов",
                Id = 1,
                Tasks = new List<Task>
                {
                    new Task { Title = "Task 1", Priority = "High", DueDate = new DateTime(2023, 5, 1) },
                    new Task { Title = "Task 2", Priority = "Medium", DueDate = new DateTime(2023, 6, 15) },
                    new Task { Title = "Task 3", Priority = "Low", DueDate = new DateTime(2023, 7, 31) }
                }
            },
            new Employee
            {
                Name = "Ирина Попова",
                Id = 2,
                Tasks = new List<Task>
                {
                    new Task { Title = "Task 4", Priority = "High", DueDate = new DateTime(2023, 4, 15) },
                    new Task { Title = "Task 5", Priority = "Medium", DueDate = new DateTime(2023, 6, 1) }
                }
            },
            new Employee
            {
                Name = "Семен Смирнов",
                Id = 3,
                Tasks = new List<Task>
                {
                    new Task { Title = "Task 6", Priority = "High", DueDate = new DateTime(2023, 5, 15) },
                    new Task { Title = "Task 7", Priority = "Low", DueDate = new DateTime(2023, 8, 1) },
                    new Task { Title = "Task 8", Priority = "Medium", DueDate = new DateTime(2023, 7, 1) }
                }
            }
        };

// Отображение списка сотрудников, их задач и глубоких копий задач
Console.WriteLine("Список сотрудников и их задачи:");
foreach (var employee in employees)
{
    Console.WriteLine($"Сотрудник: {employee.Name} (ID: {employee.Id})");
    foreach (var task in employee.Tasks)
    {
        Console.WriteLine($"  Задача: {task.Title} (Приоритет: {task.Priority}, Срок: {task.DueDate.ToString("d")})");
        var clonedTask = (Task)task.Clone();
        Console.WriteLine($"    Клонированная задача: {clonedTask.Title} (Приоритет: {clonedTask.Priority}, Срок: {clonedTask.DueDate.ToString("d")})");
    }
    Console.WriteLine();
}

// Сортировка списка сотрудников
employees.Sort();

Console.WriteLine("Отсортированный список сотрудников:");
foreach (var employee in employees)
{
    Console.WriteLine($"Сотрудник: {employee.Name} (ID: {employee.Id})");
}

// Перебор задач каждого сотрудника
Console.WriteLine("\nЗадачи каждого сотрудника:");
foreach (var employee in employees)
{
    Console.WriteLine($"Сотрудник: {employee.Name} (ID: {employee.Id})");
    foreach (var task in employee)
    {
        Console.WriteLine($"  Задача: {task.Title} (Приоритет: {task.Priority}, Срок: {task.DueDate.ToString("d")})");
    }
    Console.WriteLine();
}
    