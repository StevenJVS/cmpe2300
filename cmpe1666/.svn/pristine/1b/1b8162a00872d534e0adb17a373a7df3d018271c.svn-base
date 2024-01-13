using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowerRangeValue;
            int upperRangeValue;

            GetRange(out lowerRangeValue, out upperRangeValue, 0, 100);

            Console.WriteLine($"The range we want is {lowerRangeValue}-{upperRangeValue}");


        }
        static private void GetValue(out int input, string prompt, int min, int max)
        {
            bool success = false, outOfRange = false;

            do
            {
                Console.Write($"{prompt} ({min}-{max}):  ");
                success = int.TryParse(Console.ReadLine(), out input);
                outOfRange = false;

                if (!success)
                {
                    Console.WriteLine("The input value is not valid- You have to input another value");

                }
                else if ((input < min) || (input > max))
                {
                    Console.WriteLine($"The input is out of range- You have to input in the range {min}-{max}");
                    outOfRange = true;
                }

                Console.WriteLine();

            } while ((!success) || outOfRange);


        }

        static private void GetRange(out int lower, out int upper, int minBound, int maxBound)
        {
            do
            {
                GetValue(out lower, "Enter the lower limit of the range of values to generate", minBound, maxBound);
                GetValue(out upper, "Enter the upper limit of the range of values to generate", minBound, maxBound);

                if (upper <= lower)
                {
                    Console.WriteLine("The upper limit has to be highr than the lower limit. Please input again");
                }

            } while (upper <= lower);

        }
    }
}
