using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_34_Lesson_4_Logging
{
    public class DataBaseContext : DbContext
    {
        private StreamWriter _logWriter = new StreamWriter("loggingFile.log", true);
        public DbSet<User> Users { get; set; } = null!;

        public override void Dispose()
        {
            base.Dispose();
            _logWriter.Dispose();

        }

        public DataBaseContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=192.168.0.13;database=WorkDatabase;user=student-cifra;password=000000", new MySqlServerVersion(new Version(8, 0, 25)));
            optionsBuilder.LogTo(_logWriter.WriteLine, LogLevel.Debug);
        }
    }
}
