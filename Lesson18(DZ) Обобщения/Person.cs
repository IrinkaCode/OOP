using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_DZ__Обобщения
{
    public class Person<T, K, M> : People<T, K, M>
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public T? Gender { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
