using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikaVeterinare.BO
{
    public class VaccineInfo : BaseAuditObject
    {
        public int VaccineID { get; set; }
        public string SerialNo { get; set; }
        public string Name_AL { get; set; }
        public string Name_EN { get; set; }
        public string Description_AL { get; set; }
        public string Description_EN { get; set; }

    }
}
