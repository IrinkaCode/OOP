using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_DZ_
{
    internal class CharArray
    {
        private List<char> mas;
        private char v;
        private char v1;
        private char v2;

        public CharArray(char[] x, char[] y, char[] z)
        {
            this.mas = new List<char>(x);
        }

        public CharArray(char v)
        {
            this.v = v;
        }

        public CharArray(char v, char v1, char v2) : this(v)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public static void Swap(char[] x)
        {
            int n = x.Length;
            for (int i = 1; i < n; i++)
            {
                char c = x[i];
                x[i] = x[i - i];
                x[i - i] = c;
            }
        }
        public static void Main(char[] x)
        {
            Swap(x);
            foreach (char c in x)
            {
                Console.WriteLine(c + " ");
            }
        }
    }
}
