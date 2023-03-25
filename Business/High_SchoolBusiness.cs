using ManagementSystemSchool1.Data;
using ManagementSystemSchool1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemSchool1.Business
{
    public class High_SchoolBusiness
    {
        private ManSysContext manSysContext;

        public List<High_School> GetAllHigh_Schools()
        {
            using (manSysContext = new ManSysContext())
            {
                return manSysContext.High_Schools.ToList();
            }
        }

        public High_School GetHigh_School(int id)
        {
            using (manSysContext = new ManSysContext())
            {
                return manSysContext.High_Schools.Find(id);
            }
        }

        public void AddHigh_School(High_School high_School)
        {
            using (manSysContext = new ManSysContext())
            {
                manSysContext.High_Schools.Add(high_School);
                manSysContext.SaveChanges();
            }
        }

        public void UpdateHigh_School(High_School high_School)
        {
            using (manSysContext = new ManSysContext())
            {
                var item = manSysContext.High_Schools.Find(high_School.Id);
                if (item != null)
                {
                    manSysContext.Entry(item).CurrentValues.SetValues(high_School);
                    manSysContext.SaveChanges();
                }
            }
        }

        public void DeleteHigh_School(High_School high_School)
        {
            using (manSysContext = new ManSysContext())
            {
                manSysContext.High_Schools.Remove(high_School);
                manSysContext.SaveChanges();
            }
        }
    }
}
