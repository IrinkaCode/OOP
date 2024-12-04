using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema27_DZ__TaskManager
{
    public class ReportGenerator : IReportable
    {
        public void GenerateTaskReport(Task task)
        {
            // ... логика генерации отчета по задаче ...
        }

        public void GenerateProjectReport(Project project)
        {
            // ... логика генерации отчета по проекту ...
        }
    }
}
