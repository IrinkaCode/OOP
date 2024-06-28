using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    internal class Cube:D3
    {
        public double Height { get; set; }
        public override double getArea()
        {
            return 4*Height * Height;
        }
        public override double getVolume()
        {
            return Height * Height* Height;
        }
    }
}
