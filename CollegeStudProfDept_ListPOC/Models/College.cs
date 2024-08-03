using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeStudProfDept.Models
{
    public class College
    {
        private int _collegeId;
        private string _collegeName;
        private List<Student> studentList = new List<Student> { };
        private List<Professor> professorList = new List<Professor> { };
        private List<Department> departmentList = new List<Department> { };

        public College(int id, string name)
        {
            _collegeId = id;
            _collegeName = name;
        }

        public int GetId()
        {
            return _collegeId;
        }

        public string GetName()
        {
            return _collegeName;
        }

        public void PrintDetailsCollege()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("College Id : " + _collegeId);
            Console.WriteLine("College Name : " + _collegeName);
            Console.WriteLine("--------------------------------------");
        }

        public void PrintDetailsStudent()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Printing the College Students");
            Console.WriteLine("--------------------------------------");
            foreach (Student item in studentList)
            {
                Console.WriteLine("Id = " + item.Id);
                Console.WriteLine("Name = " + item.Name);
            }
            Console.WriteLine("--------------------------------------");

        }

        public void PrintDetailsProfessor()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Printing the College Professors ");
            Console.WriteLine("--------------------------------------");
            foreach (Professor item in professorList)
            {
                Console.WriteLine("Id = " + item.Id);
                Console.WriteLine("Name = " + item.Name);
            }
            Console.WriteLine("--------------------------------------");
        }

        public void PrintDetailsDepartment()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Printing the College’s Departments");
            Console.WriteLine("--------------------------------------");
            foreach (Department item in departmentList)
            {
                Console.WriteLine("Id = " + item.Id);
                Console.WriteLine("Name = " + item.Name);
            }
            Console.WriteLine("--------------------------------------");
        }

        public void AddStudent()
        {
            Console.WriteLine("Enter the Student Id : ");
            int userId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Student Name : ");
            string userName = Console.ReadLine();
            Student student = new Student(userId, userName);
            studentList.Add(student);
        }

        public void AddProfessor()
        {
            Console.WriteLine("Enter the Professor Id : ");
            int userId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Professor Name : ");
            string userName = Console.ReadLine();
            Professor professor = new Professor(userId, userName);
            professorList.Add(professor);
        }

        public void AddDepartment()
        {
            Console.WriteLine("Enter the Department Id : ");
            int departmentId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Department Name : ");
            string departmentName = Console.ReadLine();
            Department department = new Department(departmentId, departmentName);
            departmentList.Add(department);
        }

        public bool UpdateStudent()
        {
            Console.WriteLine("Enter the Student Id : ");
            int studentId = int.Parse(Console.ReadLine());

            foreach (Student student in studentList)
            {
                if (student.Id == studentId)
                {
                    Console.WriteLine("Enter the Student Name To Update : ");
                    string userName = Console.ReadLine();
                    student.Name = userName;
                    return true;
                }    
            }
            return false;
        }

        public bool UpdateProfessor()
        {
            Console.WriteLine("Enter the Professor Id : ");
            int professorId = int.Parse(Console.ReadLine());

            foreach (Professor professor in professorList)
            {
                if (professor.Id == professorId)
                {
                    Console.WriteLine("Enter the Professor Name To Update : ");
                    string userName = Console.ReadLine();
                    professor.Name = userName;
                    return true;
                }
            }
            return false;
        }

        public bool UpdateDepartment()
        {
            Console.WriteLine("Enter the Department Id : ");
            int departmentId = int.Parse(Console.ReadLine());

            foreach (Department department in departmentList)
            {
                if (department.Id == departmentId)
                {
                    Console.WriteLine("Enter the Department Name To Update : ");
                    string departmentName = Console.ReadLine();
                    department.Name = departmentName;
                    return true;
                }
            }
            return false;
        }

        public bool DeleteStudent()
        {
            Console.WriteLine("Enter the Student Id : ");
            int studentId = int.Parse(Console.ReadLine());

            foreach (Student student in studentList)
            {
                if (student.Id == studentId)
                {
                    studentList.Remove(student);
                    return true;
                }
            }
            return false;
        }

        public bool DeleteProfessor()
        {
            Console.WriteLine("Enter the Professor Id : ");
            int professorId = int.Parse(Console.ReadLine());

            foreach (Professor professor in professorList)
            {
                if (professor.Id == professorId)
                {
                    professorList.Remove(professor);
                    return true;
                }
            }
            return false;
        }

        public bool DeleteDepartment()
        {
            Console.WriteLine("Enter the Department Id : ");
            int departmentId = int.Parse(Console.ReadLine());

            foreach (Department department in departmentList)
            {
                if (department.Id == departmentId)
                {
                    departmentList.Remove(department);
                    return true;
                }
            }
            return false;
        }
    }


}
