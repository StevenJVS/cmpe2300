using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> myList = new LinkedList<int>();
            Random rand = new Random();

            for (int i=0; i<10; i++)
            {
                myList.AddLast(rand.Next(1, 100));

              }
           
            Console.WriteLine("The list is: ");

            foreach (int value in myList)
                Console.Write($"{value}, ");

            Console.WriteLine();


            Console.WriteLine($"The sum of the values is: {recurseCountEven(myList,myList.First)}");
           



        }

        static private int recurseCountEven(LinkedList<int> list, LinkedListNode<int> node)
        {
            if (node != null)
            {
                if (node.Value % 2 == 0)
                    return (node.Value + recurseCountEven(list, node.Next));
                else
                    return recurseCountEven(list,node.Next);

            }
            else return 0;
        }
        
    }
}
