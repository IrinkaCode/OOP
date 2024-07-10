using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Всеядные животные

namespace Lesson13_DZ__Абстрактные_классы
{
    class Omnivorous : Animal
    {
        public override double CalculateFoodRequired()
        {
            return (double)Eats!;
        }
    }
}
