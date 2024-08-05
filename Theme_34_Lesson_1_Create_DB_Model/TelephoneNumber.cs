using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_34_Lesson_1_Create_DB_Model
{
    public class TelephoneNumber
    {
        public int Id { get; set; }
        public string? Number { get; set; }


        public TelephoneNumber() { }

        public TelephoneNumber(string? number)
        {
            Number = number;
        }
    }
}
