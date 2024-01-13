using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8Demo1
{
    internal class Program
    { delegate void delSingleString(string str);
        static void Main(string[] args)
        {
            delSingleString firstObject = new delSingleString(displayString);

            firstObject.Invoke("It's a nice weather today!");
        }

        static private void displayString(string s1)
        {
            Console.WriteLine($"The given string was: {s1}");
        }

    }
}
