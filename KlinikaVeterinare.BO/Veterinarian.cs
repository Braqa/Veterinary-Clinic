using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikaVeterinare.BO
{
    public class Veterinarian : BaseAuditObject
    {
        public string VeterinarianID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ClinicID { get; set; }
        public int RankID { get; set; }
        //public string Username { get; set; }
        public string Password { get; set; }  

        public Veterinarian()
        {

        }

    }
}
