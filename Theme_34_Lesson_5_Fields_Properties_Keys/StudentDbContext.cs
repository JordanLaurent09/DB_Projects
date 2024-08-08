using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_34_Lesson_5_Fields_Properties_Keys
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; } = null!;

        public StudentDbContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=192.168.0.13;database=WorkDatabase;user=student-cifra;password=000000", new MySqlServerVersion(new Version(8, 0, 25)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().Property("Id").HasField("_id");
            modelBuilder.Entity<Student>().Property("Age").HasField("_age");
            modelBuilder.Entity<Student>().Property("_name");
            modelBuilder.Entity<Student>().Property("_group");
        }
    }
}
