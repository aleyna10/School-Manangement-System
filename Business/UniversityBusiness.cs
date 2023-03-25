using ManagementSystemSchool1.Data;
using ManagementSystemSchool1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemSchool1.Business
{
    public class UniversityBusiness
    {
        private ManSysContext manSysContext;

        public List<University> GetAllUniversities()
        {
            using (manSysContext = new ManSysContext())
            {
                return manSysContext.Universities.ToList();
            }
        }

        public University GetUniversity(int id)
        {
            using (manSysContext = new ManSysContext())
            {
                return manSysContext.Universities.Find(id);
            }
        }

        public void AddUniversity(University university)
        {
            using (manSysContext = new ManSysContext())
            {
                manSysContext.Universities.Add(university);
                manSysContext.SaveChanges();
            }
        }

        public void UpdateUniversity(University university)
        {
            using (manSysContext = new ManSysContext())
            {
                var item = manSysContext.Universities.Find(university.Id);
                if (item != null)
                {
                    manSysContext.Entry(item).CurrentValues.SetValues(university);
                    manSysContext.SaveChanges();
                }
            }
        }

        public void DeleteUniversity(University university)
        {
            using (manSysContext = new ManSysContext())
            {
                manSysContext.Universities.Remove(university);
                manSysContext.SaveChanges();
            }
        }
    }
}
