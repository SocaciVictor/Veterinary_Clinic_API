using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinary_Clinic.Core.Dtos.Response;
using Veterinary_Clinic.Database.Entities;
using Veterinary_Clinic.Core.Mapping;

namespace Veterinary_Clinic.Core.Mapping
{
    public static class VetExtensionMetods
    {
        public static VetResponseDto ToVetResponseDto(this Vet vet)
        {
            var result = new VetResponseDto();

            result.Id = vet.Id;
            result.Name = vet.Name;
            result.Specialization = vet.Specialization;

            List<AnimalDto> animals = new List<AnimalDto>();

            foreach (Animal animal in vet.Animals)
            {
                animals.Add(animal.ToAnimalDto());
            }

            result.Animals = animals;

            return result;
        }
    }
}
