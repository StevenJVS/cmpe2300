using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6_Exercise3
{
    internal class Program
    {
        private struct Point
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
            Point[] points = new Point[5];
            int x1;
            int y1;
            for (int count=0; count<points.Length; count++)
            {
                Console.WriteLine($"Input Coordinates for Point {count+1}:");
                Console.Write("X: ");
                int.TryParse(Console.ReadLine(),out x1);
                Console.Write("Y: ");
                int.TryParse(Console.ReadLine(), out y1);
                points[count]=new Point(x1, y1);
                Console.WriteLine();

            }

            Console.WriteLine("The given points were: ");
            foreach(Point point in points)
            {
                display(point);
                Console.WriteLine();
            }

   //Initializing a Sum value for each of the 
   //X and Y members- These will be used to calulate the average
            double SUMX = 0.0;
            double SUMY= 0.0;
     //Calculating the average X and Y Values
     foreach (Point point in points)
        {
          SUMX+=point.X;
          SUMY+=point.Y;
        }
        double averX=SUMX/points.Length;
        double averY=SUMY/points.Length;

        Console.WriteLine($"The Average point is ({averX}, {averY})");

        }

 private static void display(Point P)
        {
            Console.WriteLine($"({P.X},{P.Y})");
        }
    }
}
