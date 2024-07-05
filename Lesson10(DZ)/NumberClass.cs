using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_DZ_
{
    public class NumberClass
    {
        // Открытое целочисленное поле
        public int Value;

        // Виртуальный индексатор
        public virtual int this[int index]
        {
            get
            {
                // Получение цифры в десятичном представлении числа
                return (int)Math.Pow(10, index) * (Value / (int)Math.Pow(10, index)) % 10;
            }
        }
    }
}
