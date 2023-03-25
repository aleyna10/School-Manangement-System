using ManagementSystemSchool1.Display;
using System;

namespace ManagementSystemSchool1
{
    public class Program
    {
        private int closeOperationId = 8;
        static void Main(string[] args)
        {
            Program program = new Program();
        }
        public Program()
        {
            Input();
        }
        private static void ShowMenu()
            {
                Console.WriteLine(new string('-', 50));
                Console.WriteLine(new string(' ', 12) + "School managament system");
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("1. Countries operations");
                Console.WriteLine("2. Cities operaions");
                Console.WriteLine("3. Students operations");
                Console.WriteLine("4. Languages operations");
                Console.WriteLine("5. Teachers operations");
                Console.WriteLine("6. Universities operations");
                Console.WriteLine("7. High schools operations");
                Console.WriteLine("8. Exit");
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
                        CountryDisplay();
                        break;
                    case 2:
                        CityDisplay();
                        break;
                    case 3:
                        StudentDisplay();
                        break;
                    case 4:
                        LanguageDisplay();
                        break;
                    case 5:
                        TeacherDisplay();
                        break;
                    case 6:
                        UniversityDisplay();
                        break;
                    case 7:
                        High_SchoolDisplay();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Press any key..."); Console.ReadKey(); Console.Clear();
            } while (operation != closeOperationId);
        }

        private void High_SchoolDisplay()
        {
            High_SchoolDisplay high_SchoolDisplay = new High_SchoolDisplay();
        }

        private void UniversityDisplay()
        {
            UniversityDisplay universityDisplay = new UniversityDisplay();
        }

        private void TeacherDisplay()
        {
            TeacherDisplay teacherDisplay = new TeacherDisplay();
        }

        private void LanguageDisplay()
        {
            LanguageDisplay languageDisplay = new LanguageDisplay();
        }

        private void StudentDisplay()
        {
            StudentDisplay studentDisplay = new StudentDisplay();
        }

        private void CityDisplay()
        {
            CityDisplay cityDisplay = new CityDisplay();
        }

        private void CountryDisplay()
        {
            CountryDisplay countryDisplay = new CountryDisplay();
        }
    }
}

