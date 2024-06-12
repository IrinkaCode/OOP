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
        private double maxVolume;//максимамальный обьем материалов
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
            set { maxVolume = value; }
        }
        public double Current
        {
            get { return current; } 
            set { current = value; }
        }

        public Sklad(int number, string lastName, double maxVolume, double current)
        {
            Number = number;
            LastName = lastName;
            MaxVolume = maxVolume;
            Current = 0;
        }
        public void AddMaterials(double volume)
        {
            if (current + volume <= maxVolume)
            {
                current += volume;
                Console.WriteLine($"На склад №{number} под управлением {lastName} завезено {volume} м3 пиломатериалов.");
            }
            else
            {
                Console.WriteLine($"Невозможно завезти {volume} м3 пиломатериалов на склад №{number} под управлением {lastName}. Превышен максимальный объем.");
            }
        }

        // Вывезенные материалы, м3
        public void RemoveMaterials(double volume)
        {
            if (current - volume >= 0)
            {
                current -= volume;
                Console.WriteLine($"Со склада №{number} под управлением {lastName} вывезено {volume} м3 пиломатериалов.");
            }
            else
            {
                Console.WriteLine($"Невозможно вывезти {volume} м3 пиломатериалов со склада №{number} под управлением {lastName}. Недостаточно материалов.");
            }
        }

        // Выдача сообщения, сколько можно еще завезти материалов и сколько есть в наличии
        public void DisplayInfo()
        {
            double freeVolume = maxVolume - current;
            Console.WriteLine($"На складе №{number} под управлением {lastName}:");
            Console.WriteLine($"Максимальный объем: {maxVolume} м3");
            Console.WriteLine($"Текущий объем: {current} м3");
            Console.WriteLine($"Свободный объем: {freeVolume} м3");
        }


    }

}
