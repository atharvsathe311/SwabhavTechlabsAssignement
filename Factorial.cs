using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number : ");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("The Factorial of above number is : " + factorial);
           
        }
    }
}
