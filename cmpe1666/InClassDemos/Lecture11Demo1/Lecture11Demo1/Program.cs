﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        { List<int> myList=new List<int>();

            myList.Add(20);
            myList.Add(10);
            myList.Add(15);
            myList.Add(12);
            myList.Add(8);

            Console.Write("The initial list is: ");
            foreach(int item in myList) 
                Console.Write($"{item}, ");
            Console.WriteLine();

            myList.Sort();

            Console.Write("The Sorted list is: ");
            foreach (int item in myList)
                Console.Write($"{item}, ");
            Console.WriteLine();

        }
    }
}
