using Lesson13_DZ__Абстрактные_классы;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson13_DZ__Абстрактные_классы
{
    abstract class Animal
    {
        public string? Name { get; set; }
        public int? Eats { get; set; }
        public abstract double CalculateFoodRequired();
    }
}
