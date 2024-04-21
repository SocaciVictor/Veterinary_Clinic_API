using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary_Clinic.Database.Entities
{
    public class Animal
    {
        public int  ID { get; set; }

        public string  Name { get; set; }   

        public string Race { get; set; }

        public int Age { get; set; }

        public float Weight { get; set; }

        public Vet Vet {  get; set; }

        public int VetID { get; set; }
    }
}
