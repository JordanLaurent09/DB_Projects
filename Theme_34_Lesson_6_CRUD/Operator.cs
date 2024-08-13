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
        public async Task Add(Student newStudent)
        {
            using (SchoolDbContext schoolContext = new SchoolDbContext())
            {
                await schoolContext.Students.AddAsync(newStudent);
                await schoolContext.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Reading all info about students from database
        /// </summary>
        /// <returns></returns>
        public async Task<List<Student>> Read()
        {
            //List<Student> allStudents = new List<Student>();

            using (SchoolDbContext schoolDbContext = new SchoolDbContext())
            {
                return await Task.Run(() => schoolDbContext.Students.ToList());
                //allStudents = schoolDbContext.Students.ToList();
            }

            //return allStudents;
        }

        /// <summary>
        /// Seeks all data in database based on search values
        /// </summary>
        /// <param name="searchText"></param>
        /// <param name="searchOption"></param>
        /// <returns></returns>
        public async Task<List<Student>> Find(string searchText, string searchOption)
        {
            //List<Student> foundStudents = new List<Student>();

            using (SchoolDbContext schoolContext = new SchoolDbContext())
            {
                switch (searchOption) 
                {
                    case "name":
                        return await Task.Run(() => schoolContext.Students.Where(user => user.FirstName == searchText).ToList());
                        //foundStudents = schoolContext.Students.Where(user => user.FirstName == searchText).ToList();
                        //break;
                    case "surname":
                        return await Task.Run(() => schoolContext.Students.Where(user => user.LastName == searchText).ToList());
                    //foundStudents = schoolContext.Students.Where(user => user.LastName == searchText).ToList();
                    //break;
                    default:
                        return null!;
                }
            }
            //return foundStudents;
        }

        /// <summary>
        /// Method for update student info
        /// </summary>
        /// <param name="student"></param>
        public async Task Update(Student student)
        {
            using (SchoolDbContext schoolContext = new SchoolDbContext())
            {
                if (student != null)
                {
                    schoolContext.Students.Update(student);
                    await schoolContext.SaveChangesAsync();
                }
                else
                {
                    MessageBox.Show("Попытка обновить данные пустой ссылкой");
                }
            }
        }


        /// <summary>
        /// Method allowing to remove students from database
        /// </summary>
        /// <param name="student"></param>
        public async Task Delete(Student student)
        {
            using (SchoolDbContext schoolContext = new SchoolDbContext())
            {
                if (student != null)
                {
                    schoolContext.Students.Remove(student);
                    await schoolContext.SaveChangesAsync();
                }
                else
                {
                    MessageBox.Show("Попытка удалить несуществующего студента.");
                }
            }
        }
    }
}
