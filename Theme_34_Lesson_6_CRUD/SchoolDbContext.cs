using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Theme_34_Lesson_6_CRUD
{
    public class SchoolDbContext : DbContext
    {
        private StreamWriter _logWriter = new StreamWriter("loggerFile.log", true);
        private StreamWriter _errWriter = new StreamWriter("errorFile.log", true);

        public DbSet<Student> Students { get; set; } = null!;
        
        public SchoolDbContext() 
        {          
            Database.EnsureCreated();
        }

        public override void Dispose()
        {
            base.Dispose();
            _errWriter.Dispose();
            _logWriter.Dispose();
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var version = new MySqlServerVersion(new Version(8, 0, 25));
            optionsBuilder.UseMySql("server=192.168.0.14;database=WorkDatabase;user=student-cifra;password=000000", version);
            optionsBuilder.LogTo(_errWriter.WriteLine, LogLevel.Error);
            optionsBuilder.LogTo(_logWriter.WriteLine, LogLevel.Information);
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
