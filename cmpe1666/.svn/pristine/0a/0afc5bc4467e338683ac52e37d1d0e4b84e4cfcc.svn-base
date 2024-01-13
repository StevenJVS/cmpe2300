using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread th1 = new Thread(new ParameterizedThreadStart(counter));
            th1.Name = "Start(5)";
            th1.IsBackground = true;
            th1.Start(5);//boxing

            Thread th2 = new Thread(new ParameterizedThreadStart(counter));
            th2.Name = "Start(8)";
            th2.IsBackground = true;
            th2.Start(8);//boxing

            Console.ReadKey();
        }
        static void counter(object arg)
        {
            if(arg is int loopcount)//unboxing
            {
                for(int i =0; i< loopcount; i++)
                {
                    Thread.Sleep(10);
                    Console.WriteLine($"{Thread.CurrentThread.Name} : {i}");
                }
            }
        }
    }
}
