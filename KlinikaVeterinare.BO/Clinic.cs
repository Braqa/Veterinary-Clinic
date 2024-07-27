using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikaVeterinare.BO
{
    public class Clinic : BaseAuditObject
    {
        public string ClinicID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        // ne nje klinike kryhen shum vizita
        public virtual List<Visit> Visits { get; set; }
        public Clinic()
        {

        }
        
    }

}
