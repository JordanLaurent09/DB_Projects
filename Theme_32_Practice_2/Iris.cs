using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_32_Practice_2
{
    public class Iris
    {
        [Ignore]
        public int Id { get; set; }

        [Name("sepal.length")]
        public double SepalLength { get; set; }

        [Name("sepal.width")]
        public double SepalWidth { get; set; }

        [Name("petal.length")]
        public double PetalLength { get; set; }

        [Name("petal.width")]
        public double PetalWidth { get; set; }

        [Name("variety")]
        public string? Variety { get; set; }
    }
}
