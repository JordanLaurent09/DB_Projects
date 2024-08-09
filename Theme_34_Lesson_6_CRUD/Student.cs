using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_34_Lesson_6_CRUD
{
    [Table("Students_database")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(40)")]
        public string? FirstName { get; set; }
        [Column(TypeName = "VARCHAR(40)")]
        public string? LastName { get; set; }
        public int Age { get; set; }

        public Student() { }
        public Student(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string Display()
        {
            return $"Id студента: {Id} имя студента: {FirstName} фамилия студента: {LastName} возраст студента: {Age}";
        }
    }
}
