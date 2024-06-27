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

        private string[] mas;
        public StringArray(int n)
        {
            this.mas = new string[n];
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < mas.Length)
                    return mas[index];
                else throw new ArgumentOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < mas.Length)
                    mas[index] = value;
            }
        }
        public string[] Concat(string[] source)
        {
            string[] res = new string[mas.Length];
            for (int i = 0; i < mas.Length; i++)
            {
                res[i] = mas[i] + source[i];
            }
            return res;
        }
        public string[] Union(string[] source)
        {
            List<string> resultList = new List<string>(mas);
            foreach (string s in source)
            {
                if (!resultList.Contains(s))
                {
                    resultList.Add(s);
                }
            }
            return resultList.ToArray();
        }
        public void PrintElement(int index)
        {
            if (index >= 0 && index < mas.Length)
            {
                Console.WriteLine(mas[index]);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public void PrintAll()
        {
            foreach (string s in mas)
            {
                Console.WriteLine(s);
            }
        }
    }
}

        


       
    



    

