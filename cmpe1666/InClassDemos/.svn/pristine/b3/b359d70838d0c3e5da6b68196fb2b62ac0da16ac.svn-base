/*** CMPE 1666-Fall 2021 
 * 
 * 
 * Lecture 6B- Exercise 2 (Exercise details available in lecture notes)
 * 
 * Enumeration Type
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * This program Uses an enumeration type for months of the year
 * and an enumeration type for days of the week
 * 
 * It allows the user to input a month, then the day of the week for the 
 * first day of the month.
 * 
 * The user can then continuously enter a date (day only) of the month and the program will display the 
 * day of the week for that date
 */


namespace Lecture6B_Exercise2
{       
    class Program
    {   //Enum for days of the week -- Note that we force the 1st value (Monday) to be 1 instead of 0
        public enum Days {Monday=1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };

        //Enum for days of the month -- Again we force January to be 1 instead of 0
        public enum Months {January=1, February, March, April, may, June, Jul, August, Sepetember, October, November, December};

        //Array storing the total number of days for each month of the year
        public static int[] daysArray = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        static void Main(string[] args)
        {
            int monthNum; //Month Number to be input by user
            Months Month=0; //Month will be set from the enum list based on the input for monthNum
            int dayNum;   //To store user input a number representing the day of the week which is the 
                          // first day of the month - We assign an initial value here;
            Days firstDay=0;//To store the day of the first day of the month as a day instead of a number
            bool over = false; //To check whether to continue running the program

            int dateOfMonth;//To store the value input by the user for the date of the month for which we want to know
                            //the day of the week
            Days requiredDay; //To store the day of the week for the date of the month input by the user

            bool success;//Used to perform input validation
            String answer;//To store the user's answer as to whether to continue executing the program

            //Input and validate the month
            do
            {   //User will input the month as a number-Program will remain in the loop until a valid 
                //integer value in the range 1..12 is input
                //success will return false if input is not a valid integer
                Console.Write("Input a month number (January=1, February=2.......):  ");
                success= int.TryParse(Console.ReadLine(), out monthNum);

                if (success)
                { //The value input was a valid integer -- we must then verify the range 
                    Month = (Months)monthNum;
                    if ((Month < Months.January) || (Month > Months.December))
                    { //If the value is not in the proper range, we have to inform the user to input again
                        Console.WriteLine("You Month number should be in range 1..12 - You'll have to input again");
                    }
                    //Note that there is no else for this if- If the value is valid and within range there is nothing 
                    //else to do here, the program will automatically get out of this loop
                }
                else
                { //if we reach here, it means that the input value was not a valid integer
                  //The user has to be informed to input again
                    Console.WriteLine("Your input value is not a valid integer- You'll have to input again");
                }


            } while ((!success) || (Month < Months.January) || (Month > Months.December));


            //Input and validate the day of week for the 1st day of the month
            do
            { //We'll stay in this loop until the user inputs a valid integer value in the range 1..7
                Console.Write($"Input day of week for the 1st of {Month} (Monday=1, Tuesday=2,..... Sunday=7):  ");
                success= int.TryParse(Console.ReadLine(), out dayNum);

                if (success)
                {//The value input was a valid integer -- we must then verify the range 
                    firstDay = (Days)dayNum;
                    if ((firstDay < Days.Monday) || (firstDay > Days.Sunday))
                    {//If the value is not in the proper range, we have to inform the user to input again
                        Console.WriteLine("Your value must be in the range 1..7- You'll have to input again");
                    }
                    ////Note that there is no else for this if- If the value is valid and within range there is nothing 
                    //else to do here, the program will automatically get out of this loop

                }
                else
                { //if we reach here, it means that the input value was not a valid integer
                  //The user has to be informed to input again
                    Console.WriteLine("Your input value is not a valid integer- You'll have to input again");
                }


            } while ((!success) || ((firstDay < Days.Monday) || (firstDay > Days.Sunday)));


       do
        { /*In this loop we ask the user to input a date of the month for which the uer wants to obtain the day of the week
               The date will be input as a single integer value
              We perform validation to ensure the value is valid and within range
              If the value is valid and within the range of dates for the month,
              We'll display the day of the week then ask to user if he/she wants to continue
               */

                do
                { /*Input the date of the month. We remain in this loop until a valid integer value
                   * within the range of date for the chosen month is input
                   */
                    monthNum = (int)Month - 1;//We'll use monthNum as index to the array daysArray

                    Console.Write($"Input the date of {Month} for which you want to have the day of the week: ");
                    success = int.TryParse(Console.ReadLine(), out dateOfMonth);

                    if (success)
                    { //The value input was a valid integer- Check for the range
                        //If not in range- inform user to input again
                        if ((dateOfMonth <= 0) || (dateOfMonth > daysArray[monthNum]))
                        {
                            Console.WriteLine("Your value is outside the range for the month");
                            Console.WriteLine("You have to input again");
                        }
                        //else there is nothing to do here

                    }
                    else //The input vaue was not a valid integer-inform the user to input again
                    {
                        Console.WriteLine("Your value is not a valid integer");
                        Console.WriteLine("You have to input again");
                    }
                             

                } while (!success || (dateOfMonth <= 0) || (dateOfMonth > daysArray[monthNum]));
                //End of inner do..while loop - We get out of this loop if the user has input a valid
                //integer in the range of the dates for the month
                //We can now procced to obtain the day of the week

                //The formula to obtain the day of the week is easy- we subtract 1 from the date
                //we then add the the day number of the first day of the month.
                //We do a %7 to bring it in range 0-6, then convert back to the enum Days
                requiredDay = (Days)(((((dateOfMonth-1)+(int)firstDay-1))%7))+1;

               
                Console.WriteLine($"Required day is : {requiredDay}");
                  
                //We finally ask the user if they want to try for another date
                do
                {  //Obtain user's answer as to whether to continue of not
                    Console.Write("Do you want to try for another date (y/n)? ");
                    answer = Console.ReadLine();

                    //Ensure that user enters y or n
                    if ((answer.ToLower() != "y") && (answer.ToLower() != "n"))
                    {
                        Console.WriteLine("Your answer is not valid- please input again");
                    }

                    //if the user enters n- we have to leave this loop.
                    //We do this by setting over to true
                    if (answer.ToLower() == "n")
                        over = true;

                } while ((answer.ToLower() != "y") && (answer.ToLower() != "n"));

            } while (!over);



        }
    }
}
