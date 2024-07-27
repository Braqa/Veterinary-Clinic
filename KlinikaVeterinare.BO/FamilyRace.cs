using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikaVeterinare.BO
{
    public class FamilyRace : BaseAuditObject
    {
        public int AnimalFamily { get; set; }
        public int AnimalRace { get; set; }

        public FamilyRace()
        {

        }
    }
}
