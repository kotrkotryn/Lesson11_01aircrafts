using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_01.Models
{
    internal class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public bool CountryInEurope { get; set; }

        public Country(int id, string countryName, string countryCode, bool countryInEurope)
        {
            Id = id;
            CountryName = countryName;
            CountryCode = countryCode;
            CountryInEurope = countryInEurope;

        }

    }
    
}
