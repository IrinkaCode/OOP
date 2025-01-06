using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema22_DZ__Практика
{
    internal interface IUser
    {
        public int Id { get; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
