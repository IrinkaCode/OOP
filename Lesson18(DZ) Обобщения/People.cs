using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_DZ__Обобщения
{
    public abstract class People<T,K,M>
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public T? Gender { get; set; }
        public K? Race { get; set; }
        public M? EyeColor { get; set; }
    }
}
