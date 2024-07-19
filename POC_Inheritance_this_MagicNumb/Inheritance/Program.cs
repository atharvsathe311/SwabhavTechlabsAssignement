using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsARelationship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            int age;
            double salary;
            Employee employee1 = new Clerk(1, "Amit", 21, 20000, 10000);
            //double bonus = employee1.PrintDetails(out id,out name,out age,out salary);
            //PrintingEmployee(id,name,age,salary,bonus,employee1.GetType().Name);

            Employee employee2 = new Manager(2, "Atharv", 21, 40000, 20000);
            //double incentive = employee2.PrintDetails(out id, out name,out age,out salary);
            //PrintingEmployee(id, name, age, salary, incentive, employee2.GetType().Name);
            Print(employee1);
            Print(employee2);


        }

        //public static void PrintingEmployee(int id,string name,int age,double salary,double incentivebonus ,string department)
        //{
        //    Console.WriteLine();
        //    Console.WriteLine(department);
        //    Console.WriteLine("Employee Name :"+name);
        //    Console.WriteLine("Employee Age :"+age);
        //    Console.WriteLine("Employee Salary :"+salary);
        //    Console.WriteLine("Employee Bonus/Incentive :"+incentivebonus);
        //}

        public static void Print(Employee employee)
        {
            Console.WriteLine(employee.GetType().Name);
            Console.WriteLine(employee.PrintDetails());
        }
    }
}
