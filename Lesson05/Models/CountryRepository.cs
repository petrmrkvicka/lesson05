using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson05.Models
{
    public class CountryRepository
    {
        private List<Country> countries = new List<Country>
        {
            new Country { CountryName = "China", CountryCode = "CN"},
            new Country { CountryName = "Denmark", CountryCode = "DK" },
            new Country { CountryName = "France", CountryCode = "FR" },
            new Country { CountryName = "USA", CountryCode = "US" }
        };

        public IEnumerable<Country> Countries { get {
                return countries.OrderBy(x => x.CountryName).ToList();
            } }

        public void AddCountry(Country newCountry)
        {
            Country country = countries.Where(c => c.CountryName == newCountry.CountryName).FirstOrDefault();
            if (country == null)
            {
                countries.Add(newCountry);
            }
        }
    }
}
