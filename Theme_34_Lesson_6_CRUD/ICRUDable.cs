using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_34_Lesson_6_CRUD
{
    public interface ICRUDable
    {
        public void Add(Student newStudent);
        public List<Student> Read();
        public List<Student> Find(string searchText, string searchOption);
        /*public void Update();
        public void Delete();*/
    }
}
