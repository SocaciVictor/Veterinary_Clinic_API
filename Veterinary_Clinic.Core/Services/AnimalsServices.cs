using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinary_Clinic.Core.Dtos.Response;
using Veterinary_Clinic.Core.Mapping;
using Veterinary_Clinic.Database.Entities;
using Veterinary_Clinic.Database.Repositories;

namespace Veterinary_Clinic.Core.Services
{
    public class AnimalsServices
    {
        private readonly IAnimalRepository _animalRepository;
        public AnimalsServices(IAnimalRepository repository)
        {
            _animalRepository = repository;
        }

        public List<AnimalDto> GetAllAnimalsDto()
        {
            var animals = _animalRepository.GetAllAnimals();

            List<AnimalDto> vetResponseDtos = new List<AnimalDto>();

            foreach (Animal animal in animals)
            {
                vetResponseDtos.Add(animal.ToAnimalDto());
            }

            return vetResponseDtos;
        }
    }
}
