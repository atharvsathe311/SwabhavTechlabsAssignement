using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class Person
    {
        public const int DEFAULT_HEIGHT = 5;
        public const int DEFAULT_WEIGHT = 50;
        public const double CONVERSION_FACTOR  = 3.381;
        public const double UNDER_WEIGHT_CONDITION = 18.4;
        public const double NORMAL_WEIGHT_CONDITION = 24.9;
        public const double OVER_WEIGHT_CONDITION = 39.9;
        private int _id;
        private string _name;
        private int _age;
        private int _height;
        private int _weight;
        private double _currentBMI;
        public static double maxBMI = 0;

        public Person(int id, string name, int age, int height, int weight)
        {
            _id = id;
            _name = name;
            _age = age;
            _height = height;
            _weight = weight;
            
        }

        public Person(int id, string name, int age) : this(id, name, age, DEFAULT_HEIGHT, DEFAULT_WEIGHT)
        {
           
        }

        public double BodyMassIndex()
        {
            double bmiValue;
            bmiValue = _weight / Math.Pow((_height/ 3.281),2) ;

            if (bmiValue > maxBMI)
                maxBMI = bmiValue;
            return bmiValue;
        }

        public string BodyType()
        {
            double bmi = this.BodyMassIndex();
            if (bmi <= UNDER_WEIGHT_CONDITION)
            {
                return "UnderWeight";
            }
            
            if (UNDER_WEIGHT_CONDITION < bmi && bmi <= NORMAL_WEIGHT_CONDITION)
            {
                return "Normal";
            }
            
            if (NORMAL_WEIGHT_CONDITION < bmi && bmi <= OVER_WEIGHT_CONDITION)
            {
                return "Overweight";
            }
            
            return "Obese";
        }

        public double MaxBMI()
        {
            return maxBMI;
        }
    }
}
