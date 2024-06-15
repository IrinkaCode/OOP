//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Lesson2
{
    internal class Sklad
    {
        private int number;//номер склада
        private string lastName;//фамилия директора
        private double maxVolume;//максимальный обьем материалов
        private double current;//текущий обьем материалов

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public double MaxVolume
        {
            get { return maxVolume; }
            set
            {
                if (value > 0) maxVolume = value;
                else throw new Exception("Введите правильный обьем");
            }
        }
        public double Current
        {
            get { return current; }
            set
            {
                if (value > maxVolume - current)
                {
                    current = maxVolume;
                    Console.WriteLine("Склад перегружен");
                }
                else if (current + value < 0)
                {
                    Console.WriteLine("Недостаток на складе!!!");
                }
                else current += value;
            }
        }
        public void AddMaterials(double volume)
        {
            Current = volume;
        }

        // Вывезенные материалы, м3
        public void RemoveMaterials(double volume)
        {
            Current = -volume;
        }
        public void Print()
        {
            Console.WriteLine($"Можно завести {maxVolume - current:F2}. В Наличии {current}");
        }

    }

}
