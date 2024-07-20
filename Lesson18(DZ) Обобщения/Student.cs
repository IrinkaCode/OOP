using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_DZ__Обобщения
{
    public class Student<T, K, M> : Person<T, K, M>
    {
        public int Course { get; set; }
        public string? Specialization { get; set; }
        public double AverageGrade { get; set; }
    }
}
