using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_QuadraticPrimes
{
    class QuadricExpression
    {
        public int A { get; set; }
        public int B { get; set; }
        public List<long> CalculatedPrimeExpressions { get; set; }

        public QuadricExpression(int a, int b)
        {
            this.A = a;
            this.B = b;
            this.CalculatedPrimeExpressions = new List<long>();
        }
    }
}
