using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikaVeterinare.BO
{
    public class Owner : BaseAuditObject
    {
       
        public int OwnerID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public int PersonalNo { get; set; }
        public int SexID { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }

        // Nje pronar mun me pas shum kafshe - 1 : Many
        public virtual List<Animal> animals { get; set; }

        public Owner()
        {

        }

    }
}
