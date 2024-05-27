using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinary_Clinic.Database.Context;
using Veterinary_Clinic.Database.Entities;

namespace Veterinary_Clinic.Database.Repositories
{
    public class AnimalRepository : BaseRepository, IAnimalRepository
    {
        public AnimalRepository(VeterinaryClinicDbContext context) : base(context)
        {}

        public List<Animal> GetAllAnimals()
        {
            var result = VeterinaryClinicDbContext.Animals.ToList();
            return result;
        }
    }
}
