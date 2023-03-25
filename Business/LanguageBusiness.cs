using ManagementSystemSchool1.Data;
using ManagementSystemSchool1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemSchool1.Business
{
    public class LanguageBusiness
    {
        private ManSysContext manSysContext;

        public List<Language> GetAllLanguage()
        {
            using (manSysContext = new ManSysContext())
            {
                return manSysContext.Languages.ToList();
            }
        }

        public Language GetLanguage(int id)
        {
            using (manSysContext = new ManSysContext())
            {
                return manSysContext.Languages.Find(id);
            }
        }

        public void AddLanguage(Language language)
        {
            using (manSysContext = new ManSysContext())
            {
                manSysContext.Languages.Add(language);
                manSysContext.SaveChanges();
            }
        }

        public void UpdateLanguage(Language language)
        {
            using (manSysContext = new ManSysContext())
            {
                var item = manSysContext.Languages.Find(language.Id);
                if (item != null)
                {
                    manSysContext.Entry(item).CurrentValues.SetValues(language);
                    manSysContext.SaveChanges();
                }
            }
        }

        public void DeleteLanguage(Language language)
        {
            using (manSysContext = new ManSysContext())
            {
                manSysContext.Languages.Remove(language);
                manSysContext.SaveChanges();
            }
        }
    }
}
