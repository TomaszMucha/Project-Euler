using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_SquarefreeGaussianIntegers
{
    class GaussianInteger
    {
        public int a { get; set; }
        public int b { get; set; }
        public bool IsUnit { get; set; }
        public bool IsPrime { get; set; }
        public bool IsSquareFree { get; set; }
        
        public GaussianInteger(int a, int b)
        {
            this.a = a;
            this.b = b;
            IsUnit = (a == 0 && b == 1) || (a == 0 && b == -1) || (a == 1 && b == 0) || (a == -1 && b == 0);
        }

        public bool CheckIsPrime(GaussianInteger GI)
        {
            for (int i = 0; i < GI.a; i++)
            {
                for (int j = 0; j < GI.b; j++)
                {
                    if (!(i==0&&j==0))
                    {
                        double FirstNumber = (GI.a * i + GI.b * j) / (i * i + j * j);
                        double SecondNumber = (GI.a * i - GI.b * j) / (i * i + j * j);
                        if (!(GI.IsUnit && (new GaussianInteger(i,j).IsUnit)))
                        {
                            if (FirstNumber==(int)FirstNumber&&SecondNumber==(int)SecondNumber)
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }

    }
}
