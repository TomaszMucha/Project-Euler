using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Correct Answer is 171!

namespace _PE_CountingSundays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Year> Years = new List<Year>();
            int FirstYear = 1901;
            int FirstDayOfWeek = 1;
            Years.Add(new Year(FirstYear, FirstDayOfWeek));
            do
            {
                Years.Add(new Year(Years.Last().WithYear + 1, Years.Last().Months.Last().Days.Last().DayOfWeek + 1 % 7));
            } while (Years.Last().WithYear != 2000);

            int ConditionCounter = 0;
            foreach (var Year in Years)
            {
                foreach (var Month in Year.Months)
                {
                    
                    if (Month.Days.First().DayOfWeek==6)
                    {
                        ConditionCounter++;
                    }
                }
            }
        }
    }
}
