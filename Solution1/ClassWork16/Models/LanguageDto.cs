using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClassWork16.Models
{
    public class LanguageDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string IsoCode { get; set; }
        public List<CountryDto> Countries { get; set; }
    }
}