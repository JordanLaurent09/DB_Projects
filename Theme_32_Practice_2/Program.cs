namespace Theme_32_Practice_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Iris> irises = CSVSupport.ReadCSV();

            using (ApplicationContext context = new ApplicationContext())
            {
                context.Irises.AddRange(irises);

                context.SaveChanges();
            }
        }
    }
}
