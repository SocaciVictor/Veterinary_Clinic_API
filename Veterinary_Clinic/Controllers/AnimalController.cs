using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Veterinary_Clinic.Core.Dtos.Response;
using Veterinary_Clinic.Core.Services;

namespace Veterinary_Clinic.Controllers
{
    [Authorize]
    [Route("api/Animal")]
    public class AnimalController : Controller
    {
        private readonly AnimalsServices _animalServices;

        public AnimalController(AnimalsServices animalsServices)
        {
            _animalServices = animalsServices;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<AnimalDto>> GetsAnimals()
        {
            var response = _animalServices.GetAllAnimalsDto();

            return response;
        }
    }
}
