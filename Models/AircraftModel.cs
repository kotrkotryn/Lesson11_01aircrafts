using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_01.Models
{
    internal class AircraftModel
    {
        public int Id {get; set;}
        public string ModelName {get; set;}
        public string ModelDescription { get; set;}


        public AircraftModel(int id, string modelName, string modelDescription)
        {
            Id = id;
            ModelName = modelName;
            ModelDescription = modelDescription;
        }
    }
}
