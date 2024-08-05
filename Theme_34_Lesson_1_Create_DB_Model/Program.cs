namespace Theme_34_Lesson_1_Create_DB_Model
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>()
            {
                new ("Bella", "isabella96@mail.ru", 28, "Tommy str. suite 16", new TelephoneNumber("384756348")),
                new ("Tommy", "tommy99@mail.ru", 25, "Bella str. suite 20", new TelephoneNumber("4565467")),
                new ("Andrew", "dronnie_dron@mail.ru", 38, "Dorry str. suite 22", new TelephoneNumber("78273982739")),
                new ("Peter", "pete_pete@mail.ru", 20, "Sammy str. suite 27", new TelephoneNumber("98327328367"))
            };

            using (DataBaseContext db = new DataBaseContext())
            {
                db.AddRange(users);
                db.SaveChanges();
            }
        }
    }
}
