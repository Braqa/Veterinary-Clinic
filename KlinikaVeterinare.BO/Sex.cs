using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikaVeterinare.BO
{
    public class Sex : BaseAuditObject
    {
        public int SexID { get; set; }
        public string Sex_Al { get; set; }
        public string Sex_En { get; set; }

        public Sex()
        {

        }


    }
}
