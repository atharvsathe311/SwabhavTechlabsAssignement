using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[]
            {
                new Person(2, "Amit", 21, 6, 50),
                new Person(1, "Atharv", 21),
            };

            foreach(Person person1 in person)
            {
                Print(person1);
            }

            Console.WriteLine("Max BMI is :"+ person[0].MaxBMI());
            

        }

        static void Print(Person person)
        {
            Console.WriteLine("BMI of Person : " + person.BodyMassIndex());
            Console.WriteLine("Body Type Person : " + person.BodyType());
            Console.WriteLine();
        }
    }
}
