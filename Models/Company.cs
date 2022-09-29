using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_01.Models
{
    internal class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int CountryId { get; set; }

        public Company(int id, string companyName, int countryId)
        {
            Id = id;
            CompanyName = companyName;
            CountryId = countryId;
        }

    }
}
