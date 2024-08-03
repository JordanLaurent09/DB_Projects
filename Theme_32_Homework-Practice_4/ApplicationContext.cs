using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_32_Homework_Practice_4
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Passenger> Passengers => Set<Passenger>();
        
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=TitanicPassengers.db");
        }
    }
}
