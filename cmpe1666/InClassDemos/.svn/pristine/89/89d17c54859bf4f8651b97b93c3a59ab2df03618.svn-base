using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10_Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> nameList1 = new LinkedList<string>();
            LinkedList<string> nameList2 = new LinkedList<string>();

            //Allowing the user to input names and adding them to the 2 lists
            for (int count=0; count<5; count++)
            {
                Console.Write("Input the next name: ");
                string name= Console.ReadLine();
                nameList1.AddLast(name);
                nameList2.AddFirst(name);     
            }

            Console.Write("The order of the names in the first list is:  ");
            foreach (string name in nameList1)
                Console.Write($"{name}, ");


            Console.WriteLine();
            Console.Write("The order of the names in the second list is:  ");
           
            foreach (string name in nameList2)
                Console.Write($"{name}, ");

            Console.WriteLine();


        }
    }
}
