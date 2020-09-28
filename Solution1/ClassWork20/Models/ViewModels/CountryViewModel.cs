using System.Web.Mvc;

namespace ClassWork20.Models.ViewModels
{
    public class CountryViewModel
    {
        public SelectList ListOfCountries { get; set; }
        public SelectList ListOfCities { get; set; }
    }
}