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
        private static readonly string FilePath = "userData.txt";

        private static int userCount = 0;
        private static readonly List<string> ExistingLogins = new List<string>();
        private static readonly List<string> ExistingNames = new List<string>();

        public int Id { private get; set; }
        public string Name { private get; set; }
        public string Login { private get; set; }
        public string Password { private get; set; }

     
        public string Username { get; set; }
        public string Email { get; set; }

        public User(string name, string login, string password)
        {
            IsDataExists isDataExists = data =>
            {
                if (string.IsNullOrWhiteSpace(data))
                    throw new ArgumentException("Нет данных");
                return data;
            };


            if (ExistingLogins.Contains(isDataExists(login)))
            {
                throw new Exception("Пользователь с таким логином уже существует.");
            }

            if (ExistingNames.Contains(isDataExists(name)))
            {
                throw new Exception("Пользователь с таким именем уже существует.");
            }


            Id = ++userCount;
            Name = isDataExists(name);
            Login = isDataExists(login);
            Password = isDataExists(password);

            SaveData();
            ExistingLogins.Add(Login);
            ExistingNames.Add(Name);
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

                        var user = new User(data[1], data[2], data[3]) { Id = int.Parse(data[0]) };
                        users.Add(user);
                        ExistingLogins.Add(data[2]); 
                        ExistingNames.Add(data[1]); 
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
    

        
    



