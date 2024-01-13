/**CMPE 1666
 * 
 * Lecture6B Demo1;
 * Illustrating input for enum types
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6B_Demo1
{
    internal class Program
    {   public enum Days { Monday=1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday};
        static void Main(string[] args)
        {
            Days eToday;
            int dayNum;

            //When we want to input a value for an enum type, we have to input it as an interger,
            //then convert to the enum type
            Console.Write("Input a value for the day of the week (Monday:1...Sunday:7) ");
            int.TryParse(Console.ReadLine(), out dayNum);

            //Converting the input value to the enum type
            eToday=(Days)dayNum;

            Console.WriteLine($"The input day was: {eToday}");

            
        }
    }
}
