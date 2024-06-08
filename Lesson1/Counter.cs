//Описать класс, реализующий десятичный счетчик, который может увеличивать или уменьшать свое значение на единицу в заданном диапазоне. Предусмотреть инициализацию счетчика значениями по умолчанию и произвольными значениями. Счетчик имеет два метода: увеличения и уменьшения, — и свойство, позволяющее получить его текущее состояние. Написать программу, демонстрирующую все возможности класса.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lesson1
{
    internal class Counter
    {
        private int count;//поля класса
        private int max, min;


        public Counter()//конструктор по умолчанию
        {
            this.min = -10;
            this.max = 10;
            Count = 8;
        }
        public Counter(int c,int min,int max)//конструктор с параметрами
        {
            this.min = min;
            this.max = max;
            Count = c;
        }
        public int Count//свойство класса
        {
            get { return count; }
            set { if (value <= max && value>=min) this.count = value;}
        }
        public void inc()
        {
            this.Count++;
        }
        public void dec()
        {
            this.Count--;
        }

    }
}
