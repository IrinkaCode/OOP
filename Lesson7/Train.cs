using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    internal class Train
    {

        public int Number {  get; set; }
        public string? Sourse {  get; set; }
        public string? Destination { get; set; }
        private Passenger[] peoples;

        public Train(int number, string? sourse, string? destination,int n)
        {
            Number = number;
            Sourse = sourse;
            Destination = destination;
            peoples = new Passenger[n];
        }
        public void add(Passenger p)
        {
            peoples[++count] = p;
        }
        public void sub(Passenger p)
        {
            peoples[--count] = p;
        }
    }
}
