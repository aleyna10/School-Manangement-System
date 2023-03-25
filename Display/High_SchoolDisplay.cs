using ManagementSystemSchool1.Business;
using ManagementSystemSchool1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemSchool1.Display
{
    public class High_SchoolDisplay
    {
        private int closeOperationId = 6;
        High_SchoolBusiness high_SchoolBusiness = new High_SchoolBusiness();
        public High_SchoolDisplay()
        {
            Input();
        }

        private static void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 14) + "High School");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all high schools");
            Console.WriteLine("2. Add new high school");
            Console.WriteLine("3. Update high school");
            Console.WriteLine("4. Display high school by ID");
            Console.WriteLine("5. Delete high school by ID");
            Console.WriteLine("6. Exit high school");
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
                        ListAllHighSchools();
                        break;
                    case 2:
                        AddHighSchool();
                        break;
                    case 3:
                        UpdateHighSchool();
                        break;
                    case 4:
                        FetchHighSchool();
                        break;
                    case 5:
                        DeleteHighSchool();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Press any key..."); Console.ReadKey(); Console.Clear();
            } while (operation != closeOperationId);
        }
        private void AddHighSchool()
        {
            High_School high_School = new High_School();
            Console.Write("Name: ");
            high_School.Name = Console.ReadLine();
            Console.Write("City Id: ");
            high_School.CityId = int.Parse(Console.ReadLine());
            Console.Write("Teacher Id: ");
            high_School.TeacherId = int.Parse(Console.ReadLine());
            high_SchoolBusiness.AddHigh_School(high_School);
            Console.WriteLine("The high school has been added!");
        }

        private void DeleteHighSchool()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            High_School high_School = high_SchoolBusiness.GetHigh_School(id);
            if (high_School != null)
            {
                high_SchoolBusiness.DeleteHigh_School(high_School);
                Console.WriteLine("The high school has been deleted!");
            }
            else
            {
                Console.WriteLine("High school not found!");
            }
        }
        private void UpdateHighSchool()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            High_School high_School = high_SchoolBusiness.GetHigh_School(id);
            if (high_School != null)
            {
                Console.WriteLine($"{high_School.Id} {high_School.Name} {high_School.CityId}");
                Console.Write("Name: ");
                high_School.Name = Console.ReadLine();
                Console.Write("City Id: ");
                high_School.CityId = int.Parse(Console.ReadLine());
                Console.Write("Teacher Id: ");
                high_School.TeacherId = int.Parse(Console.ReadLine());
                high_SchoolBusiness.UpdateHigh_School(high_School);
                Console.WriteLine("The high school has been updated!");
            }
            else
            {
                Console.WriteLine("High school not found!");
            }
        }
        private void FetchHighSchool()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            High_School high_School = high_SchoolBusiness.GetHigh_School(id);
            if (high_School != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + high_School.Id);
                Console.WriteLine("Name: " + high_School.Name);
                Console.WriteLine("City: " + high_School.CityId);
                Console.WriteLine("Teacher: " + high_School.TeacherId);
                Console.WriteLine(new string('-', 40));
            }
            else
            {
                Console.WriteLine("High school not found!");
            }

        }

        private void ListAllHighSchools()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "High School");
            Console.WriteLine(new string('-', 40));
            var high_school = high_SchoolBusiness.GetAllHigh_Schools();
            foreach (var item in high_school)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.CityId} {item.TeacherId}");
            }

        }
    }
}
