using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeStudProf
{
    internal class Person
    {
        private int _id;
        private string _address;
        private string _dateOfBirth;
        public Person(int id , string address , string dateOfBirth) 
        {
            _id = id;
            _address = address;
            _dateOfBirth = dateOfBirth;
        }

        public int GetId() {  return _id; }
        public string GetAddress() { return _address; } 
        public string GetDateOfBirth() { return _dateOfBirth; }

        public virtual double CalculateSalary()
        {
            return 0;
        }
        public virtual string GetBranch() { return ""; }

    }
}
