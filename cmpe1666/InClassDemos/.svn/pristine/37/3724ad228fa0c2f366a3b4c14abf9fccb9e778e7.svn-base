/*
 * CMPE 1666- Lecture11- Predicate Demo 1
 * 
 * Illistrating the use of a predicate
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11PredicateDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        { List<int> myList = new List<int>(new int[]{ 12, 13, 7, 32, 9, 23, 31, 24, 15, 14, 16, 20});
          List<int> SelectedList;

            Console.Write("Initial List is: ");
            foreach(int item in myList)
                Console.Write($"{item}, ");
            Console.WriteLine();



            //Using the predicate IsEven to obtain only even values from the list myList
            SelectedList = myList.FindAll(IsEven);

            Console.Write("The List Of Even Values is: ");
            foreach (int item in SelectedList)
                Console.Write($"{item}, ");
            Console.WriteLine();


        }

        static private bool IsEven(int a)
        {
            return a % 2 == 0;
        }
    }
}
