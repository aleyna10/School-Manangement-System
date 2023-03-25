using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemSchool1.Data.Models
{
    public class City
    {
        [Key]

        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("CountryId")]

        public int? CountryId { get; set; }

        public Country Country { get; set; }

        public City()
        {

        }

        public City(int id, string name, int countryId)
        {
            this.Id = id;
            this.Name = name;
            this.CountryId = countryId;
        }
    }
}
