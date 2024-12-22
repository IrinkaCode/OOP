//Задание: Учетная запись пользователя.
//Создайте систему для регистрации и аутентификации пользователей в вашем приложении. Сохраняйте учетные записи пользователей в XML-файле. Реализуйте процесс регистрации новых пользователей и аутентификации существующих.
//Все это сделать через консоль.
//● Пользователь может создавать новых пользователей, указывая имя и возраст. В этот момент в программе создается новый пользователь и записывается в список.
//● Также должна быть возможность сохранить данные пользователей.
//● Должна быть возможность вывести сохраненные данные пользователей на консоль используя десериализацию, цикл foreach и так далее.

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Tema30._2_DZ_Сериализ_я_XML_файлов;

class Program
{
    private const string FilePath = "users.xml";
    private static List<User> users = new List<User>();

    static void Main(string[] args)
    {
        LoadUsers();

        while (true)
        {
            Console.WriteLine("1. Регистрация");
            Console.WriteLine("2. Аутентификация");
            Console.WriteLine("3. Вывести всех пользователей");
            Console.WriteLine("4. Выход");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RegisterUser();
                    break;
                case "2":
                    AuthenticateUser();
                    break;
                case "3":
                    DisplayUsers();
                    break;
                case "4":
                    SaveUsers();
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                    break;
            }
        }
    }

    private static void LoadUsers()
    {
        if (File.Exists(FilePath))
        {
            using (var stream = new FileStream(FilePath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
                users = (List<User>)serializer.Deserialize(stream);
            }
        }
    }

    private static void SaveUsers()
    {
        using (var stream = new FileStream(FilePath, FileMode.Create))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            serializer.Serialize(stream, users);
        }
    }

    private static void RegisterUser()
    {
        Console.Write("Введите имя: ");
        var name = Console.ReadLine();

        Console.Write("Введите возраст: ");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            var user = new User { Name = name, Age = age };
            users.Add(user);
            Console.WriteLine("Пользователь успешно зарегистрирован!");
        }
        else
        {
            Console.WriteLine("Неверный возраст. Попробуйте еще раз.");
        }
    }

    private static void AuthenticateUser()
    {
        Console.Write("Введите имя для аутентификации: ");
        var name = Console.ReadLine();

        var user = users.FirstOrDefault(u => u.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (user != null)
        {
            Console.WriteLine($"Аутентификация успешна! Имя: {user.Name}, Возраст: {user.Age}");
        }
        else
        {
            Console.WriteLine("Пользователь не найден.");
        }
    }

    private static void DisplayUsers()
    {
        if (users.Count == 0)
        {
            Console.WriteLine("Пользователи не найдены.");
            return;
        }

        Console.WriteLine("Список зарегистрированных пользователей:");
        foreach (var user in users)
        {
            Console.WriteLine($"Имя: {user.Name}, Возраст: {user.Age}");
        }

    }
}