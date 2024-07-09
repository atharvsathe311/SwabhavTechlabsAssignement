using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Count uptill where to print");
            int count = int.Parse(Console.ReadLine());
            int element1 = 0;
            int element2 = 1;
            Console.Write(element1 + " " + element2 + " ");
            for (int i = 2; i < count; i++)
            {
                int temporary = element1 + element2;
                Console.Write(temporary + " ");

                element1 = element2;
                element2 = temporary;

            }

            Console.ReadLine();
        }
    }
}
