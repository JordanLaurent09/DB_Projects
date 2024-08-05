using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_34_Homework_2.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }

        [Column(TypeName = "VARCHAR(25)")]
        public string? OrderStatus { get; set; }
        public User? OrderOwner { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public Order() { }

        public Order(DateTime orderDate, string? orderStatus, User? orderOwner, List<Product> products)
        {
            OrderDate = orderDate;
            OrderStatus = orderStatus;
            OrderOwner = orderOwner;
            Products = products;
        }
    }
}
