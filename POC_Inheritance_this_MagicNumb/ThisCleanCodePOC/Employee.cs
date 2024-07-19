using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCthiskeywordandConsts
{
    class Employee
    {
        private int _empId;
        private string _empName;
        private int _empAge;
        public const int DEFAULT_AGE = 21;
        public Employee(int empId , string empName) :this(empId,empName,DEFAULT_AGE)
        { }

        public Employee(int empId , string empName,int Age)
        {
            _empId = empId;
            _empName = empName;
            _empAge = Age;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Employee Id id "+_empId);
            Console.WriteLine("Employee Name is " + _empName);
            Console.WriteLine("Employee Age is "+_empAge);

        }
    }
}
