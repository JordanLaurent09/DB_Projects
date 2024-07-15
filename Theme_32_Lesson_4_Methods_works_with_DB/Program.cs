using Microsoft.EntityFrameworkCore;

namespace Theme_32_Lesson_4_Methods_works_with_DB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Добавление массива студентов в БД

            //using (ApplicationContext context = new ApplicationContext())
            //{
            //    Person[] students =
            //    {
            //        new Person() {Id = 1, Name = "Edward", Age=21},
            //        new Person() {Id = 2, Name = "Bella", Age=31},
            //        new Person() {Id = 3, Name = "Ronnie", Age=11},
            //        new Person() {Id = 4, Name = "Sara", Age=24}
            //    };


            // a. Добавление данных из массива в БД перебором массива поэлементно

            //foreach (var item in students)
            //{
            //    context.People.Add(item);
            //}

            // b. Добавление данных из массива в БД одним махом при помощи AddRange() - только для коллекций, реализующих интерфейс IEnumerable

            //context.People.AddRange(students);

            // c. Также, имеется возможность добавлять данные в БД через AddRange, используя params

            //context.AddRange(students[0], students[1], students[2], students[3]);


            //context.SaveChanges();
            //}


            // 2. Получение данных из БД

            //using (ApplicationContext context = new ApplicationContext())
            //{
            //    List<Person> students = context.People.ToList();

            //    foreach(var item in students)
            //    {
            //        Console.WriteLine(item.Name);
            //    }
            //}

            // 3. Удаление данных из БД

            //using (ApplicationContext context = new ApplicationContext())
            //{
            //    Person currentStudent = context.People.FirstOrDefault()!;

            //    if (currentStudent != null)
            //    {
            //        context.People.Remove(currentStudent);
            //        context.SaveChanges();
            //    }

            //}


            // 4. Изменение БД

            //using (ApplicationContext context = new ApplicationContext())
            //{
            //    Person student = context.People.FirstOrDefault()!;

            //    if (student != null)
            //    {
            //        student.Age = 27;
            //        student.Name = "Bellatrix";

            //        context.People.Update(student);

            //        context.SaveChanges();
            //    }
            //}


            // 5. Использование асинхронных методов

            using (ApplicationContext context = new ApplicationContext())
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(100);

                    if (i == 5)
                    {
                        Task.Run(async () =>
                        {
                            int adultCount;

                            adultCount = await context.People.CountAsync(person => person.Age > 20);
                            Console.WriteLine($"Взрослых студентов - {adultCount}.");
                        });
                    }
                }
            }

        }
    }
}
