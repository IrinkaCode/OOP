using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_DZ_
{
    public class Liquid
    {
        private string _name;
        private double _density;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Density
        {
            get { return _density; }
            set { _density = value; }
        }

        public Liquid(string name, double density)
        {
            _name = name;
            _density = density;
        }

        public void ChangeDensity(double newDensity)
        {
            _density = newDensity;
        }
    }
}
