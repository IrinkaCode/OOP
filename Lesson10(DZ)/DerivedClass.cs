using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_DZ_
{
    public class DerivedClass:NumberClass
    {
        // Второе открытое целочисленное поле
        public int AnotherValue;

        // Переопределенный индексатор с двумя индексами
        public  int this[int field,int index]
        {
            get
            {
                int value = (field == 0) ? Value : AnotherValue;
                return (int)Math.Pow(10, index) * (value / (int)Math.Pow(10, index)) % 10;
            }
        }

        // Переопределенный индексатор с одним индексом
        public int this[int index]
        {
            get
            {
                return (this[0, index] + this[1, index]);
            }
        }
    }
}
