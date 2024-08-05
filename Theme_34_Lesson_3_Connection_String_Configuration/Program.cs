using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Theme_34_Lesson_3_Connection_String_Configuration
{
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory());

            builder.AddJsonFile("myDataBaseConfigurations.json");

            var config = builder.Build();

            var connectionString = config.GetConnectionString("DefaultConnection");


            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            var version = new MySqlServerVersion(new Version(8, 0, 25));
            var options = optionsBuilder.UseMySql(connectionString, version).Options;

            using (DataContext dataContext = new DataContext(options))
            {
                List<Category> categories = dataContext.Categories.ToList();

                foreach (var category in categories)
                {
                    Console.WriteLine(category.Name);
                }
            }

            Console.WriteLine("Подключение прошло успешно");

        }
    }
}
