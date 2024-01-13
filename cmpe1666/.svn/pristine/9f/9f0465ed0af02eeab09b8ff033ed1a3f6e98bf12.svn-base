using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            result = Rsum(5);
            Console.WriteLine(result);
               
        }
        static int SumInts(int n)
        {
            int Sum = 0;
            for (int x = n; x > 0; --x)
                Sum += x;
            return Sum;
        }

        static int Rsum(int n)
        {
            if (n < 1)
            {
                return 0;
            }
            else
            {
                return n + Rsum (n - 1);
            }
        }
    }
}
