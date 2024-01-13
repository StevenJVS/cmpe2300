using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8Exercise1
{
    internal class Program
    {  delegate int delBinaryOp(int x, int y);
        static void Main(string[] args)
        {
            delBinaryOp add_Object = new delBinaryOp(Addition);
            delBinaryOp mult_Object = new delBinaryOp(Multiplication);
            delBinaryOp div_Object = new delBinaryOp(Division);
            int result1, result2, result3;

            result1 = add_Object.Invoke(5, 6);
            result2 = mult_Object.Invoke(5, 6);
            result3 = div_Object.Invoke(40, 6);

            Console.WriteLine($"result1 is: {result1}");
            Console.WriteLine($"result2 is: {result2}");
            Console.WriteLine($"result3 is: {result3}");

        }

        static private int Addition(int x1, int y1)
        {
            return x1 + y1;

        }

        static private int Multiplication(int x1, int y1)
        {
            return x1*y1;

        }
        static private int Division(int x1, int y1)
        {
            return x1/y1;

        }


    }
}
