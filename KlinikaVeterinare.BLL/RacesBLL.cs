using KlinikaVeterinare.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikaVeterinare.DAL
{
    public class RacesBLL
    {
        public static List<Race> GetAllRaces()
        {
            return RaceDAL.GetAllRaces();
        }
    }
}
