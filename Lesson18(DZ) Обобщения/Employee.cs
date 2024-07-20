using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_DZ__Обобщения
{
    public class Employee<T, K, M> : Person<T, K, M>
    {
        public int EmployeeId { get; set; }
        public string? Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
    }
}
