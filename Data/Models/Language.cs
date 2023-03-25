using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemSchool1.Data.Models
{
    public class Language
    {
        [Key]

        public int Id { get; set; }

        public string Name { get; set; }

        public double Level_Of_Competence { get; set; }

        public Language()
        {
        }

        public Language(int id, string name, double level_Of_Competence)
        {
            this.Id = id;
            this.Name = name;
            this.Level_Of_Competence = level_Of_Competence;
        }
    }
}
