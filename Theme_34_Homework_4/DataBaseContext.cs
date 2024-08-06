using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_34_Homework_4
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; } = null!;
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) 
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}
