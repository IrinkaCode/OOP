using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Интерфейсы
{
    internal class Person : IMoveable
    {
        public string Name { get; set; }

        public void Move()
        {
            Console.WriteLine("Человек идет");
        }
    }
    struct Car : IMoveable
    {
        public string Name { get ; set ;}

        public void Move()
        {
            Console.WriteLine("Машина едет");
        }
    }
}
