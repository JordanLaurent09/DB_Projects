using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_34_Lesson_6_CRUD
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; } = null!;

        public SchoolDbContext() 
        {          
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var version = new MySqlServerVersion(new Version(8, 0, 25));
            optionsBuilder.UseMySql("server=192.168.0.13;database=WorkDatabase;user=student-cifra;password=000000", version);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().Property("Id");
            modelBuilder.Entity<Student>().Property("FirstName");
            modelBuilder.Entity<Student>().Property("LastName").IsRequired();
            modelBuilder.Entity<Student>().Property("Age");

        }
    }
}
