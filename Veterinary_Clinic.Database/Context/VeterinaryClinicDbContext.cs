using Microsoft.EntityFrameworkCore;
using Veterinary_Clinic.Database.Entities;

namespace Veterinary_Clinic.Database.Context
{
    public class VeterinaryClinicDbContext : DbContext
    {
        public DbSet<Vet> Vets { get; set; }

        public DbSet<Animal> Animals { get; set; }

        public VeterinaryClinicDbContext(DbContextOptions<VeterinaryClinicDbContext> options) : base(options) { }
    }
}
