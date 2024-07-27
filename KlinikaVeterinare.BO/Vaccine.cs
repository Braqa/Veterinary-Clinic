using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikaVeterinare.BO
{
    public class Vaccine : BaseAuditObject
    {
        public string SerialNo { get; set; }
        public int VaccineID { get; set; }
    }
}
