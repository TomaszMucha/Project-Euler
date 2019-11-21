using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_CountingSundays
{
    class Year
    {
        public int WithYear { get; set; }
        public int NumberOfdays { get; set; }
        public bool IsIntercalary { get; set; }
        public List<Month> Months { get; set; }

        public Year(int WithYear, int FirstDayOfWeek)
        {
            this.WithYear = WithYear;
            IsIntercalary = WithYear % 400 == 0 ? true : (WithYear % 100 == 0? false : (WithYear % 4 == 0 ? true : false ));
            NumberOfdays = IsIntercalary ? 366 : 365;
            Months = new List<Month>();
            Months.Add(new Month(1,31,FirstDayOfWeek));
            for (int i = 2; i < 13; i++)
            {
                if (i==4 || i == 6 || i == 9 || i == 11 )
                {
                    Months.Add(new Month(i,30,(Months.Last().Days.Last().DayOfWeek+1)%7));
                }
                else
                {
                    if (i==2)
                    {
                        if (IsIntercalary)
                        {
                            Months.Add(new Month(2,29, (Months.Last().Days.Last().DayOfWeek + 1) % 7));
                        }
                        else
                        {
                            Months.Add(new Month(2, 28, (Months.Last().Days.Last().DayOfWeek + 1) % 7));
                        }
                    }
                    else
                    {
                        Months.Add(new Month(i, 31, (Months.Last().Days.Last().DayOfWeek + 1) % 7));
                    }
                }
            }
        }
    }
}
