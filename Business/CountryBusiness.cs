using ManagementSystemSchool1.Data;
using ManagementSystemSchool1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemSchool1.Business
{
    public class CountryBusiness
    {
        private ManSysContext manSysContext;

        public List<Country> GetAllCountries()
        {
            using (manSysContext = new ManSysContext())
            {
                return manSysContext.Countries.ToList();
            }
        }

        public Country GetCountry(int id)
        {
            using (manSysContext = new ManSysContext())
            {
                return manSysContext.Countries.Find(id);
            }
        }

        public void AddCountry(Country country)
        {
            using (manSysContext = new ManSysContext())
            {
                manSysContext.Countries.Add(country);
                manSysContext.SaveChanges();
            }
        }

        public void UpdateCountry(Country country)
        {
            using (manSysContext = new ManSysContext())
            {
                var item = manSysContext.Countries.Find(country.Id);
                if (item != null)
                {
                    manSysContext.Entry(item).CurrentValues.SetValues(country);
                    manSysContext.SaveChanges();
                }
            }
        }

        public void DeleteCountry(Country country)
        {
            using (manSysContext = new ManSysContext())
            {
                manSysContext.Countries.Remove(country);
                manSysContext.SaveChanges();
            }
        }
    }
}
