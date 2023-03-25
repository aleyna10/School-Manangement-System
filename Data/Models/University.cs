using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemSchool1.Data.Models
{
    public class University
    {
        [Key]

        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("CityId")]

        public int? CityId { get; set; }
        public City City { get; set; }

        [ForeignKey("TeacherId")]

        public int? TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public University()
        {
        }

        public University(int id, string name, int cityId, int teacherId)
        {
            this.Id = id;
            this.Name = name;
            this.CityId = cityId;
            this.TeacherId = teacherId;
        }
    }
}
