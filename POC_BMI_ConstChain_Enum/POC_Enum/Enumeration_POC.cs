using System;
namespace Program
{
    class Program
    {
        enum Weekdays
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Weekdays.Saturday);
            Console.WriteLine((int)Weekdays.Wednesday);

        }

    }
}