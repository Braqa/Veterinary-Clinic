using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlinikaVeterinare.DAL;
using KlinikaVeterinare.BO;

namespace KlinikaVeterinare.BLL
{
    public class VaccineInfoBLL
    {
        public static List<VaccineInfo> GetVaccineInfoAll()
        {
            return VaccineInfoDAL.GetAllVaccines();
        }
    }
}
