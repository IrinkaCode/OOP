using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tema22_DZ__Практика
{
    public delegate string IsDataExists(string data);

    public class User : IUser
    {
        private static readonly string FilePath = "userData.txt"; // Путь к файлу с данными пользователей
        private static int userCount = 0; // Счетчик для автоматического присвоения ID
        private static readonly List<string> ExistingLogins = new List<string>(); // Список существующих логинов
        private static readonly List<string> ExistingNames = new List<string>(); // Список существующих имен

        public int Id { get; private set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        int IUser.Id => throw new NotImplementedException();

        public string Username { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public User(string name, string login, string password)
        {
            IsDataExists isDataExists = data =>
            {
                if (data == null)
                    throw new Exception("Нет данных");
                return data;
            };

            // Проверка на существование логина
            if (ExistingLogins.Contains(isDataExists(login)))
            {
                Console.WriteLine("Пользователь с таким логином уже существует.");
                return; // Завершение создания объекта, если логин уже существует
            }

            // Проверка на существование имени
            if (ExistingNames.Contains(isDataExists(name)))
            {
                Console.WriteLine("Пользователь с таким именем уже существует.");
                return; // Завершение создания объекта, если имя уже существует
            }

            // Увеличение счетчика пользователей и присвоение идентификатора
            Id = userCount++;
            Name = isDataExists(name);
            Login = isDataExists(login);
            Password = isDataExists(password);

            // Сохранение данных пользователя
            SaveData();
            ExistingLogins.Add(Login); // Добавление логина в список существующих
            ExistingNames.Add(Name); // Добавление имени в список существующих
        }

        private void SaveData()
        {
            var userData = $"{Id} {Name} {Login} {Password}";
            File.AppendAllText(FilePath, userData + Environment.NewLine);
        }

        public static List<User> LoadUsers()
        {
            var users = new List<User>();

            if (File.Exists(FilePath))
            {
                var lines = File.ReadAllLines(FilePath);

                foreach (var line in lines)
                {
                    var data = line.Split(' ');

                    if (data.Length == 4)
                    {
                        var user = new User(data[1], data[2], data[3]);
                        users.Add(user);
                        ExistingLogins.Add(data[2]); // Запоминаем существующий логин
                        ExistingNames.Add(data[1]); // Запоминаем существующее имя
                    }
                    else
                    {
                        Console.WriteLine($"Недостаточно данных для создания пользователя. Строка: {line}");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Файл {FilePath} не найден.");
            }
            return users;
        }
    }
            
}
    

        
    



