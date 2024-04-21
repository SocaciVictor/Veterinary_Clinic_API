using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary_Clinic.Database.Entities
{
    public class Vet
    {
        public int Id { get; set; }

        public string  Name { get; set; }

        public string Specialization { get; set; }  

        public string Address { get; set; }

        public DateTime BirthYear { get; set; }
        
        public List<Animal> Animals { get; set; }
    }
}
