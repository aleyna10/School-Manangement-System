using ManagementSystemSchool1.Business;
using ManagementSystemSchool1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemSchool1.Display
{
    public class LanguageDisplay
    {
        private int closeOperationId = 6;
        LanguageBusiness languageBusiness = new LanguageBusiness();
        public LanguageDisplay()
        {
            Input();
        }

        private static void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "Language");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all languages");
            Console.WriteLine("2. Add new language");
            Console.WriteLine("3. Update language");
            Console.WriteLine("4. Display language by ID");
            Console.WriteLine("5. Delete language by ID");
            Console.WriteLine("6. Exit language");
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
                        ListAllLanguages();
                        break;
                    case 2:
                        AddLanguage();
                        break;
                    case 3:
                        UpdateLanguage();
                        break;
                    case 4:
                        FetchLanguage();
                        break;
                    case 5:
                        DeleteLanguage();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Press any key..."); Console.ReadKey(); Console.Clear();
            } while (operation != closeOperationId);
        }
        private void AddLanguage()
        {
            Language language = new Language();
            Console.Write("Name: ");
            language.Name = Console.ReadLine();
            Console.Write("Level of competence: ");
            language.Level_Of_Competence = double.Parse(Console.ReadLine());
            languageBusiness.AddLanguage(language);
            Console.WriteLine("The language has been added!");
        }

        private void DeleteLanguage()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Language language = languageBusiness.GetLanguage(id);
            if (language != null)
            {
                languageBusiness.DeleteLanguage(language);
                Console.WriteLine("The language has been deleted!");
            }
            else
            {
                Console.WriteLine("Language not found!");
            }
        }
        private void UpdateLanguage()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Language language = languageBusiness.GetLanguage(id);
            if (language != null)
            {
                Console.WriteLine($"{language.Id} {language.Name} {language.Level_Of_Competence}");
                Console.Write("Name: ");
                language.Name = Console.ReadLine();
                Console.Write("Level of competence: ");
                language.Level_Of_Competence = double.Parse(Console.ReadLine());
                languageBusiness.UpdateLanguage(language);
                Console.WriteLine("The language has been updated!");
            }
            else
            {
                Console.WriteLine("Language not found!");
            }
        }
        private void FetchLanguage()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Language language = languageBusiness.GetLanguage(id);
            if (language != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + language.Id);
                Console.WriteLine("Name: " + language.Name);
                Console.WriteLine("Level of competence: " + language.Level_Of_Competence);
                Console.WriteLine(new string('-', 40));
            }
            else
            {
                Console.WriteLine("Level of competence not found!");
            }

        }

        private void ListAllLanguages()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "Language");
            Console.WriteLine(new string('-', 40));
            var city = languageBusiness.GetAllLanguage();
            foreach (var item in city)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Level_Of_Competence}");
            }

        }
    }
}
