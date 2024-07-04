using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_DZ_
{
    public class Rectangle:Pair
    {
        public Rectangle(double x, double y) : base(x, y)
        {

        }

        public double GetPerimeter()
        {
            return 2 * (GetX() + GetY());
        }

        public double GetArea()
        {
            return GetX() * GetY();
        }
    }
}
