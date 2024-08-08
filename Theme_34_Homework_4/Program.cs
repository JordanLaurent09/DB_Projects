using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Theme_34_Homework_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (DataBaseContext context = new DataBaseContext())
            {

                List<Product> products = new List<Product>()
            {
                new ("Стикер", "Цветная наклейка", 50.00, 50000),
                new ("Кофе", "Коричневая жидкость из кофейных зерен", 500.50, 200),
                new ("Бренди", "Напиток прямиком из Киродиила", 5000.00, 10),
                new ("Лунный сахар", "Наркотическое лакомство разумных котов", 456.22, 1000)
            };

                context.Products.AddRange(products);
                context.SaveChanges();
            }

            Console.WriteLine("Wonderful, wondeful!");
        }
    }
}
