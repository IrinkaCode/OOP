using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_DZ_
{
    public class Dispatcher
    {
        private List<Avto> avtos = new List<Avto>();
        private List<Driver> drivers = new List<Driver>();
        private List<Trip> trips = new List<Trip>();

        public void AddCar(Avto avto)
        {
            avtos.Add(avto);
        }

        public void AddDriver(Driver driver)
        {
            drivers.Add(driver);
        }

        public void AssignTrip(Driver driver, Avto avto)
        {
            if (driver.IsWorking && avto.IsAvailable)
            {
                Trip trip = new Trip
                {
                    AssignedDriver = driver,
                    AssignedAvto = avto,
                    Status = "Назначено"
                };
                trips.Add(trip);
                avto.IsAvailable = false;
                Console.WriteLine($"Поездка назначена {driver.Name} машина {avto.Model}.");
            }
            else
            {
                Console.WriteLine("Поездка не назначена.Отсутствуют водитель или машина.");
            }
        }

        public void SuspendDriver(Driver driver)
        {
            driver.IsWorking = false;
            Console.WriteLine($"{driver.Name} был отстранен от работы.");
        }
    }
}
