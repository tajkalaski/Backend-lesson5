using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson5.Models
{
    public class CountryRepository
    {
        private List<Country> countries = new List<Country>
        {
            new Country { Name = "China", CountryCode = "CN" },
            new Country { Name = "Denmark", CountryCode = "DK" },
            new Country { Name = "Poland", CountryCode = "PL" },
            new Country { Name = "France", CountryCode = "FR" }
        };

        public IEnumerable<Country> Countries { get { return countries; } }

        public void AddCountry(Country newCountry)
        {
            countries.Add(newCountry);
        }

    }
}
