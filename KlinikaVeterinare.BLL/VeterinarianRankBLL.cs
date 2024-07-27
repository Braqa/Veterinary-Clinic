using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikaVeterinare.BLL
{
    public class VeterinarianRankBLL
    {
        public static List<BO.VeterinarianRank> GetVetRanks()
        {
            return DAL.VeterinarianRankDAL.GetVetRanks();
        }
    }
}
