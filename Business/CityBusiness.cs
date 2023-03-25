using ManagementSystemSchool1.Data;
using ManagementSystemSchool1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemSchool1.Business
{
    public class CityBusiness
    {
        private ManSysContext manSysContext;

        public List<City> GetAllCities()
        {
            using (manSysContext = new ManSysContext())
            {
                return manSysContext.Cities.ToList();
            }
        }

        public City GetCity(int id)
        {
            using (manSysContext = new ManSysContext())
            {
                return manSysContext.Cities.Find(id);
            }
        }

        public void AddCity(City city)
        {
            using (manSysContext = new ManSysContext())
            {
                manSysContext.Cities.Add(city);
                manSysContext.SaveChanges();
            }
        }

        public void UpdateCity(City city)
        {
            using (manSysContext = new ManSysContext())
            {
                var item = manSysContext.Cities.Find(city.Id);
                if (item != null)
                {
                    manSysContext.Entry(item).CurrentValues.SetValues(city);
                    manSysContext.SaveChanges();
                }
            }
        }

        public void DeleteCity(City city)
        {
            using (manSysContext = new ManSysContext())
            {
                manSysContext.Cities.Remove(city);
                manSysContext.SaveChanges();
            }
        }
    }
}
