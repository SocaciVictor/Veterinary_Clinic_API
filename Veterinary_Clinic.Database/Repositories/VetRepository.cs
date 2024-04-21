using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinary_Clinic.Database.Context;
using Veterinary_Clinic.Database.Entities;

namespace Veterinary_Clinic.Database.Repositories
{
    public class VetRepository : BaseRepository, IVetRepository
    {
        public VetRepository(VeterinaryClinicDbContext veterinaryClinicDbContext) : base(veterinaryClinicDbContext)
        {
        }

        public List<Vet> GetVets()
        {
            var result = VeterinaryClinicDbContext.Vets
                .Include(v => v.Animals)
                .ToList();

            return result;
        }
    }
}
