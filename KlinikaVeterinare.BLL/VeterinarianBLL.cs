using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlinikaVeterinare.DAL;

namespace KlinikaVeterinare.BLL
{
    public class VeterinarianBLL
    {
        public static BO.Veterinarian AddVeterinarian(BO.Veterinarian veterinarian, BO.User user,BO.User loggeduser)
        {
           return DAL.VeterinarianDAL.AddVeterinarian(veterinarian, user, loggeduser);
        }
        public static BO.Veterinarian UpdateVeterinarian(BO.Veterinarian veterinarian, BO.User user, BO.User loggeduser)
        {
            return DAL.VeterinarianDAL.UpdateVeterinarian(veterinarian, user, loggeduser);
        }
    
        public static List<BO.Veterinarian> GetAllVeterinarians()
        {
            return DAL.VeterinarianDAL.GetAllVeterinarians();
        }

        public static BO.Veterinarian GetById(int id)
        {
            return VeterinarianDAL.Get(id);
        }
    }
}
