using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10Exercises7And8
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            Random rand = new Random();


            for (int i = 0; i < 10; i++)
            {
                AddToListSorted(ref list, rand.Next(0, 100));

               
            }

            Console.Write("The List values are: ");    

            foreach (int value in list)
            {
                Console.Write($"{value}, ");
            }

            Console.WriteLine();

           
        }

        static private void AddToListSorted(ref LinkedList<int> myList,int value)
        {
            LinkedListNode<int> current;


            current = myList.First;

                           
            while ((current != null) && (current.Value < value))
                current = current.Next;

            if (current == null)
            {
                myList.AddLast(value);
            }

            else
            {
                myList.AddBefore(current, value);
            }


        }

        static private void R_AddToListSorted(ref LinkedList<int> list, LinkedListNode<int> node, int val)
        {
            if (node == null)
                list.AddLast(val);
            else
                if (node.Value > val)
                list.AddBefore(node, val);
            else
                R_AddToListSorted(ref list, node.Next, val);
        }
        
    }
}
