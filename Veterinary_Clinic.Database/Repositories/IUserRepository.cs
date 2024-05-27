using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinary_Clinic.Database.Entities;

namespace Veterinary_Clinic.Database.Repositories
{
    public interface IUserRepository
    {
        List<User> GetUsers();

        User GetByEmail(string email);

        void AddUser(User user);

    }
}
