using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinary_Clinic.Database.Context;

namespace Veterinary_Clinic.Database.Repositories
{
    public class BaseRepository
    {

        protected readonly VeterinaryClinicDbContext VeterinaryClinicDbContext;

        public BaseRepository(VeterinaryClinicDbContext veterinaryClinicDbContext)
        {
            this.VeterinaryClinicDbContext = veterinaryClinicDbContext;
        }

        public void SaveChanges()
        {
            VeterinaryClinicDbContext.SaveChanges();
        }
    }
}
