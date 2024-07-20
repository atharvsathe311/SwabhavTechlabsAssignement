using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] denominations = { 2000, 500, 200, 100 };
            int userInput;

            while (true) 
            {
                Console.WriteLine("Enter withdrawal amount :");
                userInput = int.Parse(Console.ReadLine());

                if (userInput >= 50000)
                {
                    Console.WriteLine("Amount exceeds withdrwal limit of 50000");
                    continue;
                }

                if (userInput % 100 != 0 )
                {
                    Console.WriteLine("Amount should be in multiples of 100");
                    continue;
                }

                break;

            }

            int[] denominationCount = new int[denominations.Length];

            for (int i = 0; i < denominations.Length; i++)
            {
                denominationCount[i] = userInput / denominations[i];
                userInput -= denominationCount[i] * denominations[i];
            }

            if (denominationCount[0] > 0)
                Console.WriteLine($"Two Thousand :{denominationCount[0]}");
            if (denominationCount[1] > 0)
                Console.WriteLine($"Five Hundred :{denominationCount[1]}");
            if (denominationCount[2] > 0)
                Console.WriteLine($"Two Hundred :{denominationCount[2]}");
            if (denominationCount[3] > 0)
                Console.WriteLine($"Hundred :{denominationCount[3]}");
        }
    }
}
