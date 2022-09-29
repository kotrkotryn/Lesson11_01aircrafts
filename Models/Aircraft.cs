using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_01.Models
{
    internal class Aircraft
    {
        public int TailNumber { get; set; }
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int ModelId { get; set; }


        public Aircraft(int tailNumber, int id, int countryId, int modelId)
        {
            TailNumber = tailNumber;
            Id = id;
            CountryId = countryId;
            ModelId = modelId;
        }
    }
}
