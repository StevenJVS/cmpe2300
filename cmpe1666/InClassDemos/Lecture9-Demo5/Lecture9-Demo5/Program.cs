using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lecture9_Demo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread th1 = new Thread(new ParameterizedThreadStart(Counter));
            th1.Name = "Start(5)";
            th1.IsBackground = true;
            th1.Start(5);



            Thread th2 = new Thread(new ParameterizedThreadStart(Counter));
            th2.Name = "Start(8)";
            th2.IsBackground = true;
            th2.Start(8);
            Console.ReadKey();


        }

        static void Counter(object arg)
        {
            if (arg is int loopcount)
            {
                for (int i = 0; i < loopcount; i++)
                {
                    Thread.Sleep(10);
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {i}");
                }
            }

        }
    }
}
