
namespace Veterinary_Clinic.Core.Dtos.Response
{
    public class VetResponseDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Specialization { get; set; }

        public List<AnimalDto> Animals { get; set; }
    }
}
