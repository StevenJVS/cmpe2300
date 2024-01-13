using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10Demo1
{
    internal class Program
    {
        //in this demo we will create a list with random values
        //then copy list contents into a queue
        //then remove contents from the queue
        static List<int> list = new List<int>();
        static Queue<int> q = new Queue<int>();
        static void Main(string[] args)
        {
            Random rand = new Random();

            for (int count = 0 ; count < 10; count++)
            {
                list.Add(rand.Next(0,100));
            }

            Console.WriteLine("The list items are:");
            foreach(int i in list)
            {
                Console.Write($"{i}, ");
            }
            
            //adding items to the queue
            foreach (int i in list)
                q.Enqueue(i);

            Console.WriteLine("\n\nThe Queue items are:");
            foreach(int j in list)
                Console.Write($"{j}, ");

            Console.WriteLine();
            while(q.Count > 0)
            {
                Console.WriteLine($"Remove Item : {q.Dequeue()}");
            }

            Console.ReadKey();
        }
    }
}
