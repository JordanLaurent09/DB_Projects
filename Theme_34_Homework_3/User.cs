using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_34_Homework_3
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Email { get; set; }

        public User() {  }

        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
