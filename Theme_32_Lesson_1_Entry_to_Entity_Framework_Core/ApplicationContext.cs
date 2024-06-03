using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_32_Lesson_1_Entry_to_Entity_Framework_Core
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Student> Students => Set<Student>();

        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=StudentsApp.db");
        }

    }
}
