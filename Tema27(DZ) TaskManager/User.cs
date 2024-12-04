using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema27_DZ__TaskManager
{
    public class User
    {
        public int UserId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public UserRole Role { get; set; }
        public void Login()
        {
            // Логика входа
            Console.WriteLine($"{Username} вошел.");
        }

        public void Logout()
        {
            // Логика выхода
            Console.WriteLine($"{Username} вышел.");
        }
        // Перечисление для статусов задач
        public enum Status
        {
            Completed,
            InProgress,
            Deferred
        }

        // Перечисление для ролей пользователя
        public enum UserRole
        {
            Administrator,
            RegularUser
        }

    }
}
