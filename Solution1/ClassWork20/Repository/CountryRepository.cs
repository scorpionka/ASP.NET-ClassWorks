using ClassWork20.Models.Models;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace ClassWork20.Repository
{
    public class CountryRepository
    {
        private List<Country> countries;
        private List<City> cities;
        public CountryRepository()
        {
            cities = new List<City>
            {
                new City {Id = 1, Name = "Minsk"},
                new City {Id = 2, Name = "Moscow"},
                new City {Id = 3, Name = "Brest"},
                new City {Id = 4, Name = "Vitebsk"},
                new City {Id = 5, Name = "Gomel"},
                new City {Id = 6, Name = "Saint-Petersburg"},
                new City {Id = 7, Name = "Novosibirsk"},
            };

            countries = new List<Country>
            {
                new Country {Id = 1, Name = "Belarus", Cities = 
            }
        }
    }
}