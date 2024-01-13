using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


/*
 * Solution To Lecture3B- Exercise1
 * 
 * Illustrating the use of the StreamWriter and StreamReader Objects
 * 
 * 
 * 
 */
namespace Lecture3B_Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName;

            //Obtain the file name from the user
            Console.Write("Input the file name: ");
            fileName = Console.ReadLine();

            //Creating the StreamWriter Object from the file name
            try
            {
                StreamWriter outFile = new StreamWriter(fileName);


                //If we reach here, it means that the streamWriter object has been successfully created,
                //We can now proceed to read names from the user and write into the file

                bool over = false; //To keep track of when the user wants to stop giving a new name
                try //We need a second try..catch block where we have to write into the
                    //StreamWriter Object
                {

                    do
                    {

                        Console.Write("Give the nextName: ");
                        string nextName = Console.ReadLine();

                        outFile.WriteLine(nextName);

                        //Ask the user if they want to input another name
                        string ans = "";
                        do
                        {
                            Console.Write("Do you want to input another Name? (Y/y/N,n)");
                            ans = Console.ReadLine();
                            if ((ans.ToLower() != "y") && (ans.ToLower() != "n"))
                                Console.WriteLine("You've given a wrong answer");

                        } while ((ans.ToLower() != "y") && (ans.ToLower() != "n"));

                        if (ans.ToLower() != "y")
                            over = true;

                    } while (!over);

                    //After having written the names in the file we close the StreamWriter object. 
                    outFile.Close();

                    Console.WriteLine();

                    //If we reach here, it means that we have successfully written into the file.
                    //We'll now open it for reading.

                    //Reading the file using StreamReader object
                    StreamReader infile=new StreamReader(fileName);
                    string name_read;

                    Console.WriteLine("Reading Names from the file using a Stream Reader Object");
                    //Reading Line by Line from the file and writing onto the console
                    while ((name_read = infile.ReadLine()) != null) //This statement reads a line from the StreamReader object
                                                                    // into the variable name_read and also tests 
                                                                    // whether the end of the file has been reached
                    {
                        Console.WriteLine(name_read);
                    }
                    
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("Reading Names from the file using a File.ReadAllLines()");
                    //Reading from the file using File.ReadAllLines
                    string[] lines=File.ReadAllLines(fileName); //Here we obtain an array of strings from the file

                    foreach(string line in lines)
                        Console.WriteLine(line);




                }
                catch (Exception ex)//Catch for the inner Try
                {
                    Console.WriteLine("An Exception has Occured while trying to create the StreamWriter Object: " + ex.Message);
                }

            }
            catch (Exception ex)//Catch for the outer Try
            {
                Console.WriteLine("An Exception has Occured while trying to create the StreamWriter Object: " + ex.Message);
            }

        }

        

        }
    }
