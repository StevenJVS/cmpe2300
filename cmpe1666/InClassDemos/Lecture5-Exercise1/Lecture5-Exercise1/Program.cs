using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myarray;
            int n;
            Random rand = new Random();

            Console.Write("Input number of elements in the array: ");
            int.TryParse(Console.ReadLine(), out n);

            myarray = new int[n];

            for (int i = 0; i < n; i++)
            {
                myarray[i] = rand.Next(1,1000);
            }

            Console.Write("Array Before Sorting: ");
            foreach (int item in myarray)
                Console.Write($"{item}, ");
            Console.WriteLine();

            BubbleSort(myarray);

            Console.Write("Array After Sorting: ");
            foreach (int item in myarray)
                Console.Write($"{item}, ");
            Console.WriteLine();

        }

        static void BubbleSort(int[] array)
        {
            int n=array.Length;

            for (int p = 0; p < n - 1; p++)//Number of passes (iterate over each pass p)
                for (int j = 0; j < (n - (p + 1)); j++)
                    if (array[j] > array[j + 1])
                        Swap(ref array[j], ref array[j + 1]);
        }

        static void Swap(ref int X, ref int Y)
        {
            int temp = X;
            X = Y;
            Y = temp;
            
        }
    }  
}
