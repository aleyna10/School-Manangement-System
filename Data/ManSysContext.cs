using ManagementSystemSchool1.Data.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemSchool1.Data
{
    public class ManSysContext:DbContext
    {
        public ManSysContext()
        {

        }
        public ManSysContext(DbContextOptions options) : base(options)
        {

        }
        public virtual DbSet<City> Cities { get; set; }

        public virtual DbSet<Country> Countries { get; set; }

        public virtual DbSet<High_School> High_Schools { get; set; }

        public virtual DbSet<Language> Languages { get; set; }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Teacher> Teachers { get; set; }

        public virtual DbSet<University> Universities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-Q1F7M77\SQLEXPRESS03;Database=SchoolDb; Integrated Security = True");
        }

    }
    
}
