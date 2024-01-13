using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preorder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PostOrder("Hello", 0);
            Console.ReadKey();
        }
        static void PreOrder(string str, int position)
        {
            if (position != str.Length)
            {
                Console.Write(str[position]);
                PreOrder(str, position + 1);
            }
        }
        static void PostOrder(string str, int position)
        {
            if(position != str.Length)
            {
                PostOrder(str, position + 1);
                Console.Write(str[position]);
            }
        }

    }
}
