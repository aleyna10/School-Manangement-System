using ManagementSystemSchool1.Data;
using ManagementSystemSchool1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemSchool1.Business
{
    public class StudentBusiness
    {
        private ManSysContext manSysContext;

        public List<Student> GetAllStudents()
        {
            using (manSysContext = new ManSysContext())
            {
                return manSysContext.Students.ToList();
            }
        }

        public Student GetStudents(int id)
        {
            using (manSysContext = new ManSysContext())
            {
                return manSysContext.Students.Find(id);
            }
        }

        public void AddStudent(Student student)
        {
            using (manSysContext = new ManSysContext())
            {
                manSysContext.Students.Add(student);
                manSysContext.SaveChanges();
            }
        }

        public void UpdateStudents(Student student)
        {
            using (manSysContext = new ManSysContext())
            {
                var item = manSysContext.Students.Find(student.Id);
                if (item != null)
                {
                    manSysContext.Entry(item).CurrentValues.SetValues(student);
                    manSysContext.SaveChanges();
                }
            }
        }

        public void DeleteStudent(Student student)
        {
            using (manSysContext = new ManSysContext())
            {
                manSysContext.Students.Remove(student);
                manSysContext.SaveChanges();
            }
        }
    }
}
