using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlinikaVeterinare.BO;

namespace KlinikaVeterinare.BLL
{
    public class ClinicBLL
    {      
        public static List<BO.Clinic> GetClinics()
        {
            return DAL.ClinicDAL.GetClinics();
        }
    }
}
