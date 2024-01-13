using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>() {"Edmonton","Toronto","Sum","Euler",
                                                          "Tim", "Sunday", "Just","Bear",
                                                           "Jasper", "Banff"};

            Console.Write("Given List was: ");
            foreach (string str in stringList)
                Console.Write($"{str}, ");
            Console.WriteLine();

            int n;//The minimum string length that we want
            Console.Write("Input the value for n: ");
            int.TryParse(Console.ReadLine(), out n);


            int result;//To store the count of strings of length n or higher

            result = stringList.FindAll(s => s.Length >= n).Count;

            Console.WriteLine($"The number of strings of length {n} or higher is: {result}");

            
        }
    }
}
