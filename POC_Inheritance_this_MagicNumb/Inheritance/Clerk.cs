using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsARelationship
{
    class Clerk : Employee
    {
        public double empBonus;
        public Clerk(int empId, string empName, int empAge, double empSalary, double empBonus) : base(empId, empName, empAge, empSalary)
        {
            this.empBonus = empBonus;
        }

        //public override double PrintDetails(out int empId, out string empName, out int empAge, out double empSalary)
        //{
        //    empId = base.empId;
        //    empName = base.empName;
        //    empAge = base.empAge;
        //    empSalary = base.empSalary;
        //    return this.empBonus;
        //}

        public override string PrintDetails()
        {
            return $"{base.PrintDetails()} , Bonus : {empBonus}";
        }

    }
}
