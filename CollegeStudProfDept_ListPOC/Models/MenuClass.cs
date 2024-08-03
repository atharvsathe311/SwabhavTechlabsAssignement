using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CollegeStudProfDept.Models
{
    public class MenuClass
    {
        List<College> list = new List<College> { };
        public void MainMenu()
        {

            if (list.Count <= 0)
            {
                Console.WriteLine("No College Exist Please Add College !");
                AddCollege();
            }

            bool breakCondition = true;

            while (breakCondition)
            {
                Console.WriteLine("Press 1 -> To Enter College Id");
                Console.WriteLine("Press 2 -> To Add College");
                Console.WriteLine("Press 3 -> To Delete College");
                Console.WriteLine("Press 4 -> To Add Details of College");
                Console.WriteLine("Press 5 -> To Update Details of College");
                Console.WriteLine("Press 6 -> To Delete Details of College");
                Console.WriteLine("Press 7 -> To Exit");

                int userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        CollegePrint();
                        break;
                    case 2:
                        AddCollege();
                        break;
                    case 3:
                        DeleteCollege();
                        break;
                    case 4:
                        AddCollegeDetails();
                        break;
                    case 5:
                        UpdateCollegeDetails();
                        break;
                    case 6:
                        DeleteCollegeDetails();
                        break;
                    case 7:
                        breakCondition = false;
                        break;
                }
            }
        }

        public void AddCollege()
        {
            Console.WriteLine("Enter Collge Id:");
            int collegeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter College Name:");
            string collegeName = Console.ReadLine();

            College college = new College(collegeId, collegeName);
            list.Add(college);
        }

        public void AddCollegeDetails()
        {
            Console.WriteLine("Enter College Id");
            int userCollegeID = int.Parse(Console.ReadLine());

            var condition = (CollegeDetailFor(userCollegeID)) ? "" : "College Id Not Exist!";
            Console.WriteLine(condition);

        }

        public bool CollegeDetailFor(int userChoice)
        {
            for (int iterator = 0; iterator < list.Count; iterator++)
            {
                College college = list[iterator];
                if (college.GetId() == userChoice)
                {
                    Console.WriteLine("Press 1 -> Add Student");
                    Console.WriteLine("Press 2 -> Add Professor");
                    Console.WriteLine("Press 3 -> Add Department");
                    int addChoice = int.Parse(Console.ReadLine());
                    switch (addChoice)
                    {
                        case 1:
                            college.AddStudent();
                            Console.WriteLine("Student Added Successfully");
                            return true;
                        case 2:
                            college.AddProfessor();
                            Console.WriteLine("Professor Added Successfully");
                            return true;
                        case 3:
                            college.AddDepartment();
                            Console.WriteLine("Department Added Successfully");
                            return true;
                    }
                }
            }
            return false;
        }

        public void CollegePrint()
        {
            Console.WriteLine("Enter College Id");
            int userCollegeID = int.Parse(Console.ReadLine());
            var condition = (CollegeSelectPrint(userCollegeID)) ? "" : "College Id Not Exist!";
            Console.WriteLine(condition);

        }

        public bool CollegeSelectPrint(int userCollegeID)
        {

            for (int iterator = 0; iterator < list.Count; iterator++)
            {
                College college = list[iterator];
                if (college.GetId() == userCollegeID)
                {
                    College college1 = college;

                    college1.PrintDetailsCollege();
                    college1.PrintDetailsStudent();
                    college1.PrintDetailsProfessor();
                    college1.PrintDetailsDepartment();
                    return true;
                }
            }
            return false;

        }

        public void UpdateCollegeDetails()
        {
            Console.WriteLine("Enter College Id");
            int userCollegeID = int.Parse(Console.ReadLine());

            var condition = (CollegeUpdateFor(userCollegeID)) ? "" : "College Id Not Exist!";
            Console.WriteLine(condition);

        }

        public bool CollegeUpdateFor(int userChoice)
        {
            for (int iterator = 0; iterator < list.Count; iterator++)
            {
                College college = list[iterator];
                if (college.GetId() == userChoice)
                {
                    Console.WriteLine("Press 1 -> Update Student");
                    Console.WriteLine("Press 2 -> Update Professor");
                    Console.WriteLine("Press 3 -> Update Department");
                    int updateChoice = int.Parse(Console.ReadLine());
                    switch (updateChoice)
                    {
                        case 1:
                            var condition = (college.UpdateStudent()) ? "Student Updated Successfully" : "Student does not Exist!!";
                            Console.WriteLine(condition);
                            return true;
                        case 2:
                            var condition2 = (college.UpdateProfessor()) ? "Professor Updated Successfully" : "Professor does not Exist!!";
                            Console.WriteLine(condition2);
                            return true;
                        case 3:
                            var condition3 = (college.UpdateDepartment()) ? "Department Updated Successfully" : "Department does not Exist!!";
                            Console.WriteLine(condition3);
                            return true;
                    }
                }
            }
            return false;
        }

        public void DeleteCollegeDetails()
        {
            Console.WriteLine("Enter College Id");
            int userCollegeID = int.Parse(Console.ReadLine());

            var condition = (DeleteDetailsFor(userCollegeID)) ? "" : "College Id Not Exist!";
            Console.WriteLine(condition);

        }

        public bool DeleteDetailsFor(int userChoice)
        {
            for (int iterator = 0; iterator < list.Count; iterator++)
            {
                College college = list[iterator];
                if (college.GetId() == userChoice)
                {
                    Console.WriteLine("Press 1 -> Delete Student");
                    Console.WriteLine("Press 2 -> Delete Professor");
                    Console.WriteLine("Press 3 -> Delete Department");
                    int updateChoice = int.Parse(Console.ReadLine());
                    switch (updateChoice)
                    {
                        case 1:
                            var condition = (college.DeleteStudent()) ? "Student Deleted Successfully" : "Student does not Exist!!";
                            Console.WriteLine(condition);
                            return true;
                        case 2:
                            var condition2 = (college.DeleteProfessor()) ? "Professor Deleted Successfully" : "Professor does not Exist!!";
                            Console.WriteLine(condition2);
                            return true;
                        case 3:
                            var condition3 = (college.DeleteDepartment()) ? "Department Deleted Successfully" : "Department does not Exist!!";
                            Console.WriteLine(condition3);
                            return true;
                    }
                }
            }
            return false;
        }

        public void DeleteCollege()
        {
            Console.WriteLine("Enter College Id");
            int userCollegeID = int.Parse(Console.ReadLine());

            var condition = (DeleteCollegeFor(userCollegeID)) ? "Deleted Successful" : "College Id Not Exist!";
            Console.WriteLine(condition);

        }

        public bool DeleteCollegeFor(int userChoice)
        {
            for (int iterator = 0; iterator < list.Count; iterator++)
            {
                College college = list[iterator];
                if (college.GetId() == userChoice)
                {
                    if (list.Remove(college))
                    {
                        return true;
                    };
                }
            }
            return false;
        }

    }
}

