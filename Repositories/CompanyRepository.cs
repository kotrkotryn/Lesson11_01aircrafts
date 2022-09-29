using Lesson11_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_01.Repositories
{
    internal class CompanyRepository
    {
        List<Company> Companies { get; set; }

        public CompanyRepository()
        {
            Companies = new List<Company>();

            Companies.Add(new Company(555, "Name", 57));
            Companies.Add(new Company(666, "NameName", 58));
            Companies.Add(new Company(777, "NameNameName", 59));
            Companies.Add(new Company(888, "UnitedName", 87));
            Companies.Add(new Company(999, "UnitedNameName", 88));
        }

        public List<Company> Retrieve()
        {
            return Companies;
        }

        public Company Retrieve (int countryId)
        {
            return Companies.Where(c => c.CountryId == countryId).FirstOrDefault();
        }
    }
}
