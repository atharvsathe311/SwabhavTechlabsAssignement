using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEncapsulation
{
    class Student
    {
        public const int MINIMUM_CGPA = 0;
        public const int MAXIMUM_CGPA = 10;


        private int _rollNumber;
        private string _name;
        private double _cgpa;
        public int RollNumber 
        {
            get 
            {
                return _rollNumber;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Roll Number can't be Negative");
                }

                if (value >= 0) 
                {
                    _rollNumber = value;
                }
            } 
        }
        public string Name 
        { 
            get 
            { 
                return _name; 
            } 
            set 
            {
                if (value.Length < 5)
                {
                    _name = "";
                }
                else
                {
                    _name = value;
                }
            } 
        }
        public double Cgpa 
        {
            get 
            {
                return _cgpa;
            }
            set 
            {
                if (MINIMUM_CGPA > value || MAXIMUM_CGPA < value)
                {
                    Console.WriteLine("Invalid CGPA");
                }
                else
                {
                    _cgpa = value;
                }

            } 
        }
    }
}
