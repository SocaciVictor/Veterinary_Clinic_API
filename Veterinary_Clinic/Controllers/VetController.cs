using Microsoft.AspNetCore.Mvc;
using Veterinary_Clinic.Core.Dtos.Response;
using Veterinary_Clinic.Core.Services;

namespace Veterinary_Clinic.Controllers
{
    [Route("api/Vets")]
    public class VetsController : ControllerBase
    {
        private readonly VetsSerivices _vetsSerivices;

        public VetsController(VetsSerivices vetsSerivices)
        {
            _vetsSerivices = vetsSerivices;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<VetResponseDto>> GetVets()
        {
            var response = _vetsSerivices.GetVetsResponse();

            return response;
        }
    }
}
