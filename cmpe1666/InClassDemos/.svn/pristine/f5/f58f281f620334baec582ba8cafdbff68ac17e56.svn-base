using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10_LinkedListDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        { LinkedList<int> myList=new LinkedList<int>();
            int count = 0;
         Random rnd= new Random();

            //Generating the values, adding them to the list and also 
            //displaying the generated values
            Console.Write("Generated Values were: ");
            while (count< 10)
            {
                int temp= rnd.Next(0,100);
                myList.AddFirst(temp);
                Console.Write($"{temp}, ");
                count++;
            }

            Console.WriteLine();

            Console.Write("Values in the List are: ");
            
            foreach(int item in myList)
            {
                Console.Write($"{item}, ");
            }

            Console.WriteLine();

            //Placing a pointer at the last node
            LinkedListNode<int> current = myList.Last;

            //Displaying the current node, then moving to the previous node in the list
            while (current != null)
            {
                Console.WriteLine($"Value at current Node is: {current.Value}");
                current = current.Previous;
            }

        }
    }
}
