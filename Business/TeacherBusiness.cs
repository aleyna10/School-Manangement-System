using ManagementSystemSchool1.Data;
using ManagementSystemSchool1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemSchool1.Business
{
    public class TeacherBusiness
    {
        private ManSysContext manSysContext;

        public List<Teacher> GetAllTeachers()
        {
            using (manSysContext = new ManSysContext())
            {
                return manSysContext.Teachers.ToList();
            }
        }

        public Teacher GetTeacher(int id)
        {
            using (manSysContext = new ManSysContext())
            {
                return manSysContext.Teachers.Find(id);
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            using (manSysContext = new ManSysContext())
            {
                manSysContext.Teachers.Add(teacher);
                manSysContext.SaveChanges();
            }
        }

        public void UpdateTeacher(Teacher teacher)
        {
            using (manSysContext = new ManSysContext())
            {
                var item = manSysContext.Teachers.Find(teacher.Id);
                if (item != null)
                {
                    manSysContext.Entry(item).CurrentValues.SetValues(teacher);
                    manSysContext.SaveChanges();
                }
            }
        }

        public void DeleteTeacher(Teacher teacher)
        {
            using (manSysContext = new ManSysContext())
            {
                manSysContext.Teachers.Remove(teacher);
                manSysContext.SaveChanges();
            }
        }
    }
}
