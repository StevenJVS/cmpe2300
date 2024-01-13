using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> mylist1= new LinkedList<int>();
            LinkedList<int> mylist2= new LinkedList<int>();
            Random rand = new Random();
            int count = 0;

            Console.Write("Value Generated are: ");
            while (count < 10)
            {
                int temp = rand.Next(0,100);
                Console.Write($"{temp}, ");

                mylist1.AddFirst(temp);
                mylist2.AddLast(temp);

                count++;
            }

            Console.WriteLine();
            Console.Write("My list 1: ");
            foreach (int i in mylist1)
            {
                Console.Write($"{i}, ");
            }

            Console.WriteLine();
            Console.Write("My list 2: ");
            foreach (int i in mylist2)
            {
                Console.Write($"{i}, ");
            }
            Console.ReadLine();
        }
    }
}
