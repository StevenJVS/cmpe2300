using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    internal class Program
    {
        static Stack<int> StkA = new Stack<int>();
         static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.Write("The values generated are: "); 
            for (int i = 0; i < 10; i++)
            {
                int temp = rnd.Next(0,100);
                Console.Write($"{temp}, ");

                StkA.Push(temp);
            }
            Console.WriteLine();

            Console.Write("\nValues on the stack (From Top to Bottom) :");

            foreach(int i in StkA)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine("\n");

            while (StkA.Count > 0)
                Console.WriteLine($"Popping: {StkA.Pop()}");
            Console.ReadLine();
        }
    }
}
