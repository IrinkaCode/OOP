using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_DZ_
{
    public class Driver
    {
        public string Name { get; set; }
        public bool IsWorking { get; set; } = true;
        public List<Trip> CompletedTrips { get; set; } = new List<Trip>();
        public void RequestRepair()
        {
            Console.WriteLine($"{Name} обратился с просьбой о ремонте.");
        }

    }
}
