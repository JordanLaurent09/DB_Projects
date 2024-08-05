using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Theme_34_Lesson_3_Connection_String_Configuration
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
