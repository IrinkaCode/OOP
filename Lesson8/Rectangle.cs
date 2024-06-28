using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    internal class Rectangle:D2
    { private double wigth;
        public double Width
        {
            get {  return wigth; }
            set { if (value > 0) wigth = value; }
        }
        private double height;
        public double Height
        {
            get { return wigth; }
            set { if (value > 0) wigth = value; }
        }
        public override double getArea()
        {
            return Width*Height;
        }
        public override double getPerimetr()
        {
            return 2 * (Width + Height);
        }
    }
}
