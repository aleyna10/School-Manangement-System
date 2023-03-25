using ManagementSystemSchool1.Business;
using ManagementSystemSchool1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemSchool1.Display
{
    public class CityDisplay
    {
        private int closeOperationId = 6;
        CityBusiness cityBusiness = new CityBusiness();
        public CityDisplay()
        {
            Input();
        }

        private static void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "City");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all cities");
            Console.WriteLine("2. Add new city");
            Console.WriteLine("3. Update city");
            Console.WriteLine("4. Display city by ID");
            Console.WriteLine("5. Delete city by ID");
            Console.WriteLine("6. Exit city");
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
                        ListAllCities();
                        break;
                    case 2:
                        AddCity();
                        break;
                    case 3:
                        UpdateCity();
                        break;
                    case 4:
                        FetchCity();
                        break;
                    case 5:
                        DeleteCity();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Press any key..."); Console.ReadKey(); Console.Clear();
            } while (operation != closeOperationId);
        }
        private void AddCity()
        {
            City city = new City();
            Console.Write("Name: ");
            city.Name = Console.ReadLine();
            Console.Write("Country Id: ");
            city.CountryId = int.Parse(Console.ReadLine());
            cityBusiness.AddCity(city);
            Console.WriteLine("The city has been added!");
        }

        private void DeleteCity()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            City city = cityBusiness.GetCity(id);
            if (city != null)
            {
                cityBusiness.DeleteCity(city);
                Console.WriteLine("The city has been deleted!");
            }
            else
            {
                Console.WriteLine("City not found!");
            }
        }
        private void UpdateCity()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            City city = cityBusiness.GetCity(id);
            if (city != null)
            {
                Console.WriteLine($"{city.Id} {city.Name} {city.CountryId}");
                Console.Write("Name: ");
                city.Name = Console.ReadLine();
                Console.Write("CountryId: ");
                city.CountryId = int.Parse(Console.ReadLine());
                cityBusiness.UpdateCity(city);
                Console.WriteLine("The city has been updated!");
            }
            else
            {
                Console.WriteLine("City not found!");
            }
        }
        private void FetchCity()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            City city = cityBusiness.GetCity(id);
            if (city != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + city.Id);
                Console.WriteLine("Name: " + city.Name);
                Console.WriteLine("Country: " + city.CountryId);
                Console.WriteLine(new string('-', 40));
            }
            else
            {
                Console.WriteLine("City not found!");
            }

        }

        private void ListAllCities()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "City");
            Console.WriteLine(new string('-', 40));
            var city = cityBusiness.GetAllCities();
            foreach (var item in city)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.CountryId}");
            }

        }
    }
}
