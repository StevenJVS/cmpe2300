using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Le9BackgroundThreadDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thOne = new Thread(RunOne);
            thOne.IsBackground = true;
            thOne.Start();
            Thread.Sleep(300);
            System.Console.WriteLine("Main Thread Exiting");

        }


        static void RunOne()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);

            }
        }
    }
}
