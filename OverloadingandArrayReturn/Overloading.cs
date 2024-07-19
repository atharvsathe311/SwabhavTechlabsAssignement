using System;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {

            int number1 = 10;
            int number2 = 20;
            int number3 = 30;

            Console.WriteLine("The Addition of Two Numbers is: {0}", Add(number1, number2));
            Console.WriteLine("The Addition of Three Numbers is: {0}", Add(number1, number2, number3));
        }

        public static int Add(int number1, int number2)
        {
            Console.WriteLine("Adding Two Numbers");
            return number1 + number2;
        }

        public static int Add(int number1, int number2, int number3)
        {
            Console.WriteLine("Adding Three Numbers");
            return number1 + number2 + number3;
        }
    }
}