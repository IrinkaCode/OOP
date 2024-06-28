using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    internal class Person
    {
        public string FIO { get; set; }
        public int Balance { get; set; }
        public static bool operator == (Person P1, Person P2)
        {
            return P1.Balance == P2.Balance;
        }
        public static bool operator !=(Person P1, Person P2)
        {
            return P1.Balance != P2.Balance;
        }
        public static int operator + (Person P1, Person P2)
        {
            return P1.Balance + P2.Balance;
        }
        public static int operator - (Person P1, Person P2)
        {
            return Math.Abs(P1.Balance - P2.Balance);
        }
    }
}
