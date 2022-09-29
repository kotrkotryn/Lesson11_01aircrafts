using Lesson11_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_01.Repositories
{
    internal class AircraftRepository
    {
        List<Aircraft> Aircrafts;

        public AircraftRepository()
        {
            Aircrafts = new List<Aircraft>();

            Aircrafts.Add(new Aircraft(1231, 1, 57, 005));
            Aircrafts.Add(new Aircraft(1232, 2, 58, 006));
            Aircrafts.Add(new Aircraft(1233, 3, 59, 007));
            Aircrafts.Add(new Aircraft(4321, 4, 87, 500));
            Aircrafts.Add(new Aircraft(4322, 5, 88, 600));
        }
        public List<Aircraft> Retrieve()
        {
            return Aircrafts;
        }

        public Aircraft Retrieve (int countryId)
        {
            return Aircrafts.Where(c => c.CountryId == countryId).FirstOrDefault();
        }
    }
}
