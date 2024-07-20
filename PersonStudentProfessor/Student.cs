using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeStudProf
{
    internal class Student:Person
    {
        private string _branch;
        public Student(int id,string adress,string dateOfBirth,string branch):base(id,adress,dateOfBirth)
        {
            _branch = branch;
        }

        public override string GetBranch() {  return _branch; }
    }
}
