using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*CMPE 1666- Lecture10- Linked List Demo1
 * 
 * We illustrate here how to creat 2 simple linked list of int
 * In the first one, we'll add values using AddFirst
 * In the second one we'll add Values using addLast
 * 
 */
namespace Lecture10LinkedListDemo1
{ 
    internal class Program
    {
        static void Main(string[] args)
        { LinkedList<int> myList1= new LinkedList<int>(); 
          LinkedList<int> myList2= new LinkedList<int>();
          Random rnd= new Random();
            int count = 0;

            Console.Write("Values Generated were: ");
            while (count < 10)
            {
                int temp=rnd.Next(0,100);
                Console.Write($"{temp}, ");
                myList1.AddFirst(temp);
                myList2.AddLast(temp);
                count++;
            }

            Console.WriteLine();

            //Displaying the values from myList1
            //Since we used AddFirst, we expect the values to occur in the reverse order
            Console.Write("Items from myList1: ");
            foreach(int item in myList1)
            {
                Console.Write($"{item}, ");
            }

            Console.WriteLine();

            //Displaying the values from myList2
            //Since we used AddLast, we expect the values to occur in the same order that
            //they were generated
            Console.Write("Items from myList2: ");
            foreach (int item in myList2)
            {
                Console.Write($"{item}, ");
            }

            Console.WriteLine();


        }
    }
}
