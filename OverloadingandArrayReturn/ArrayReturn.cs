using System;
namespace ArrayReturn
{
    class ArrayReturn
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Elements of Array");

            int arraySize = int.Parse(Console.ReadLine());

            int[] myArray = new int[arraySize];

            for (int input = 0; input < arraySize; input++)
                {
                   Console.WriteLine("Enter the {0} Number", input + 1);
                    int userInput = int.Parse(Console.ReadLine());
                    myArray[input] = userInput;
                }

            Console.Write("The Array is : ");
            PrintArray(myArray);

            Console.WriteLine();

            int[] changedArray = ChangeArray(myArray);
            PrintArray(changedArray);
        }

        static int[] ChangeArray(int[] array)
        {
            int userIndex;
            while (true)
            {
                Console.WriteLine("Enter the Index to change value at.");
                userIndex = int.Parse(Console.ReadLine());

                if (userIndex < 0 || userIndex > array.Length)
                    continue;

                break;

            }

            Console.WriteLine("Enter the Value :");
            int userValue = int.Parse(Console.ReadLine());

            array[userIndex-1] = userValue;
            Console.WriteLine("Value changed at Index {0} with {1}",userIndex,userValue);

            return array;
        }

        static void PrintArray(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine("]");
        }

    }
}