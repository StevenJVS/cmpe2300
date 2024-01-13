using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lecture9_Demo2
{ //This application is a multi-threaded version of demo1
    //We illustrate here how the different methods are executing concurrently
    internal class Program
    {  static Thread Thread1=null, Thread2=null, Thread3=null;
         
        static void Main(string[] args)
        {
            Thread1=new Thread(FindSine);
            Thread2 = new Thread(FindCos);
            Thread3= new Thread(displayHello);

            Thread1.Start();
            Thread2.Start();
            Thread3.Start();
        }

        public static void FindSine()
        {
            for (double x = 0; x < 90; x = x + 0.1)
            {
                double rad = Math.PI * x / 180;
                double sineValue = Math.Sin(rad);
                Console.WriteLine($"{x:F2} degrees = {rad:F4} radians. Sine={sineValue:F4}");
                Thread.Sleep(50);
            }
        }

        public static void FindCos()
        {
            for (double x = 0; x < 90; x = x + 0.1)
            {
                double rad = Math.PI * x / 180;
                double cosValue = Math.Cos(rad);
                Console.WriteLine($"{x:F2} degrees = {rad:F4} radians. Cos={cosValue:F4}");
                Thread.Sleep(50);
            }

        }

        public static void displayHello()
        {

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Hello There!");
                Thread.Sleep(100);

            }

        }
    }
}
