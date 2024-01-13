//***********************************************************************************
//Program: LAB1_Money converter
//Description: converts money into bills
//Date: 01/30/23
//Author: Steven Santiago
//Course: CMPE1666
//Class: CNTA02
//***********************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;
using Microsoft.Win32;
using System.Runtime.CompilerServices;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num;//user input
            double[] count = { };//empty array to store counted bills
            bool reset = false;//bool to reset program

            //run program until user stops
            do
            {
                Console.Clear();//clear console
                Console.WriteLine("\t\t\tSteven Santiago - Lab1");

                GetValue("How much money do you wish to convert?", out num);//ask user input
                count = GetCash(num);//store counted bills
                DisplayCash(num, count);//display money in GDI
                Reset("Would you like to run the program again? (y/n): ", reset);//ask user to run program again
                Console.ReadKey();        
                
                //condition to run program again
            }while(reset==false);

        }
        //********************************************************************************************
         //Method: static private double GetValue(string prompt, out double num)
         //Purpose: Inputs a double value with error
         //Parameters:string prompt - prompt to display to the user
         //double returns double
         //Returns: double - value accepted by the method
         //*********************************************************************************************
        static double GetValue(string prompt, out double num)
        {
            double round;//store initial input
            string input;//user string input
            //run until user inputs valid number
            do
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine();

                input = input.Replace("$", " ").Trim();//remove white space and $ sign
                double.TryParse(input, out num);//convert string into a double

                //display error message if input is invald
                if (!double.TryParse(input, out num))
                    Console.WriteLine("Invalid input.");

            } while (!double.TryParse(input, out num));//condition to run program again
            round = num;//store initial value 

            //round number
            num = Math.Round(num*20)/20;

            //if number is rounded, display message
            if (round != num)
                Console.WriteLine($"user entry of {round} interpreted and rounded to {num}");

            return num;
        }
        //********************************************************************************************
        //Method: static private double[] GetCash(double num)
        //Purpose: Count bills
        //Parameters:double num
        //Returns: array for the counted bills
        //*********************************************************************************************
        static double[] GetCash(double num)
        {
            //array of doubles to divide num
            double[] array = { 50, 20, 10, 5, 2, 1, 0.25, 0.10, 0.05 };
            //create empty array top store counted values
            double[] count = new double[array.Length];
            //string array to display on console
            string[] note = { "fifty", "twenty", "ten", "five", "toonie", "loonie", "quarter", "dime", "nickel" };

            //go to each index of array to check if num is divisible
            for (int i = 0; i < array.Length; i++)
            {
                //if index value is greater then divide num
                if (num >= array[i])
                {
                    count[i] = num / array[i];//divide num
                    num = Math.Round(num % array[i],2);//store new num
                }
            }
            //display number of notes on console
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(note[i] + " x " + (int)count[i]);
            }
            return count;

        }
        //********************************************************************************************
        //Method: static void DisplayCash(double num, double[] count)
        //Purpose: dispaly bills in gdi
        //Parameters:double num to display on window
        //double double[] count- to display total bills on window
        //Returns: 
        //*********************************************************************************************
        static void DisplayCash(double num, double[] count)
        {
            //create canvas
            CDrawer canvas = new CDrawer();

            //array of colors to fill shapes
            Color[] colors = {Color.Pink, Color.LightGreen, Color.Lavender, Color.LightBlue, Color.Silver, Color.Yellow,
            Color.Gray,Color.Gray,Color.Gray};

            //array of strings to display
            string[] note = { "$50 x", "$20 x ", "$10 x ", "$5 x ", "$2 x ", "$1 x ", "$0.25 x ", "$0.10 x ", "$0.05 x " };
            //array for coordinates
            int[] y = { 100, 200, 300, 400, 500, 100, 200, 300, 400 };
            int[] x = { 200, 200, 200, 200, 200, 600, 600, 600, 600 };
            //display user input
            canvas.AddText($"${num:f2}",25, 280, 50, 300, 50, Color.Yellow);

            //move coordiante points
            for (int xAndY = 0; xAndY < y.Length; xAndY++)
            {
                //print at each coordinate
                for (int i = 0; i < count.Length; i++)
                {
                    //if index value is empty, skip the count[i] value
                    if (count[i] >= 1)
                    {
                        string amount = note[i] + $" {(int)count[i]}"; //assign string to display

                        if (i < 4)//if index is less than 4, print rectangle
                        {
                            canvas.AddCenteredRectangle(x[xAndY], y[xAndY], 200, 95, colors[i], 2, Color.Gray);
                            canvas.AddText(amount, 15, x[xAndY] / 2, y[xAndY] - 50, 200, 100, Color.Black);
                            count[i] = 0;

                        }
                        else if (i > 3 && i < 9)//if index is greater than 3 and less than 9, print ellipse
                        {
                            canvas.AddCenteredEllipse(x[xAndY], y[xAndY], 95, 95, colors[i],2,Color.DarkGray);
                            canvas.AddText(amount, 15, x[xAndY] - 50, y[xAndY] - 50, 100, 100, Color.Black);
                            count[i] = 0;
                        }
                        //force print to end so shapes dont overlap
                        i = count.Length;
                        
                    }

                }

            }

        }
        //********************************************************************************************
        //Method: static bool Reset(string prompt, bool reset)
        //Purpose: ask user to run program again
        //Parameters:string prompt
        //bool reset
        //Returns: bool if user wants to run program again
        //*********************************************************************************************
        static bool Reset(string prompt,bool reset)
        {
            string input;//user input
            Console.WriteLine(prompt);
            input = Console.ReadLine().ToLower();//convert user input to lower

            //set condition to true if user inputs "y" or "yes"
            if (input == "y" || input == "yes") 
            { 
                return true;
            }
            //else return false to end program
            else
            return false; 

        }
    }   
}


