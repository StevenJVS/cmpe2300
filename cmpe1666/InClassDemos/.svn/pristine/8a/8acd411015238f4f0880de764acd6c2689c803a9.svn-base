using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();

            myList.Add(20);
            myList.Add(10);
            myList.Add(15);
            myList.Add(12);
            myList.Add(8);

            Console.Write("The initial list is: ");
            foreach (int item in myList)
                Console.Write($"{item}, ");
            Console.WriteLine();
            //The inbuilt Sort Method can take a method as parameter
            //This paramater method must be compatible with the Comparison delegate
            myList.Sort(SortAsc);

            Console.Write("The Sorted list is: ");
            foreach (int item in myList)
                Console.Write($"{item}, ");
            Console.WriteLine();

        }


        //The method SortAsc when used as parameter to the inbuilt Sort method
        // will cause the sorting to happen in Ascending order
      static  private int SortAsc(int x,int y)
        {
            if (x < y)
                return -1;
            else if (x > y)
                return 1;
            else return 0;
            
        }
    }
}
