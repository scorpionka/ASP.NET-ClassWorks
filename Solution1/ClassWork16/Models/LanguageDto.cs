using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClassWork16.Models
{
    public class LanguageDto : CountryDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string IsoCode { get; set; }
        public List<CountryDto> Countries { get; set; }

        List<LanguageDto> languages = new List<LanguageDto>()
        { new LanguageDto {Id = 1, Name = "belorussian", IsoCode = "BLR", Countries = {new CountryDto { country1},   }}
        };
    }
}