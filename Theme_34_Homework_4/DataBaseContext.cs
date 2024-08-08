using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_34_Homework_4
{
    public class DataBaseContext : DbContext
    {
        private StreamWriter LogDebugWriter = new StreamWriter("LoggingDebug.log", true);
        private StreamWriter LogErrorWriter = new StreamWriter("LoggingErrors.log", true);
        public DbSet<Product> Products { get; set; } = null!;
        public DataBaseContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("internetShopConfig.json");

            var config = builder.Build();

            var connectionString = config.GetConnectionString("DefaultConnection");


            var version = new MySqlServerVersion(new Version(8, 0, 25));

            optionsBuilder.UseMySql(connectionString, version);

            optionsBuilder.LogTo(LogDebugWriter.WriteLine, Microsoft.Extensions.Logging.LogLevel.Debug);
            optionsBuilder.LogTo(LogErrorWriter.WriteLine, Microsoft.Extensions.Logging.LogLevel.Error);

        }

        public override void Dispose()
        {
            base.Dispose();
            LogDebugWriter.Dispose();
            LogErrorWriter.Dispose();
        }
    }
}
