using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClassWork16.Models
{
    public class Language
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string IsoCode { get; set; }
        public List<Country> Countries { get; set; }
    }
}