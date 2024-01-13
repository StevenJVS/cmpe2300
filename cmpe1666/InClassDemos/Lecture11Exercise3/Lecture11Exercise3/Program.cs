using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Exercise3
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

            myList.Sort(SortDesc);

            Console.Write("The Sorted list is: ");
            foreach (int item in myList)
                Console.Write($"{item}, ");
            Console.WriteLine();
        }
        

        //The SortDesc() method is a helper to the Sort() method
        //so that sorting happens in descending order
        // since x.CompareTo(y) returns -1, 1 or 0 depending 
        //upon whether x<y, x>y or x==y
        //Since we want the returned values to be reversed here
        // we return y.CompareTo(x), where x is the first parameter and y is the 
        // second parameter to our SortDesc method
       static private int SortDesc(int x, int y)
        {
            return y.CompareTo(x);
        }

    }
}
