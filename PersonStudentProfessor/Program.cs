using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeStudProf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person student = new Student(1, "Thane", "03/11/2002", "Information Technology");
            PrintDetails(student);
            Console.WriteLine("The Person Branch :"+student.GetBranch());
            Console.WriteLine();
            Person professor = new Professor(2,"Airoli","25/01/1978",40000);
            PrintDetails(professor);
            Console.WriteLine("The Person Salary :"+professor.CalculateSalary());

        }

        public static void PrintDetails(Person person) 
        {
            Console.WriteLine("The Person Type :"+person.GetType().Name);
            Console.WriteLine("The Person Id :" +person.GetId());
            Console.WriteLine("The Person Adress :"+person.GetAddress());
            Console.WriteLine("The Person BirthDate :"+person.GetDateOfBirth());
        }
    }
}
