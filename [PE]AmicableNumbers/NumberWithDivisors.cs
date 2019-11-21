using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_AmicableNumbers
{
    class NumberWithDivisors
    {
        public ulong Number { get; set; }
        public List<ulong> Divisors { get; set; }
        public ulong SumOfDivisors { get; set; }

        public NumberWithDivisors(ulong Number)
        {
            this.Number = Number;
            this.Divisors = new List<ulong>();
            this.SumOfDivisors = 0;
        }
    }
}
