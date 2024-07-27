using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlinikaVeterinare.BO;
using KlinikaVeterinare.BO.Interfaces;
using KlinikaVeterinare.DAL;

namespace KlinikaVeterinare.BLL
{
    public class VaccineBLL
    { 
       public static bool Add(Vaccine vaccine,User loggeduser)
        {
            return DAL.VaccineDAL.Add(vaccine, loggeduser);
        }

        public static List<Vaccine> GetAllVaccines()
        {
            return VaccineDAL.GetAll();
        }
    }
}
