using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlinikaVeterinare.BO;
using KlinikaVeterinare.DAL;

namespace KlinikaVeterinare.BLL
{
    public class AdministrationBLL
    {
        private static UserDAL userDal = new UserDAL();
        private static RoleDAL roleDal = new RoleDAL();


        public static User Login(string username, string password)
        {
            return UserDAL.Login(username, password);
        }
    }
}
