using ManagementSystemSchool1.Business;
using ManagementSystemSchool1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemSchool1.Display
{
    public class CountryDisplay
    {
        private int closeOperationId = 6;
        CountryBusiness countryBusiness = new CountryBusiness();
        public CountryDisplay()
        {
            Input();
        }

        private static void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "Country");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all countries");
            Console.WriteLine("2. Add new country");
            Console.WriteLine("3. Update country");
            Console.WriteLine("4. Display country by ID");
            Console.WriteLine("5. Delete country by ID");
            Console.WriteLine("6. Exit country");
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
                        ListAllCountries();
                        break;
                    case 2:
                        AddCountry();
                        break;
                    case 3:
                        UpdateCountry();
                        break;
                    case 4:
                        FetchCountry();
                        break;
                    case 5:
                        DeleteCountry();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Press any key..."); Console.ReadKey(); Console.Clear();
            } while (operation != closeOperationId);
        }
        private void AddCountry()
        {
            Country country = new Country();
            Console.Write("Name: ");
            country.Name = Console.ReadLine();
            countryBusiness.AddCountry(country);
            Console.WriteLine("The country has been added!");
        }

        private void DeleteCountry()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Country country = countryBusiness.GetCountry(id);
            if (country != null)
            {
                countryBusiness.DeleteCountry(country);
                Console.WriteLine("The country has been deleted!");
            }
            else
            {
                Console.WriteLine("Country not found!");
            }
        }
        private void UpdateCountry()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Country country = countryBusiness.GetCountry(id);
            if (country != null)
            {
                Console.WriteLine($"{country.Id} {country.Name}");
                Console.Write("Name: ");
                country.Name = Console.ReadLine();
                countryBusiness.UpdateCountry(country);
                Console.WriteLine("The country has been updated!");
            }
            else
            {
                Console.WriteLine("Country not found!");
            }
        }
        private void FetchCountry()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Country country = countryBusiness.GetCountry(id);
            if (country != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + country.Id);
                Console.WriteLine("Name: " + country.Name);
                Console.WriteLine(new string('-', 40));
            }
            else
            {
                Console.WriteLine("Country not found!");
            }

        }

        private void ListAllCountries()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "Country");
            Console.WriteLine(new string('-', 40));
            var city = countryBusiness.GetAllCountries();
            foreach (var item in city)
            {
                Console.WriteLine($"{item.Id} {item.Name}");
            }

        }
    }
}
