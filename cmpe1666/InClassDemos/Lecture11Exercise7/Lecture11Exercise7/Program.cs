/*
 * CMPE 1666- Lecture 11 EXercise 7
 * 
 * Using an anonymous method as predicate to FindAll()
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>() {"Edmonton","Toronto","Sum","Euler",
                                                          "Tim", "Sunday", "Just","Bear",
                                                           "Jasper", "Banff"};

            Console.Write("Initial List: ");
            foreach (string str in stringList)
                Console.Write($"{str}, ");
            Console.WriteLine();

            //using an anonymous function for the predicate to FindAll
            Console.Write("Selected List of strings of lenth 5 or higher: ");
            foreach (string str in stringList.FindAll(delegate(string s) { return s.Length > 5; }))
                Console.Write($"{str}, ");
            Console.WriteLine();

        }
    }
}
