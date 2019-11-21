using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_CountingSundays
{
    class Month
    {
        public int MonthNumber { get; set; }
        public int NumberOfDays { get; set; }
        public int FirstDayOfWeek { get; set; }
        public List<Day> Days { get; set; }

        public Month(int MonthNumber, int NumberOfDays, int FirstDayOfWeek)
        {
            Days = new List<Day>();
            this.MonthNumber = MonthNumber;
            this.NumberOfDays = NumberOfDays;
            this.FirstDayOfWeek = FirstDayOfWeek;
            int counter = FirstDayOfWeek;
            for (int i = 1; i < NumberOfDays+1; i++)
            {
                Days.Add(new Day(counter%7));
                counter++;
            }
        }
    }
}
