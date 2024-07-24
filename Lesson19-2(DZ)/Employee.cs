using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson19_2_DZ_;

namespace Lesson19_2_DZ_
{

    public class Employee : IComparable<Employee>, IEnumerable
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Task> Tasks { get; set; }

        public int CompareTo(Employee other)
        {
            int taskCountComparison = this.Tasks.Count.CompareTo(other.Tasks.Count);
            if (taskCountComparison != 0)
                return taskCountComparison;

            int priorityComparison = this.Tasks.Select(t => t.Priority).Min().CompareTo(other.Tasks.Select(t => t.Priority).Min());
            if (priorityComparison != 0)
                return priorityComparison;

            return this.Name.CompareTo(other.Name);
        }

        public IEnumerator<Task> GetEnumerator()
        {
            return this.Tasks.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}


