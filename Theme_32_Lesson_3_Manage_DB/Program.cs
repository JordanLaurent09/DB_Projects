namespace Theme_32_Lesson_3_Manage_DB
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (TitanicPassengersContext titanicPassengers = new TitanicPassengersContext())
            {
                var passengers = titanicPassengers.Passengers.ToList();

                foreach (var item in passengers)
                {
                    Console.WriteLine($"Имя пассажира - {item.Name}, а пол пассажира - {item.Sex}");
                }
            }
        }
    }
}
