using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;

namespace Theme_32_Practice_2
{
    public static class CSVSupport
    {
        /// <summary>
        /// method that reading data from CSV-file and return it like List
        /// </summary>
        /// <returns></returns>
        public static List<Iris> ReadCSV()
        {
            List<Iris> irises = new List<Iris>();

            using(StreamReader reader = new StreamReader("iris.csv"))
            {
                CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture);
                CsvReader csvReader = new CsvReader(reader, config);

                irises = csvReader.GetRecords<Iris>().ToList();
            }

            //StreamReader reader = new StreamReader("iris.csv");

            //CsvConfiguration csvConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture);

            //CsvReader csvReader = new CsvReader(reader, csvConfiguration);

            //irises = csvReader.GetRecords<Iris>().ToList();

            //reader.Close();

            return irises;
        }
    }
}
