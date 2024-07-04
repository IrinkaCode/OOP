using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_DZ_
{
    public class Pair
    {
        private double x;
        private double y;

        public Pair(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void SetX(double x)
        {
            this.x = x;
        }

        public void SetY(double y)
        {
            this.y = y;
        }

        public double GetX()
        {
            return this.x;
        }

        public double GetY()
        {
            return this.y;
        }

        public double Multiply()
        {
            return this.x * this.y;
        }
    }
}
