using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> mylist= new LinkedList<int>();

            Random rand = new Random();
            int count = 0;

            Console.WriteLine("The generated values are: ");
            while(count < 10)
            {
                int temp = rand.Next(0,100);
                Console.Write($"{temp}, ");
                mylist.AddFirst(temp);
                count++;
            }

            Console.WriteLine();
            Console.WriteLine("\nThe values in the list are:");
            foreach(int i in mylist)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();

            LinkedListNode<int> current = mylist.Last;

            while(current != null)
            {
                Console.WriteLine($"Value at current node is: {current.Value}");
                current = current.Previous;
            }
        }
    }
}
