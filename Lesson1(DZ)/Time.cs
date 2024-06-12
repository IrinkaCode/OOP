using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_DZ_
{
    internal class Time
    {
        private int hours;
        private int minutes;
        private int seconds;

        public int Hours
        {
            get { return hours; }
            set
            {
                if (value < 0 || value >= 24)
                    throw new ArgumentOutOfRangeException(nameof(Hours), "Часы должны быть в диапазоне от 0 до 23");
                hours = value;
            }
        }

        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value < 0 || value >= 60)
                    throw new ArgumentOutOfRangeException(nameof(Minutes), "Минуты должны быть в диапазоне от 0 до 59");
                minutes = value;
            }
        }

        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (value < 0 || value >= 60)
                    throw new ArgumentOutOfRangeException(nameof(Seconds), "Секунды должны быть в диапазоне от 0 до 59");
                seconds = value;
            }
        }

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public void AddHours(int hours)
        {
            Hours += hours;
        }

        public void AddMinutes(int minutes)
        {
            Minutes += minutes;
        }

        public void AddSeconds(int seconds)
        {
            Seconds += seconds;
        }

        public override string ToString()
        {
            return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
        }
    }
}
