using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lecture9_Demo6
{
    internal class Program
    {
        struct PrimeData
        {

            public int Min;
            public int Max;

            public PrimeData(int min, int max)
            {
                Min = min;
                Max = max;
            }
        }
        static void Main(string[] args)
        {
            Thread thPrime = new Thread(new ParameterizedThreadStart(FindPrime));
            thPrime.Start(new PrimeData(5000, 10000));
        }


        static void FindPrime(object objData)
        {

            bool bIsPrime = true;// true is value is a prime

            if (objData is PrimeData)
            {

                PrimeData Prime = (PrimeData)objData;

                for (int iNumber = Prime.Min; iNumber <= Prime.Max; ++iNumber)
                {
                    bIsPrime = true;//For each iNumber, initially we assume each value to be prime


                    //We start from 2 and iterate up to iNumber-1 trying to find an Exact divisor
                    //for the iNumber
                    //If no such divisor is found, the number is prime
                    for (int iTry = 2; iTry <=iNumber -1; ++iTry)
                        if (iNumber % iTry == 0)
                            bIsPrime = false;
                    
                    if (bIsPrime)
                    {
                        Console.Write($"{iNumber}, ");
                    Thread.Sleep(5);
                    }


                }
                Console.ReadKey();
            }

        }
    }
}
