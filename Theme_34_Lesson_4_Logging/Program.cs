namespace Theme_34_Lesson_4_Logging
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                List<User> users = new List<User>()
                {
                    new User("Валерий", "Valery@mail.ru", "000000"),
                    new User("Елена", "Elena@gmail.com", "123456"),
                    new User("Иван", "Ivan@example.com", "qwerty"),
                    new User("Анна", "Anna@mail.ru", "password123")
                };

                db.Users.AddRange(users);
                db.SaveChanges();
            }
            Console.WriteLine("Успешно");

        }
    }
}
