using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_34_Homework_2.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR(25)")]
        public string? Name { get; set; }
        public string? Description { get; set; }

        public Category() { }

        public Category(string? name, string? description)
        {
            Name = name;
            Description = description;
        }
    }
}
