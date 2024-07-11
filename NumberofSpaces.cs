using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberofSpaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Sentence");
            String userInput = Console.ReadLine();
            int count = 0;

            for (int iterator = 0; iterator < userInput.Length; iterator++)
                if (userInput[iterator] == ' ') count++;

            Console.WriteLine(count);

        }
    }
}
