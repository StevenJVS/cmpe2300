using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6_Exercise1
{
    internal class Program
    {
        private struct SGolfScoreType{
            public string _firstName;
            public string _lastName;
            public int _score;

            

            }

        static void Main(string[] args)
        {
            SGolfScoreType player1, player2;
            bool success;

            Console.WriteLine("Input values for player 1");
            Console.Write("FirstName: ");
            player1._firstName=Console.ReadLine();
            Console.Write("Last Name: ");
            player1._lastName=Console.ReadLine();
            Console.Write("Score: ");
            success =int.TryParse(Console.ReadLine(), out player1._score);


            Console.WriteLine();

            Console.WriteLine("Input values for player 2");
            Console.Write("FirstName: ");
            player2._firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            player2._lastName = Console.ReadLine();
            Console.Write("Score: ");
            success = int.TryParse(Console.ReadLine(), out player2._score);

            //We asasume that the there is no tie
            if (player1._score > player2._score)
                Console.WriteLine($"Winner is : {player1._firstName} {player1._lastName} with a score of {player1._score}");
            else
                Console.WriteLine($"Winner is : {player2._firstName} {player2._lastName} with a score of {player2._score}");

        }
    }
}
