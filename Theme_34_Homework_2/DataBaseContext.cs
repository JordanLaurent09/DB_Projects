using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theme_34_Homework_2.Entities;


namespace Theme_34_Homework_2
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;

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
