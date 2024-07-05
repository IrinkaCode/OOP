using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_DZ_
{
    public class Trip
    {
        public Avto AssignedAvto { get; set; }
        public Driver AssignedDriver { get; set; }
        public bool IsCompleted { get; set; } = false;
        public string Status { get; set; } = "В ожидании";

        public void CompleteTrip()
        {
            IsCompleted = true;
            Status = "Завершено";
            Console.WriteLine($"Поездка завешена.Статус авто: {AssignedAvto.Model} - {(AssignedAvto.IsAvailable ? "Доступен" : "Недоступен")}");
        }
    }
}
