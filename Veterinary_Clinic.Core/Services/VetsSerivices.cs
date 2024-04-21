using Veterinary_Clinic.Database.Repositories;
using Veterinary_Clinic.Core.Dtos.Response;
using Veterinary_Clinic.Database.Entities;
using Veterinary_Clinic.Core.Mapping;

namespace Veterinary_Clinic.Core.Services
{
    public class VetsSerivices
    {
        private readonly IVetRepository _repository;

        public VetsSerivices(IVetRepository repository)
        {
            _repository = repository;
        }

        public List<VetResponseDto> GetVetsResponse()
        {
           var vets = _repository.GetVets();

           List<VetResponseDto> vetResponseDtos = new List<VetResponseDto>();

           foreach (Vet vet in vets)
           {
                vetResponseDtos.Add(vet.ToVetResponseDto());
           }

            return vetResponseDtos;
        }
    }
}
