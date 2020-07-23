using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClassWork2.Models
{
    public class Person
    {
        public enum Sex
        {
            [Display(Name = "male")]
            Male,
            [Display(Name = "female")]
            Female
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public Sex sex { get; set; }
        public List<Person> Children { get; set; }
    }
}