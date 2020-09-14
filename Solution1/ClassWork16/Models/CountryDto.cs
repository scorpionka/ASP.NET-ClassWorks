namespace ClassWork16.Models
{
    public class CountryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CountryDto country1 = new CountryDto() { Id = 1, Name = "Belarus" };
        public CountryDto country2 = new CountryDto() { Id = 2, Name = "Russia" };
        public CountryDto country3 = new CountryDto() { Id = 3, Name = "Ukraine" };

    }
}