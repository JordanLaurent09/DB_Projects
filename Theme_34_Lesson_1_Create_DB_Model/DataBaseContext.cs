using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_34_Lesson_1_Create_DB_Model
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;

        public DataBaseContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=192.168.0.13;user=student-cifra;password=000000;database=WorkDatabase", new MySqlServerVersion(new Version(8, 0, 25)));
        }
    }
}
