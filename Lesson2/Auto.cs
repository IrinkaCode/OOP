using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Auto
    {
        private string? brand;//марка машины
        private double volume;//обьем бака
        private double expend;//расход бензина на 100 км
        private double current;//количество топлива в баке
        public double Current
        {
            get { return current; }
            set
            {
                if (value > volume - current)
                {
                    Console.Write("Перелил");
                    current = volume;
                }
                else current += value;
            }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public double Volume
        {
            get { return volume; }
            private set { if (value > 0) volume = value; }
        }

        public double Expend
        {
            get { return Expend; }
            set { if (value > 0) expend = value; }
        }
        public void Fide(double fide)
        {
            Current= fide;
        }
        public double Way(double km)
        {
            return km * expend / 100;
        }
        public double Remains()
        {
            return (current / expend) * 100;
        }

        public Auto(double current, string brand, double volume, double expend)
        {
           
            Brand = brand;
            Volume = volume;
            Expend = expend;
            Current = current;
        }
    }
}
