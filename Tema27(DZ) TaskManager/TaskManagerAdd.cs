using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Tema27_DZ__TaskManager.User;

namespace Tema27_DZ__TaskManager
{
    public class TaskManagerApp
    {
        public static void Main(string[] args)
        {
            // Пример создания пользователей
            User admin = new User { UserId = 1, Username = "admin", Password = "admin123", Role = UserRole.Administrator};
            User user1 = new User { UserId = 2, Username = "user1", Password = "user123", Role = UserRole.RegularUser };

            // Пример логина пользователя
            admin.Login();
            user1.Login();

            // Пример создания задачи
            Task task1 = new Task { TaskId = 1, Title = "Task 1", Description = "First task description", Status = (TaskStatus)Status.InProgress, Priority = 1, Deadline = DateTime.Now.AddDays(5) };

            task1.Assign(user1);
            Console.WriteLine($"Задача создана");

            // Пример создания проекта и добавления задачи
            Project project1 = new Project { ProjectId = 1, Title = "Project 1", Description = "First project description" };

            project1.AddTask(task1);
            Console.WriteLine($"Проект создан");

            // Генерация отчетов
            ReportGenerator reportGenerator = new ReportGenerator();
            reportGenerator.GenerateTaskReport(task1);
            reportGenerator.GenerateProjectReport(project1);

            // Пример выхода пользователя
            admin.Logout();
            user1.Logout();
        }
    }
}

