using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_DZ_
{
    internal class StringArray
    {
     
        private string[] massiv1;
        private string[] massiv2;
        private int lenght;

        public StringArray(int lengh)
        {
            lenght = lengh;
            massiv1 = new string[lengh];
            massiv2 = new string[lengh];
        }
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= lenght)
                {
                    throw new IndexOutOfRangeException("Массив больше заданной длины");
                }
                return massiv1[index];
            }

            set
            {
                if (index < 0 || index >= lenght)
                {
                    throw new ArgumentOutOfRangeException("Массив больше заданной длины");
                }
                massiv1[index] = value;
            }

        }
        public string GetSecondArrayElement(int index)
        {
            if (index < 0 || index >= lenght)
            {
                throw new IndexOutOfRangeException("Индекс находится за пределами массива");
            }
            return massiv2[index];
        }

        public void SetSecondArrayElement(int index, string value)
        {
            if (index < 0 || index >= lenght)
            {
                throw new ArgumentOutOfRangeException("Индекс находится за пределами массива");
            }
            massiv2[index] = value;
        }
        public void Sum()
        {
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine($"Сумма элементов под индексом {i}: {massiv1[i] + massiv2[i]}");
            }
        }
        public string Contac()
        {
            string result = "";
            foreach (string str in massiv1)
            {
                result += str;
            }
            return result;
        }

    }

}

    

