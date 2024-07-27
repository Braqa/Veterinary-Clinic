using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikaVeterinare.BO
{
    public class VeterinarianRank : BaseAuditObject
    {
        public int VeterinarianRankID { get; set; }
        public string Rank_Al { get; set; }
        public string Rank_En { get; set; }

        public VeterinarianRank()
        {

        }

    }
}
