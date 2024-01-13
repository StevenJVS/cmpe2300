﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lecture9_Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            FindSine();
            FindCos();
            displayHello();
        }

        public static void FindSine()
        {
          for (double x=0; x<90; x=x+0.1)
            {
                double rad = Math.PI * x / 180;
                double sineValue = Math.Sin(rad);
                Console.WriteLine($"{x:F2} degrees = {rad:F4} radians. Sine={sineValue:F4}");
                Thread.Sleep(50);
            }
        }

        public static void FindCos()
        {
            for (double x = 0; x <90; x = x + 0.1)
            {
                double rad = Math.PI * x / 180;
                double cosValue = Math.Cos(rad);
                Console.WriteLine($"{x:F2} degrees = {rad:F4} radians. Cos={cosValue:F4}");
                Thread.Sleep(50);
            }

        }

        public static void displayHello()
        {
          
             for (int i=0; i < 100; i++)
            {
                Console.WriteLine("Hello There!");
                Thread.Sleep(100);
                    
            }

        }
    }
}
