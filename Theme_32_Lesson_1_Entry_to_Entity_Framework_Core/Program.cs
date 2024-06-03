namespace Theme_32_Lesson_1_Entry_to_Entity_Framework_Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ApplicationContext())
            {
                // Запись данных в БД типа sqlite

                //var student_one = new Student() { Name = "Tommy", Surname = "Stephenson", Age = 22 };
                //var student_two = new Student() { Name = "Johnny", Surname = "Andrews", Age = 21 };
                //var student_three = new Student() { Name = "Bellatrix", Surname = "Peterson", Age = 24 };

                //context.Students.Add(student_one);
                //context.Students.Add(student_two);
                //context.Students.Add(student_three);

                //context.SaveChanges();

                //Console.WriteLine("Данные записаны");

                // Чтение данных из БД типа sqlite

                var students = context.Students.ToList();

                foreach(var item in students)
                {
                    Console.WriteLine($" Имя студента - {item.Name}, фамилия студента - {item.Surname}, возраст студента - {item.Age}");
                }
            }
        }
    }
}
