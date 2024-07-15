using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGame
{
    internal class Program
    {
        public const int TARGET_SCORE = 20; 
        static void Main(string[] args)
        {
            Console.WriteLine("Let's Play PIG!");
            Console.WriteLine("See how many turns it takes you to get to 20");
            Console.WriteLine("Turn ends when you hold or roll a 1.");
            Console.WriteLine("If you roll a 1, you lose all points for the turn.");
            Console.WriteLine("If you hold, you save all points for the turn.");
            int turnNumber = 1;
            int score = 0;
            int count = 0;
            Random rnd = new Random();

            while(score <= TARGET_SCORE)
            {
                Console.WriteLine();
                Console.WriteLine("Turn Number {0}", turnNumber);
                Console.WriteLine("Enter 'r' to roll again, 'h' to hold.");
                String userInput = Console.ReadLine().ToLower();
                int diceOutput = rnd.Next(1, 6);
                Console.WriteLine("You rolled: {0}", diceOutput);

                if (userInput == "r" && diceOutput != 1)
                {
                    score += diceOutput;
                    Console.WriteLine("Your turn Score is {0} and total score is {1}", diceOutput, score);
                }

                if (userInput == "r" && diceOutput == 1)
                {
                    score = 0;
                    Console.WriteLine("Your turn Score is {0} and total score is {1}", diceOutput, score);
                }

                if (userInput == "h")
                    Console.WriteLine("You holded the Score so your total score is {0}", score);

                Console.WriteLine("If you hold,you will have {0} points",score);

                turnNumber++;
            }

            Console.WriteLine("You Win! You finished in {0} turns!", turnNumber);
            Console.WriteLine("Game over!");

        }
    }
}
