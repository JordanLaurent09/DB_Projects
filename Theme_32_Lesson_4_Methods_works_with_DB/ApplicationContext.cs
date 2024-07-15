using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_32_Lesson_4_Methods_works_with_DB
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Person> People => Set<Person>();

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=StudentsApp.db");
        }
    }
}
