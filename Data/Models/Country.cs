using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemSchool1.Data.Models
{
    public class Country
    {
        
            [Key]

            public int Id { get; set; }

            public string Name { get; set; }

            public Country()
            {
            }


            public Country(int id, string name)
            {
                this.Id = id;
                this.Name = name;
            }
        
    }
}
