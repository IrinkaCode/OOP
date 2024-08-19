using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16.Console
{
    public class User
    {

        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime BirthDate { get; set; }

        //public override string? ToString()
        //{
        //    return $"{Id} {UserName} {FirstName} {SecondName} {Email} " +
        //        $"{Password} Дата регистрации:{RegistrationDate} Дата рождения:{BirthDate}";
        //}
  
    }
    public enum UserRole
    {
        Admin,
        Author,
        Reader
    }


}
