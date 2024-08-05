using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_34_Lesson_3_Connection_String_Configuration
{
    public class Product
    {
        public int Id { get; set; }

        [Column(TypeName = "Varchar(40)")]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
        public Category? ProductCategory { get; set; }


        public Product() { }

        public Product(string? name, string? description, double? price, Category? productCategory)
        {
            Name = name;
            Description = description;
            Price = price;
            ProductCategory = productCategory;
        }
    }
}
