using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lecture9_Demo7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(ThreadTest);
            Console.WriteLine($"The state of the thread t1 is: {t1.ThreadState.ToString()}");
            t1.IsBackground = true;
            Thread.Sleep(5000);
            t1.Start();
            Thread.Sleep(2000);
            Console.WriteLine($"The state of thread t1 is : {t1.ThreadState.ToString()}");

            if(t1.ThreadState == ThreadState.Stopped)
            {
                Console.WriteLine("Thread t1 has stopped");
            }
        }

        static private void ThreadTest()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"i = {i}");
                Thread.Sleep(50);
            }
        }
    }
}
