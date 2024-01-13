using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lecture9Demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread NewThread = new Thread(ThreadMethod);
            NewThread.Start ();

            Thread.Sleep(1000);
            Console.WriteLine("Main Thread Exiting");

            System.Environment.Exit(0);

        }

        static void ThreadMethod()
        {
             for (int i=1; i<=10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine($"NewThread Count= {i}");
            }
        }
    }
}
