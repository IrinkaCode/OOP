using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_DZ__Делегаты_и_лямбда_функции
{
    public delegate double VolumeCalculator(Building building);
    public class Building
    {
        public string? BuildingName { get; set; }
        public double Height { get; set; }
        public int Floors { get; set; }
        public double TotalArea { get; set; }
        public string? Location { get; set; }

        public double CalculateVolume()
        {
            return Height * TotalArea;
        }
    }

}
