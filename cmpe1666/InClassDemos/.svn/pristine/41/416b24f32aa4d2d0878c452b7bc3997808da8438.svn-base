using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8Demo2
{
    internal class Program
    {
        delegate void delSingleString(string str);
        static void Main(string[] args)
        {
            delSingleString firstObject = new delSingleString(displayString);
            delSingleString secondObject = new delSingleString(displayUpper);

            firstObject.Invoke("It's a nice weather today!");
            secondObject.Invoke("It's a nice weather today!");
        }

        static private void displayString(string s1)
        {
            Console.WriteLine($"The given string was: {s1}");
        }

        static private void displayUpper(string s1)
        {
            Console.WriteLine($"String in uppercase is: {s1.ToUpper()}");
        }

    }
}
