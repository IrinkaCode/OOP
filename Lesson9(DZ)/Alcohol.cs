using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_DZ_
{
    public class Alcohol:Liquid 
    {
        private double _strength;

        public double Strength
        {
            get { return _strength; }
            set { _strength = value; }
        }

        public Alcohol(string name, double density, double strength) : base(name, density)
        {
            _strength = strength;
        }

        public void ChangeStrength(double newStrength)
        {
            _strength = newStrength;
        }
    }
}
