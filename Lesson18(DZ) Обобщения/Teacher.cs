using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_DZ__Обобщения
{
    public class Teacher<T, K, M> : Employee<T, K, M>
    {
        public string? Subject { get; set; }
        public int TeachingExperience { get; set; }
    }
}
