using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_DZ__Интерфейсы
{
    internal class TaskPriorityComparer : IComparer<Task>
    {
        public int Compare(Task? x, Task? y)
        {
            if (x!.Priority > y!.Priority) return 1;
            else if (y.Priority > x.Priority) return -1;
            else return 0;
        }
    }
}
