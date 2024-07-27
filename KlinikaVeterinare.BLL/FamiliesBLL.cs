using KlinikaVeterinare.BO;
using KlinikaVeterinare.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikaVeterinare.BLL
{
    public class FamiliesBLL
    {
        public static List<Family> GetAllFamilies()
        {
            return FamilyDAL.GetAllFamilies();
        }
    }
}
