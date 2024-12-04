using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema27_DZ__TaskManager
{
    public abstract class TaskBase : ITask
    {
        public int TaskId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public TaskStatus Status { get; set; }
        public int Priority { get; set; }
        public DateTime Deadline { get; set; }
        public User? AssignedTo { get; set; }

        public virtual void Assign(User user)
        {
            this.AssignedTo = user;
        }

        public virtual void ChangeStatus(string newStatus)
        {
            this.Status = Status;
        }
    }
}
