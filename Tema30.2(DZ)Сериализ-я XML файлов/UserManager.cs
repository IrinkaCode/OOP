using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Tema30._2_DZ_Сериализ_я_XML_файлов
{
    public class UserManager
    {
        private List<User> users = new List<User>();
        private const string filePath = "users.xml";

        public void LoadUsers()
        {
            if (File.Exists(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    users = (List<User>)serializer.Deserialize(fs);
                }
            }
        }

        public void SaveUsers()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(fs, users);
            }
        }

        public void RegisterUser(string name, int age)
        {
            if (users.Exists(u => u.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Пользователь с таким именем уже существует.");
                return;
            }

            users.Add(new User { Name = name, Age = age });
            Console.WriteLine("Пользователь успешно зарегистрирован.");
        }

        public bool AuthenticateUser(string name)
        {
            return users.Exists(u => u.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public void DisplayUsers()
        {
            foreach (var user in users)
            {
                Console.WriteLine($"Имя: {user.Name}, Возраст: {user.Age}");
            }
        }
    }
}
