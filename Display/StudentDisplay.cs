using ManagementSystemSchool1.Business;
using ManagementSystemSchool1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemSchool1.Display
{
    public class StudentDisplay
    {
        private int closeOperationId = 6;
        StudentBusiness studentBusiness = new StudentBusiness();
        public StudentDisplay()
        {
            Input();
        }

        private static void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "Students");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all students");
            Console.WriteLine("2. Add new student");
            Console.WriteLine("3. Update student");
            Console.WriteLine("4. Display student by ID");
            Console.WriteLine("5. Delete student by ID");
            Console.WriteLine("6. Exit student");
        }

        private void Input()
        {
            var operation = -1;
            do
            {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ListAllStudents();
                        break;
                    case 2:
                        AddStudent();
                        break;
                    case 3:
                        UpdateStudent();
                        break;
                    case 4:
                        FetchStudent();
                        break;
                    case 5:
                        DeleteStudent();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Press any key..."); Console.ReadKey(); Console.Clear();
            } while (operation != closeOperationId);
        }
        private void AddStudent()
        {
            Student student = new Student();
            Console.Write("First name: ");
            student.First_Name = Console.ReadLine();
            Console.Write("Last name: ");
            student.Last_Name = Console.ReadLine();
            Console.Write("High School id: ");
            student.High_SchoolId = int.Parse(Console.ReadLine());
            Console.Write("University id: ");
            student.UniversityId = int.Parse(Console.ReadLine());
            Console.Write("Language id: ");
            student.LanguageId = int.Parse(Console.ReadLine());
            studentBusiness.AddStudent(student);
            Console.WriteLine("The student has been added!");
        }
        private void DeleteStudent()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Student student = studentBusiness.GetStudents(id);
            if (student != null)
            {
                studentBusiness.DeleteStudent(student);
                Console.WriteLine("The student has been deleted!");
            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }
        private void UpdateStudent()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Student student = studentBusiness.GetStudents(id);
            if (student != null)
            {
                Console.WriteLine($"{student.Id} {student.First_Name} {student.Last_Name} {student.High_SchoolId} {student.UniversityId} {student.LanguageId}");
                Console.Write("First name: ");
                student.First_Name = Console.ReadLine();
                Console.Write("Last name: ");
                student.Last_Name = Console.ReadLine();
                Console.Write("High School id: ");
                student.High_SchoolId = int.Parse(Console.ReadLine());
                Console.Write("University id: ");
                student.UniversityId = int.Parse(Console.ReadLine());
                Console.Write("Language id: ");
                student.LanguageId = int.Parse(Console.ReadLine());
                studentBusiness.UpdateStudents(student);
                Console.WriteLine("The student has been updated!");
            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }
        private void FetchStudent()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Student student = studentBusiness.GetStudents(id);
            if (student != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + student.Id);
                Console.WriteLine("Last Name: " + student.First_Name);
                Console.WriteLine("First Name: " + student.Last_Name);
                Console.WriteLine("High Sshool: " + student.High_SchoolId);
                Console.WriteLine("University: " + student.UniversityId);
                Console.WriteLine("Language: " + student.LanguageId);
                Console.WriteLine(new string('-', 40));
            }
            else
            {
                Console.WriteLine("Student not found!");
            }

        }

        private void ListAllStudents()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "Students");
            Console.WriteLine(new string('-', 40));
            var student = studentBusiness.GetAllStudents();
            foreach (var item in student)
            {
                Console.WriteLine($"{item.Id} {item.First_Name} {item.Last_Name} {item.High_SchoolId} {item.UniversityId} {item.LanguageId}");
            }

        }
    }
}
