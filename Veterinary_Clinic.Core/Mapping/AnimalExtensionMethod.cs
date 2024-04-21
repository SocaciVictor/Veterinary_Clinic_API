using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinary_Clinic.Core.Dtos.Response;
using Veterinary_Clinic.Database.Entities;

namespace Veterinary_Clinic.Core.Mapping
{
    public static class AnimalExtensionMethod
    {
        public static AnimalDto ToAnimalDto(this Animal animal)
        {
            var result = new AnimalDto();

            result.Id = animal.ID;
            result.Name = animal.Name;
            result.Race = animal.Race;
            result.Age = animal.Age;

            return result;
        }
    }
}
