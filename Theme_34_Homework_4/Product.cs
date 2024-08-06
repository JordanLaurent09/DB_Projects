using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_34_Homework_4
{
    public class Product
    {
        [Key]
        [Column("Product_Id")]
        public int Id { get; set; }
        [Column(TypeName="VARCHAR(25)")]
        public string? Name { get; set; }

        [Column(TypeName="VARCHAR(60)")]
        public string? Description { get; set; }
        public double Price {  get; set; }
        public int Amount { get; set; }

        public Product() { }

        public Product(string? name, string? description, double price, int amount)
        {
            Name = name;
            Description = description;
            Price = price;
            Amount = amount;
        }
    }
}
