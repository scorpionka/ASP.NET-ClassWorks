using System.Collections.Generic;
using System.ComponentModel;

namespace ClassWork2.Models
{
    public class Person
    {
        public enum Sex
        {
            [Description("male")]
            male,
            [Description("female")]
            female
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public Sex sex { get; set; }
        public List<Person> Children { get; set; }
    }
}