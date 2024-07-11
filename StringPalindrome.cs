using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String for cheking if it is Palindrome..");
            String userInput = Console.ReadLine();
            String revesedString = "";
 
            for (int iterator = userInput.Length-1; iterator >= 0 ; iterator--) 
            {
                revesedString += userInput[iterator];
            }

            var toPrint = (userInput == revesedString) ? "The string " + userInput + " is a Palindrome" : "The String " + userInput + " is not a Palindrome";
            Console.WriteLine(toPrint);
        }
    }
}
