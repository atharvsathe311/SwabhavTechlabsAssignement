// Palindrome
using System;
namespace Palindrome

{

    public class Program
    {

        static void Main(string[] args)
        {
            int num;
            int inter;
            int result = 0;
            Console.WriteLine("Enter the Number");
            num = int.Parse(Console.ReadLine());
            int ogNumber = num;
            while (num > 0)
            {
                inter = num % 10;
                result = result * 10 + inter;
                num = (int)num / 10;
            }

            if (result == ogNumber)
                Console.WriteLine("The Number " + result + " is Palindrome");
            else
                Console.WriteLine("The Number " + result + " is not a Palindrome");
        }
    }
}