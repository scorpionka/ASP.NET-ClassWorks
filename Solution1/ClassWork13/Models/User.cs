using System;
using System.ComponentModel.DataAnnotations;

namespace ClassWork13.Models
{
    public class User
    {
        [Required(ErrorMessage = "Field: First name is required")]
        [MaxLength(20, ErrorMessage = "Field: First name must contain maximum 20 characters")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Field: Last name is required")]
        [MaxLength(30, ErrorMessage = "Field: Last name must contain maximum 20 characters")]
        public string LastName { get; set; }
        [Range(0, 10, ErrorMessage = "Field: Number of Children must contain numbers from 0 to 10")]
        public int NumberOfChildren { get; set; }
        [Required(ErrorMessage = "Field: Date of birth is required")]
        [Range(typeof(DateTime), "1/1/1900", Pars]
        public DateTime DateOfBirth { get; set; }
        public string Comments { get; set; }
        public string Email { get; set; }
    }
}