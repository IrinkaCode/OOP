using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    internal class Complex
    {
        public double Re { get; set; }
        public double Im { get; set; }
        public static bool operator ==(Complex A, Complex B)
        {
            return (A.Re == B.Re && A.Im == B.Im);
        }
        public static bool operator !=(Complex A, Complex B)
        {
            return (A.Re == B.Re || A.Im == B.Im);
        }
        public static Complex operator +(Complex A, Complex B)
        {
            return new Complex { Re = A.Re + B.Re, Im = A.Im + B.Im };
        }
        public static Complex operator - (Complex A, Complex B)
        {
            return new Complex 
            { 
                Re = A.Re - B.Re, Im = A.Im - B.Im 
            };
        }
        public static Complex operator * (Complex A, Complex B)
        {
            return new Complex 
            { 
                Re = (A.Re * B.Re - A.Im * B.Im),
                Im = (A.Re * B.Im + A.Im * B.Re)
            };
        }
        public static Complex operator / (Complex A, Complex B)
        {
            return new Complex
            {
                Re = (A.Re * B.Re + A.Im * B.Im) / (A.Re * A.Re + B.Re * B.Re),
                Im = (B.Re * A.Im - A.Re * B.Im) / (A.Re * A.Re + B.Re * B.Re)
            };
        }
        public override string? ToString()
        {
            if (Im < 0)
                return $"{Re}-{-Im}i";
            return $"{Re}+{Im}i";
        }

    }

}
