using ManagementSystemSchool1.Business;
using ManagementSystemSchool1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemSchool1.Display
{
    public class TeacherDisplay
    {
        private int closeOperationId = 6;
        TeacherBusiness teacherBusiness = new TeacherBusiness();
        public TeacherDisplay()
        {
            Input();
        }

        private static void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 17) + "Teacher");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all teachers");
            Console.WriteLine("2. Add new teacher");
            Console.WriteLine("3. Update teacher");
            Console.WriteLine("4. Display teacher by ID");
            Console.WriteLine("5. Delete teacher by ID");
            Console.WriteLine("6. Exit teacher");
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
                        ListAllTeachers();
                        break;
                    case 2:
                        AddTeacher();
                        break;
                    case 3:
                        UpdateTeacher();
                        break;
                    case 4:
                        FetchTeacher();
                        break;
                    case 5:
                        DeleteTeacher();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Press any key..."); Console.ReadKey(); Console.Clear();
            } while (operation != closeOperationId);
        }
        private void AddTeacher()
        {
            Teacher teacher = new Teacher();
            Console.Write("First name: ");
            teacher.First_Name = Console.ReadLine();
            Console.Write("Last name: ");
            teacher.Last_Name = Console.ReadLine();
            teacherBusiness.AddTeacher(teacher);
            Console.WriteLine("The teacher has been added!");
        }

        private void DeleteTeacher()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Teacher teacher = teacherBusiness.GetTeacher(id);
            if (teacher != null)
            {
                teacherBusiness.DeleteTeacher(teacher);
                Console.WriteLine("The teacher has been deleted!");
            }
            else
            {
                Console.WriteLine("Teacher not found!");
            }
        }
        private void UpdateTeacher()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Teacher teacher = teacherBusiness.GetTeacher(id);
            if (teacher != null)
            {
                Console.WriteLine($"{teacher.Id} {teacher.First_Name} {teacher.Last_Name}");
                Console.Write("First name: ");
                teacher.First_Name = Console.ReadLine();
                Console.Write("Last name: ");
                teacher.Last_Name = Console.ReadLine();
                teacherBusiness.UpdateTeacher(teacher);
                Console.WriteLine("The teacher has been updated!");
            }
            else
            {
                Console.WriteLine("Teacher not found!");
            }
        }
        private void FetchTeacher()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Teacher teacher = teacherBusiness.GetTeacher(id);
            if (teacher != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + teacher.Id);
                Console.WriteLine("First name: " + teacher.First_Name);
                Console.WriteLine("Last name: " + teacher.Last_Name);
                Console.WriteLine(new string('-', 40));
            }
            else
            {
                Console.WriteLine("Teacher not found!");
            }

        }

        private void ListAllTeachers()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "Teacher");
            Console.WriteLine(new string('-', 40));
            var teacher = teacherBusiness.GetAllTeachers();
            foreach (var item in teacher)
            {
                Console.WriteLine($"{item.Id} {item.First_Name} {item.Last_Name}");
            }

        }
    }
}
