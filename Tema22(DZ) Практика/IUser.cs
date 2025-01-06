using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema22_DZ__Практика
{
    internal interface IUser
    {
        public int Id { set; }
        public string Username { set; }
        public string Password { set; }
        public string Email { set; }
    }
}
