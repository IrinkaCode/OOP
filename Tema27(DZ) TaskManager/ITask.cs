using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema27_DZ__TaskManager
{
    public interface ITask
    {
        void Assign(User user);
        void ChangeStatus(string newStatus);
    }
}
