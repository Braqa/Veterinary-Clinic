using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Drawing.Bitmap;

namespace KlinikaVeterinare.BO
{
    public class Animal : BaseAuditObject
    {
        public string AnimalID { get; set; }
        public string Name { get; set; }
        public int FamilyID { get; set; }
        public int RaceID { get; set; }
        public DateTime Birthday { get; set; }
        public int OwnerID { get; set; }
        public int SexID { get; set; }
        public string Color { get; set; }
        public string CoatMarking { get; set; }

        // Me i mar vetite e pronarit - composition - 1:1
        public virtual Owner owner { get; set; }

        public Animal()
        {

        }
    }
}

// ne disa raste duhet me kriju class-function, class- procedure
