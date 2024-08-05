using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_34_Lesson_1_Create_DB_Model
{
    public class User
    {
        public int Id { get; set; }

        [Column(TypeName="Varchar(25)")]
        public string? Name { get; set; }

        [Column(TypeName ="Varchar(40)")]
        public string? Email { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }
        public TelephoneNumber? TelNumber { get; set; }

        public User() { }

        public User(string name, string email, int age, string address, TelephoneNumber telNumber)
        {
            Name = name;
            Email = email;
            Age = age;
            Address = address;
            TelNumber = telNumber;
        }
    }
}
