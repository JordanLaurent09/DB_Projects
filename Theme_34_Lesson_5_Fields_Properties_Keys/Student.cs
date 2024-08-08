using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_34_Lesson_5_Fields_Properties_Keys
{
    [Table("Students_data")]
    public class Student
    {
        [Required]
        private int _id;
        [Column(TypeName = "VARCHAR(25)")]
        private string? _name;
        private int _age;
        [Column(TypeName = "VARCHAR(25)")]
        private string? _group;
        public int Id => _id;
        public int Age => _age;

        public Student(string name, int age, string group)
        {
            _name = name;
            _age = age;
            _group = group;
        }
    }
}
