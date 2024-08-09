using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_34_Lesson_6_CRUD
{
    public class Operator : ICRUDable
    {
        /// <summary>
        /// Adding new student to DB
        /// </summary>
        /// <param name="newStudent"></param>
        public void Add(Student newStudent)
        {
            using (SchoolDbContext schoolContext = new SchoolDbContext())
            {
                schoolContext.Students.Add(newStudent);
                schoolContext.SaveChanges();
            }
        }

        /// <summary>
        /// Reading all info about students from database
        /// </summary>
        /// <returns></returns>
        public List<Student> Read()
        {
            List<Student> allStudents = new List<Student>();

            using (SchoolDbContext schoolDbContext = new SchoolDbContext())
            {
                allStudents = schoolDbContext.Students.ToList();
            }

            return allStudents;
        }
    }
}
