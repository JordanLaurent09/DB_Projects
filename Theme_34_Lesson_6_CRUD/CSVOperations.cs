using CsvHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Theme_34_Lesson_6_CRUD
{
    public static class CSVOperations
    {
        /// <summary>
        /// Метод, записывающий список с данными в файл формата .csv
        /// </summary>
        /// <param name="students"></param>
        public static void CreateFile(List<Student> students)
        {
            DateTime recordData = DateTime.Now;
            

            string fileName = $"Резервная копия БД от {recordData.Day}-{recordData.Month}-{recordData.Year}-{recordData.Hour}-{recordData.Minute}-{recordData.Second}.csv";

            using (StreamWriter streamWriter = new StreamWriter(fileName)) 
            {
                CsvWriter csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

                csvWriter.WriteRecords<Student>(students);
            }
        }
    }
}
