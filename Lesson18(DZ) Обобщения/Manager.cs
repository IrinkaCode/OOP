using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_DZ__Обобщения
{
    public class Manager<T, K, M> : Employee<T, K, M>
    {
        public string? ManagementArea { get; set; }
        public int SubordinatesCount { get; set; }
        public int ManagementExperience { get; set; }
    }
}
