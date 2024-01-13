using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();

            for (int count = 0; count < 10; count++)
            {
                Console.Write($"Input Name no. {count+1}: ");
                string name=Console.ReadLine();
                myList.Add(name);

            }


            Console.Write("The initial list is: ");
            foreach (string item in myList)
                Console.Write($"{item}, ");
            Console.WriteLine();

            myList.Sort();

            Console.Write("The Sorted list is: ");
            foreach (string item in myList)
                Console.Write($"{item}, ");
            Console.WriteLine();
        }
    }
}
