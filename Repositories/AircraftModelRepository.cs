using Lesson11_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_01.Repositories
{
    internal class AircraftModelRepository
    {
        List<AircraftModel> AircraftModels { get; set; }

        public AircraftModelRepository()
        {
            AircraftModels = new List<AircraftModel>();
            AircraftModels.Add(new AircraftModel(005, "Model", "NiceModel"));
            AircraftModels.Add(new AircraftModel(006, "ModelModel", "VeryNiceModel"));
            AircraftModels.Add(new AircraftModel(007, "ModelModelModel", "SuperNiceModel"));
            AircraftModels.Add(new AircraftModel(500, "UnitedModel", "UnitedNiceModel"));
            AircraftModels.Add(new AircraftModel(600, "UnitedModelModel", "UnitedVeryNiceModel"));
        }

        public List<AircraftModel> Retrieve()
        {
            return AircraftModels;
        }

        public AircraftModel Retrieve(int countryId)
        {
            return AircraftModels.Where(c => c.Id == countryId).FirstOrDefault();
        }
    }
}
