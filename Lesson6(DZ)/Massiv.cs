using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_DZ_
{
    internal class Massiv
    {
        private List<int> mas;

        public Massiv(int n)
        {
            this.mas = new List<int>(n);
        }
        public static double Avg(int[] n)
        {
            double sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += n[i];
            }
            double average = sum / n.Length;
            return average;


        }
        public static void Main(int[] mas)
        {
            double averege = Avg(mas);
            Console.WriteLine($"{averege:F2}");
        }
    }
}



  

