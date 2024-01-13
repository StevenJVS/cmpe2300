using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubblesort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 5, 56, 7, 23, 12, 58, 63, 1 ,13, 32};
            bubblesort(ints);
        }
        private static void bubblesort(int[] ints)
        {
            int n = ints.Length;
            for (int p = 0; p < n -1; p++)
            {
                for (int j = 0; j < (n - (p + 1)); j++)
                {
                    if (ints[j] > ints[j + 1])
                    {
                        swap(ref ints[j], ref ints[j + 1]);
                    }
                }
            }
            foreach(int i in ints)
            {
                Console.Write($"{i}, ");
            }
/*            for(int i = 0; i < n; i++)
            {
                Console.Write($"{ints[i]}, ");
            }*/
            Console.ReadLine();
        }
        private static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
