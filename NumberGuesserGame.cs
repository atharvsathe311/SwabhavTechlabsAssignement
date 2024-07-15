using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int number = random.Next(1, 100);
            int count = 0;

            while (true)
            {
                Console.WriteLine("Enter a guess number between 1 to 100");
                int userGuess = int.Parse(Console.ReadLine());

                if (userGuess == number)
                {
                    Console.WriteLine("Yayyy! Your Guessed Number is Correct.");
                    Console.WriteLine("You took {0} tries! You Win the Game! attempts", count);
                    break;
                }

                var condition = (userGuess < number) ? "oops! sorry, too low ." : "oops! sorry, too high.";
                Console.WriteLine(condition);

                count++;

            }

        }
    }
}
