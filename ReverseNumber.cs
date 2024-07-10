using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int intermediate;
            int result = 0;
            Console.WriteLine("Enter the Number");
            number = int.Parse(Console.ReadLine());

            while (number > 0)
            {
                intermediate = number % 10;
                result = result * 10 + intermediate;
                number = (int)number / 10;
            }

             Console.WriteLine("The Reverse of the Number {0}",result);

        }
    }
}
