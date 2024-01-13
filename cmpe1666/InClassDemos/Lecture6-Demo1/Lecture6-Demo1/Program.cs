using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6_Demo1
{
    internal class Program
    {   private struct Point
        {
            public int X;
            public int Y;

            public Point(int x1, int y1)
            {
                X = x1;
                Y = y1;
            }
        }
        static void Main(string[] args)
        {
            Point P1;
            Point P2=new Point(3,5);//Created using the onstructor

            //P1 has been created without the use of the constructor, so we have to assign the values
            //separately;
            P1.X = 5;
            P1.Y = 10;

            Console.WriteLine($"P1: ({P1.X}, {P1.Y})");
            Console.WriteLine($"P2: ({P2.X}, {P2.Y})");
        }
    }
}
