using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_34_Lesson_6_CRUD
{
    public interface ICRUDable
    {
        Task Add(Student newStudent);
        Task<List<Student>> Read();
        Task<List<Student>> Find(string searchText, string searchOption);
        Task Update(Student student);
        Task Delete(Student student);
    }
}
