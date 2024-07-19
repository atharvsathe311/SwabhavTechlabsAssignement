using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsARelationship
{
    class Manager : Employee
    {
        public double empIncentive;
        public Manager(int empId, string empName, int empAge, double empSalary, double empIncentive) : base(empId, empName, empAge, empSalary)
        {
            this.empIncentive = empIncentive;
        }

        //public override double PrintDetails(out int empId,out  string empName,out int empAge,out double empSalary)
        //{
        //    empId = base.empId;
        //    empName = base.empName;
        //    empAge = base.empAge;
        //    empSalary = base.empSalary;

        //    return this.empIncentive;
        //}

        public override string PrintDetails()
        {
            return $"{base.PrintDetails()} , Incentive : {empIncentive}";
        }

    }
}
