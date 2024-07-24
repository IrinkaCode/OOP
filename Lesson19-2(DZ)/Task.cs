using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_2_DZ_
{
    public class Task : ICloneable
    {
        public string? Title { get; set; }
        public string? Priority { get; set; }
        public DateTime DueDate { get; set; }

        public object Clone()
        {
            return new Task
            {
                Title = this.Title,
                Priority = this.Priority,
                DueDate = this.DueDate
            };
        }
    }
}
