using Microsoft.EntityFrameworkCore;
using Veterinary_Clinic.Database.Entities;

namespace Veterinary_Clinic.Database.Context
{
    public class VeterinaryClinicDbContext : DbContext
    {
        public DbSet<Vet> Vets { get; set; }

        public DbSet<Animal> Animals { get; set; }

        public DbSet<User> Users { get; set; }  

        public DbSet<Role> Roles { get; set; }

        public VeterinaryClinicDbContext(DbContextOptions<VeterinaryClinicDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
              .UseSqlServer("Server=localhost;Database=dbVeterinary;User Id=sa2;Password=admin123;TrustServerCertificate=True")
              .LogTo(Console.WriteLine);
        }
    }
}
