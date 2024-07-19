using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsARelationship
{
    class Employee
    {
        public int empId;
        public string empName;
        public int empAge;
        public double empSalary;
        public Employee(int empId ,string empName,int empAge ,double empSalary) 
        { 
            this.empId = empId;
            this.empName = empName;
            this.empAge = empAge;
            this.empSalary = empSalary;
        }

        //public virtual double PrintDetails(out int empId,out string empName,out int empAge , out double salary )
        //{
        //    empId = this.empId;
        //    empName = this.empName; 
        //    empAge = this.empAge;
        //    salary = this.empSalary;
        //    return 0;
        //}

        public virtual string PrintDetails()
        {
            return $"Id : {empId} , Name : {empName} , Age :{empAge} , Salary :{empSalary}";
        }

    }

    


  


}
