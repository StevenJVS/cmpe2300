using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * CMPE 1666- Lecture10- Demo1
 * 
 * Working With Queues 
 * 
 * In this demo, we first create a list with a number of random values
 * 
 * We then copy the values from the list to the queue (using Enqueue)
 * 
 * Finally, we remove the values from the queue (Use Dequeue)
 */
namespace Lecture10Demo1
{
    internal class Program
    {  static List<int> list = new List<int>();
       static Queue<int> q = new Queue<int>();
        static void Main(string[] args)
        {
            Random rand = new Random();

            //Generate 10 random values in the range 0..100 and add them to the list
            for (int count=0; count<10; count++)
            {
                list.Add(rand.Next(0, 100));
            }

            //Perform a display of the list
            Console.Write("The List Items are: ");
            foreach(int item in list)
                Console.Write($"{item}, ");

            Console.WriteLine();

            //Adding the list items to the queue
            foreach (int item in list)
                q.Enqueue(item);

            //Displaying Items from the queue
            Console.Write("The Queue Items are: ");
            foreach (int item in q)
                Console.Write($"{item}, ");

            Console.WriteLine();


            //Delete items from queue until queue is empty
            while (q.Count > 0)
            {
                Console.WriteLine($"Removed Item: {q.Dequeue()}");
            }


        }
    }
}
