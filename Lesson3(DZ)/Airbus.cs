using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_DZ_
{
    internal class Airbus
    {
        private int numberFlight;
        private int firstClass;
        private int secondClass;
        private int thirdClass;

        public Airbus(int numberFlight, int firstClass, int secondClass, int thirdClass)
        {
            this.numberFlight = numberFlight;
            this.firstClass = firstClass;
            this.secondClass = secondClass;
            this.thirdClass = thirdClass;
        }
        public void PassengersExited(int firstClass, int secondClass, int thirdClass)
        {
            this.firstClass -= firstClass;
            this.secondClass -= secondClass;
            this.thirdClass -= thirdClass;
        }
        public void TicketsSold(int firstClass, int secondClass, int thirdClass)
        {
            this.firstClass -= firstClass;
            this.secondClass -= secondClass;
            this.thirdClass -= thirdClass;
        }
        public void FreeSeats()
        {
            Console.WriteLine($"Рейс {numberFlight}:");
            Console.WriteLine($"Свободных мест в первом классе: {firstClass}");
            Console.WriteLine($"Свободных мест в бизнес-классе: {secondClass}");
            Console.WriteLine($"Свободных мест в эконом-классе: {thirdClass}");
        }
    }

}
