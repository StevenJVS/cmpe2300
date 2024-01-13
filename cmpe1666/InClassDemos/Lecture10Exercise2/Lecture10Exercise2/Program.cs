using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10Exercise2
{
    internal class Program
    {
        struct Point
        {
            public int X;
            public int Y;

            //Constructor for the Point struct
            //Note that a constructor does not not have a returned type
            public Point(int x1, int y1)
            {
                X = x1;
                Y = y1;
            }

            //ToString() must return a string in the format that we want the displays
            public override string ToString()
            {
                return $"({X},{Y})";
            }
        }
        static void Main(string[] args)
        {
            Stack<Point> stk = new Stack<Point>();
            bool over=false;//To control when to exit the menu loop
            do
            {
                //Menu to be displayed for the user
                Console.WriteLine("Choose From Menu:");
                Console.WriteLine("1. Input a new point");
                Console.WriteLine("2. Display The Stack");
                Console.WriteLine("3. Pop out a point from the Stack");
                Console.WriteLine("4. Display The Point at the top of the Stack");
                Console.WriteLine("5. Exit");
                Console.Write("Your Choice?: ");
                int choice;
                //We are not performing any validation here,
                //but we can use the value of success to validate
                bool success = int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        bool success1, success2; //To be used to verify the validity of the 
                                                 //inputs for X and Y respectively

                        //The 2 variables below will be used to store the coordinates of a new point
                        //before creating the corresponding Point struct
                        int X_Input;
                        int Y_Input;

                        //Input a coordinates for new point- Allow the user to input the 
                        //coordinates, create the point and push it onto the stack
                        Console.Write("X Value for Point: ");
                        success1 = int.TryParse(Console.ReadLine(), out X_Input);
                        Console.Write("Y Value for Point: ");

                        success2 = int.TryParse(Console.ReadLine(), out Y_Input);
                        stk.Push(new Point(X_Input, Y_Input));
                        break;

                    case 2://Display The Stack
                        Console.WriteLine("Points On the Stack");
                        foreach (Point p in stk)
                        {
                            Console.WriteLine(p.ToString());
                        }
                        break;

                    case 3://Popping out a point from the Stack
                        Point p1 = stk.Pop();
                        Console.WriteLine($"The Popped Point was: {p1.ToString()}");
                        break;

                    case 4://Displaying the top element
                        Point p2 = stk.Peek();
                        Console.WriteLine($"The Top Point is: {p2.ToString()}");
                        break;
                        
                    case 5://This choice allows the user to exit the loop
                          over = true;
                          break;

                    default:
                        //To cater for values outside the meaningful range
                        Console.WriteLine("Wrong Input- Please input again");
                        break;
                }


                


            } while (!over);
        }
    }
}
