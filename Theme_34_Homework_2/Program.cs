using Theme_34_Homework_2.Entities;

namespace Theme_34_Homework_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Создаю 2 объекта категории:
            Category food = new Category("Еда", "Еда - это продовольствие, питает живых существ и помогает им жить дальше");
            Category tools = new Category("Инструменты", "Инструменты - это орудия труда, позволяют изменять окружающую среду");


            // Первый список товаров
            List<Product> foodProducts = new List<Product>()
            {
                new Product("Блинчик", "Вкусная еда из теста, сыра и ветчины", 23.75, food),
                new Product("Шоколад", "Вкусная плитка из плодов какао", 230.50, food),
                new Product("Кофе", "Вкусный напиток из кофейных зерен", 250.25, food),
                new Product("Рис", "Вкусный зерновой продукт, произрастает в Китае и Вьетнаме", 60.00, food),
                new Product("Киродиильский бренди", "Вкусный горячительный напиток для неги", 1500.00, food),
            };

            // Второй список товаров
            List<Product> toolsProduct = new List<Product>()
            {
                new Product("Топор", "Острый режуще-колющий инструмент, позволяет рубить дрова и головы", 450.70, tools),
                new Product("Отвертка", "Инструмент, предназначенный для закручивания шурупов", 250.50, tools)
            };

            // Создание 2-х пользователей с пустым списком заказов
            User firstCustomer = new User("Сергей", "sergey@inbox.ru", "я_супер_программист", new List<Order>());
            User secondCustomer = new User("Лера", "lera@inbox.ru", "я_супер_лера", new List<Order>());

            // Создание 2-х объектов Заказа
            Order myOrder = new Order(DateTime.Now, "ВЫПОЛНЕН", firstCustomer, foodProducts);
            Order herOrder = new Order(DateTime.Now, "ВЫПОЛНЕН", secondCustomer, toolsProduct);

            // Добавление заказов пользователям в пустые списки
            firstCustomer.Orders.Add(myOrder);
            secondCustomer.Orders.Add(herOrder);

            using(DataBaseContext dbContext = new DataBaseContext())
            {
                dbContext.Products.AddRange(foodProducts);
                dbContext.Products.AddRange(toolsProduct);

                dbContext.Categories.Add(food);
                dbContext.Categories.Add(tools);

                dbContext.Users.Add(firstCustomer);
                dbContext.Users.Add(secondCustomer);

                dbContext.Orders.Add(herOrder);
                dbContext.Orders.Add(myOrder);

                dbContext.SaveChanges();
            }

        }
    }
}
