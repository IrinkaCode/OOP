using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_DZ_Методы_расширения._Анонимные_типы._Кортежи_
{
    record Student(string FullName, int GroupNumber, int[] Grades)
    {
        public double AverageGrade => Grades.Average();
    }
}
