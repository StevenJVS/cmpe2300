using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            int value;

            for (int count = 0; count < 10; count++)
            {
                Console.Write($"Input value {count + 1}: ");
                int.TryParse(Console.ReadLine(), out value);
                myList.Add(value);
            }

            Console.Write("Initial List is: ");
            foreach (int item in myList)
                Console.Write($"{item}, ");
            Console.WriteLine();

            Console.Write("Selected List is: ");
            //We obtain the selected list by using the defined predicate as a parameter to FindAll
            foreach (int item in myList.FindAll(IsBiggerOdd))
                Console.Write($"{item}, ");
            Console.WriteLine();
        }
        static private bool IsBiggerOdd(int x)
        {
            return ((x % 2 != 0) && (x > 10));
        }
    }
}
