using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemSchool1.Data.Models
{
    public class Teacher
    {
        [Key]

        public int Id { get; set; }

        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public Teacher()
        {
        }

        public Teacher(int id, string first_Name, string last_Name)
        {
            this.Id = id;
            this.First_Name = first_Name;
            this.Last_Name = last_Name;
        }
    }
}
