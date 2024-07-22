using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14._1
{
    public delegate bool IsDataExists(User user);
    public class User : IUser
    {
        public int Id { get; set; }
        public string? Name { get ; set ; }
        public string? Login { get ; set ; }
        public string? Password { get ; set; }

        public User(string? name, string? login, string? password)
        {
            Name = name;
            Login = login;
            Password = password;
        }
    }
}
