using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikaVeterinare.BO
{
    public class Visit : BaseAuditObject
    {
        public int VisitID { get; set; }
        public DateTime VisitDate { get; set; }
        public string AnimalID { get; set; }
        public string VeterinarianID { get; set; }
        public string ClinicID { get; set; }
        public string Diagnosis { get; set; }

        // Nje visite kryhet ne nje klinike - 1:1
        public virtual Clinic Clinic { get; set; }

        public Visit()
        {

        }
    }
}
