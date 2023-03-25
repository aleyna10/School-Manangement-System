using ManagementSystemSchool1.Business;
using ManagementSystemSchool1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemSchool1.Display
{
    public class UniversityDisplay
    {
        private int closeOperationId = 6;
        UniversityBusiness universityBusiness = new UniversityBusiness();
        public UniversityDisplay()
        {
            Input();
        }

        private static void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "University");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all universities");
            Console.WriteLine("2. Add new university");
            Console.WriteLine("3. Update university");
            Console.WriteLine("4. Display university by ID");
            Console.WriteLine("5. Delete university by ID");
            Console.WriteLine("6. Exit university");
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
                        ListAllUniversities();
                        break;
                    case 2:
                        AddUniversity();
                        break;
                    case 3:
                        UpdateUniversity();
                        break;
                    case 4:
                        FetchUniversity();
                        break;
                    case 5:
                        DeleteUniversity();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Press any key..."); Console.ReadKey(); Console.Clear();
            } while (operation != closeOperationId);
        }
        private void AddUniversity()
        {
            University university = new University();
            Console.Write("Name: ");
            university.Name = Console.ReadLine();
            Console.Write("City Id: ");
            university.CityId = int.Parse(Console.ReadLine());
            Console.Write("Teacher Id: ");
            university.TeacherId = int.Parse(Console.ReadLine());
            universityBusiness.AddUniversity(university);
            Console.WriteLine("The university has been added!");
        }

        private void DeleteUniversity()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            University university = universityBusiness.GetUniversity(id);
            if (university != null)
            {
                universityBusiness.DeleteUniversity(university);
                Console.WriteLine("The university has been deleted!");
            }
            else
            {
                Console.WriteLine("University not found!");
            }
        }
        private void UpdateUniversity()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            University university = universityBusiness.GetUniversity(id);
            if (university != null)
            {
                Console.WriteLine($"{university.Id} {university.Name} {university.CityId} {university.TeacherId}");
                Console.Write("Name: ");
                university.Name = Console.ReadLine();
                Console.Write("City Id: ");
                university.CityId = int.Parse(Console.ReadLine());
                Console.Write("Teacher Id: ");
                university.TeacherId = int.Parse(Console.ReadLine());
                universityBusiness.UpdateUniversity(university);
                Console.WriteLine("The university has been updated!");
            }
            else
            {
                Console.WriteLine("University not found!");
            }
        }
        private void FetchUniversity()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            University university = universityBusiness.GetUniversity(id);
            if (university != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + university.Id);
                Console.WriteLine("Name: " + university.Name);
                Console.WriteLine("City Id: " + university.CityId);
                Console.WriteLine("Teacher Id: " + university.TeacherId);
                Console.WriteLine(new string('-', 40));
            }
            else
            {
                Console.WriteLine("University not found!");
            }

        }

        private void ListAllUniversities()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "University");
            Console.WriteLine(new string('-', 40));
            var city = universityBusiness.GetAllUniversities();
            foreach (var item in city)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.CityId} {item.TeacherId}");
            }

        }
    }
}
