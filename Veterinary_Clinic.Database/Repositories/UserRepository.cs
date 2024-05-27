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
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(VeterinaryClinicDbContext veterinaryClinicDbContext) : base(veterinaryClinicDbContext)
        {
        }

        public List<User> GetUsers()
        {
            var result = VeterinaryClinicDbContext.Users
                .ToList();

            return result;
        }

        public User GetByEmail(string email)
        {
            var result = VeterinaryClinicDbContext.Users
                .Include(x => x.Role)
                .FirstOrDefault(x => x.Email == email);

            return result;
        }

        public void AddUser(User user)
        {
            VeterinaryClinicDbContext.Users.Add(user);
            VeterinaryClinicDbContext.SaveChanges();
        }
    }
}
