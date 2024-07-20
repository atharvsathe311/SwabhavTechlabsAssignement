using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeStudProf
{
    internal class Professor : Person
    {
        public const double MULTIPLIER = 0.4;
        private double _basic;
        public Professor(int id, string address, string dateOfBirth, double basic) : base(id, address, dateOfBirth)
        {
            _basic = basic;
        }

        public override double CalculateSalary()
        {
            double salary;
            salary = _basic + _basic * MULTIPLIER;
            return salary;
        }

    }
}
