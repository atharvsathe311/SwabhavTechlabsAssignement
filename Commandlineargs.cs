using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSumAvg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputLength = args.Length;
            Console.WriteLine("Count of Inputs is " + inputLength);
            int avg = 0;
            int max = int.Parse(args[0]);
            int min = int.Parse(args[0]);

            for (int i = 0; i < inputLength; i++)
            {
                int temporary = int.Parse(args[i]);
                avg += temporary;

                if (temporary > max) { max = temporary; }

                if (temporary < min) { max = temporary; }

            }

            int sum = avg;
            avg = avg / inputLength;

            Console.WriteLine("\nSum of the Inputs is " + sum);
            Console.WriteLine("\nAverage of the Inputs is " + avg);
            Console.WriteLine("\nMax of the Inputs is " + max);
            Console.WriteLine("\nMin of the Inputs is " + min);
        }
        }
}






