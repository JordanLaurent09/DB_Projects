using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_34_Homework_2.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR(25)")]
        public string? Name { get; set; }

        [Column(TypeName = "VARCHAR(25)")]
        public string? Email { get; set; }

        [Column(TypeName = "VARCHAR(25)")]
        public string? Password { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();

        public User() { }

        public User(string? name, string? email, string? password, List<Order> orders)
        {
            Name = name;
            Email = email;
            Password = password;
            Orders = orders;
        }
    }
}
