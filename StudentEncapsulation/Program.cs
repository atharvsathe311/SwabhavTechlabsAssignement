using StudentEncapsulation;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student[] student = new Student[]
            {
                new Student{RollNumber = 1 , Name = "Atharv" , Cgpa = 9.33},
                new Student{RollNumber = -3 , Name = "Om" , Cgpa = -2}
            };

            bool terminateCondition = true;

            while (terminateCondition)
            {
                Console.WriteLine();
                Console.WriteLine("Enter 1 to Enter Index Number and 0 to Exit");
                int userChoice = int.Parse(Console.ReadLine());

                if (userChoice == 0)
                {
                    terminateCondition = false;
                    continue;
                }

                Console.WriteLine("Enter Index Number");
                int userInput = int.Parse(Console.ReadLine());

                Student selectedStudent = student[userInput - 1];

                PrintDetails(selectedStudent);
            }


        }

        public static void PrintDetails(Student student)
        { 
            //Console.WriteLine(student);
            Console.WriteLine("Student Roll Number : " + student.RollNumber);
            Console.WriteLine("Student Name : "+student.Name);
            Console.WriteLine("Student CGPA : "+student.Cgpa);
        }
    }
}