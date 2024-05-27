using Microsoft.AspNetCore.Authorization;
using Veterinary_Clinic.Core.Dtos.Request;
using Microsoft.AspNetCore.Mvc;
using Veterinary_Clinic.Core.Services;

namespace Veterinary_Clinic.Controllers
{
    public class UsersController : BaseController
    {
        private UsersServices usersService { get; set; }


        public UsersController(UsersServices usersService)
        {
            this.usersService = usersService;
        }

        [HttpPost("/register")]
        [AllowAnonymous]
        public IActionResult Register(RegisterRequest payload)
        {
            usersService.Register(payload);
            return Ok("Registration successful");
        }

        [HttpPost("/login")]
        [AllowAnonymous]
        public IActionResult Login(LoginRequest payload)
        {
            var jwtToken = usersService.Login(payload);

            return Ok(new { token = jwtToken });
        }
    }
}
