using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinary_Clinic.Core.Dtos.Request;
using Veterinary_Clinic.Database.Entities;
using Veterinary_Clinic.Database.Repositories;

namespace Veterinary_Clinic.Core.Services
{
    public class UsersServices
    {
        public AuthService authService { get; set; }
        public IUserRepository usersRepository { get; set; }
        public UsersServices(
            AuthService authService,
            IUserRepository usersRepository)
        {
            this.authService = authService;
            this.usersRepository = usersRepository;
        }

        public void Register(RegisterRequest registerData)
        {
            if (registerData == null)
            {
                return;
            }

            var user = new User
            {
                Username = registerData.Username,
                Email = registerData.Email,
                RoleId = registerData.RoleId
            };

            var passwordSalt = authService.GenerateSalt();
            user.PasswordSalt = Convert.ToBase64String(passwordSalt);
            user.Password = authService.HashPassword(registerData.Password, passwordSalt);

            usersRepository.AddUser(user);
        }


        public string Login(LoginRequest payload)
        {
            var user = usersRepository.GetByEmail(payload.Email);

            if (authService.HashPassword(payload.Password, Convert.FromBase64String(user.PasswordSalt)) == user.Password)
            {
                var role = user.Role.Name;

                return authService.GetToken(user, role);
            }
            else
            {
                return null;
            }
        }
    }
}
