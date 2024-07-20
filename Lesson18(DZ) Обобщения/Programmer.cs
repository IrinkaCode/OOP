using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_DZ__Обобщения
{
    public class Programmer<T, K, M> : Employee<T, K, M>
    {
        public string? ProgrammingLanguage { get; set; }
        public List<string>? Projects { get; set; } = new();
        public string? Specialization { get; set; }
    }
}
