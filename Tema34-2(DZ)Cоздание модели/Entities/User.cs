using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema34_2_DZ_Cоздание_модели.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();

        public User() { }

        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }
    }
}
