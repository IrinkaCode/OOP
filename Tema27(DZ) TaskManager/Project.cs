using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema27_DZ__TaskManager
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<Task> Tasks { get; set; } = new List<Task>();

        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            Tasks.Remove(task);
        }
    }
}
