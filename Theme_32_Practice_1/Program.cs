namespace Theme_32_Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ApplicationContext())
            {
                var movies = context.Movies.ToList();

                foreach (var item in movies)
                {
                    Console.WriteLine($"{item.Name} {item.Year} {item.Director} {item.Genre} {item.Graduation}");
                }
            }
        }
    }
}
