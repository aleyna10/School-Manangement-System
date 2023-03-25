using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemSchool1.Data.Models
{
    public class Student
    {
        [Key]

        public int Id { get; set; }

        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        [ForeignKey("High_SchoolId")]

        public int? High_SchoolId { get; set; }
        public High_School High_School { get; set; }

        [ForeignKey("UniversityId")]

        public int? UniversityId { get; set; }
        public University University { get; set; }

        [ForeignKey("LanguageId")]

        public int? LanguageId { get; set; }
        public Language Language { get; set; }

        public Student()
        {
        }

        public Student(int id, string first_Name, string last_Name, int high_SchoolId, int universityId, int languageId)
        {
            this.Id = id;
            this.First_Name = first_Name;
            this.Last_Name = last_Name;
            this.UniversityId = universityId;
            this.LanguageId = languageId;
            this.High_SchoolId = high_SchoolId;
        }
    }
}
