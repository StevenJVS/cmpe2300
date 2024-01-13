using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10StackDemo1
{
    internal class Program
    { static Stack<int> StkA = new Stack<int>();
        static void Main(string[] args)
        { Random rnd = new Random();
            Console.Write("The values generated are: ");
            for (int i = 0; i < 10; i++)
            {
                int temp = rnd.Next(0, 100);
                Console.Write($"{temp}, ");

                StkA.Push(temp);
            }

            Console.WriteLine();

            Console.Write("Values on the stack (From Top To Bottom): ");

            foreach (int item in StkA)
            {
                Console.Write($"{item}, ");
            }

            Console.WriteLine();

            Console.WriteLine("Going to pop out items from the stack:");
            //We can check for empty stack, by verifying the value of Count
            //When the stack becomes empty the Count will be zero
            while (StkA.Count > 0)
            {
                Console.WriteLine($"Popping: {StkA.Pop()}");
            }
        }
    }
}
