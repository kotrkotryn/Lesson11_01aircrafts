using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson11_01.Models;

namespace Lesson11_01.Repositories
{
    internal class CountryRepository
    {
        List<Country> Countries { get; set; }    //sukurtas listas countries, pridedami duomenys per country repozitoriją

        public CountryRepository()      //konstruktoriuje naudosimes [12] countries listu, kuri uzpildome duomenimis
        {
            Countries = new List<Country>();     
            Countries.Add(new Country(57, "Lietuva", "LT", true));
            Countries.Add(new Country(58, "Lietuva", "LT", true));
            Countries.Add(new Country(59, "Lietuva", "LT", true));
            Countries.Add(new Country(87, "JungtinesValstijos", "USA", false));
            Countries.Add(new Country(88, "JungtinėsValstijos", "USA", false));
        }
        public List<Country>Retrieve()           //grąžina užpildytą listą [12] countries
        {
            return Countries;
        }
        public Country Retrieve (int countryId)
        {
            return Countries.Where(c => c.Id == countryId).FirstOrDefault();      //system linq, sukurta sąlyga, kad grąžintų tą country, kurios id atitinka sąlygą arba null
        }
    }
}
