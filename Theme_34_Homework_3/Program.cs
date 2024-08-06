using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Theme_34_Homework_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory());

            builder.AddJsonFile("workDatabaseConfig.json");

            var config = builder.Build();

            var connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();

            var version = new MySqlServerVersion(new Version(8, 0, 25));

            var options = optionsBuilder.UseMySql(connectionString, version).Options;

            using (DataContext context = new DataContext(options))
            {
                List<User> users = new List<User>()
                {
                    new ("Peter", "peterpeter@email"),
                    new ("Susie", "ohsusie@email"),
                    new ("Fred", "freddiefred@email"),
                    new ("Bella", "bellabellaisabella@email")
                };

                context.Users.AddRange(users);
                context.SaveChanges();
            }
        }
    }
}
