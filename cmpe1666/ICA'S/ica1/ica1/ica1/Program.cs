//***********************************************************************************
//Steven Santiago ICA 1
//****************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ICA1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int arrayinput; //array size
            int lower; // lower bounds
            int upper; // upper bounds
            int[] array; // array

            //title
            Console.WriteLine("Steven Santiago - ICA1");

            //input size of array
            GetValue("\nInput the size of the array to generate (10-100): ", out arrayinput);

            //get bounds of the array
            GetRange(arrayinput, out lower, out upper);

            //generate index value of the array
            array = GenerateArray(ref arrayinput, ref lower, ref upper);

            //display contents of the array
            DisplayArray(array);

            //count occurrences of wanted value
            CountOccurrences(array);
            Console.ReadLine();

        }
        //********************************************************************************************
        //Method: static private int GetValue(string prompt, out int array input)
        //Purpose: Inputs an integer value within parameters
        //Parameters:string prompt - prompt to display to the user
        //array input - input wanted array size
        //Returns: int - value accepted by the method
        //*********************************************************************************************
        static int GetValue(string prompt, out int arrayinput)
        {
            string input;// user input

            //repeat until wanted value is selected
            do
            {
                //input value and convert to integer
                Console.Write(prompt);
                input = Console.ReadLine();
                int.TryParse(input, out arrayinput);
                if (!int.TryParse(input, out arrayinput))
                    Console.WriteLine("Invalid input");

            }
            //condition for loop
            while (!int.TryParse(input, out arrayinput));
            //returns accepted integer
            return arrayinput;
        }
        //********************************************************************************************
        //Method: static private int GetRangfe(int arrayinput, out int lower, out int upper)
        //Purpose: Get parameters of the array
        //Parameters:string prompt - prompt to display to the user
        // int lower - minimum value accepted
        // int upper - maximum value accepted
        //Returns: lower + upper - value accepted by the method
        //*********************************************************************************************
        static int GetRange(int arrayinput, out int lower, out int upper)
        {
            //input lower and upper parameters
            lower = GetValue("\nEnter the lower limit of the range of the values to generate (0-100): ", out arrayinput);
            do
            {
                upper = GetValue("\nEnter the upper limit of the range of the values to generate (0-100): ", out arrayinput);
                if (lower > upper)
                    Console.WriteLine("Please input a number greater than " + lower);
            } while (lower > upper);
            //returns accepted lower and upper values
            return lower + upper;
        }
        //********************************************************************************************
        //Method: static private int[] GenerateArray(ref int arrayinput, ref int lower, ref int upper)
        //Purpose: Generate values of the array
        //Parameters:string prompt - prompt to display to the user
        // int lower - minimum value accepted
        // int upper - maximum value accepted
        //Returns: array
        //*********************************************************************************************
        static int[] GenerateArray(ref int arrayinput, ref int lower, ref int upper)
        {
            int[] array = new int[arrayinput];//new array

            //generates random number
            Random random = new Random();

            //assigns each index value a new random value
            for (int i = 0; i < array.Length; i++)//loops through each index value to assign a new number
            {
                int randomnum = random.Next(lower, upper + 1);
                array[i] = randomnum;
            }

            //return array
            return array;
        }
        //********************************************************************************************
        //Method: static void DisplayArray(int[] array)
        //Purpose: display contents of the array
        //Parameters:array
        //Returns: null
        //*********************************************************************************************
        static void DisplayArray(int[] array)
        {
            //loops through array and display its contents
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.ReadLine();
        }
        //********************************************************************************************
        //Method: static void CountOccurrences(int[] array)
        //Purpose: counts number of occurrences of wanted value
        //Parameters:array
        //Returns: null
        //*********************************************************************************************
        static void CountOccurrences(int[] array)
        {
            bool reset = false;//condition to run method 
            do
            {
                int counter = 0;//number of occurences
                int num;// wanted integer

                string input;// user input

                //Get wanted value
                GetValue("\nEnter the Value to be searched:", out num);

                //search for wanted value in array
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == num)
                        counter++;

                }

                //display message if number is found
                if (counter > 0)
                    Console.WriteLine("\nNumber of occurrences of " + num + " is " + counter);

                //display message if number is not found
                if (counter == 0)
                    Console.WriteLine("\n" + num + " not found in array");

                //ask user if they want to run the program again
                Console.WriteLine("\nDo you want to search for another value? (y/n) : ");
                input = Console.ReadLine().ToLower();

                //change boolean 
                if (input == "n")
                    reset = true;

            }
            // loop condition 
            while (reset == false);

        }
    }
}
