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
    public class RoleBLL // : IBaseCrud<Role>
    {
        private RoleDAL roleDal;

        public RoleBLL()
        {
            roleDal = new RoleDAL();
        }

        public int Add(Role role)
        {
            return roleDal.Add(role);
        }

        public Role Get(int id)
        {
            return roleDal.Get(id);
        }

        public Role Get(Role model)
        {
            return roleDal.Get(model);
        }

        public static List<Role> GetAll()
        {
            return RoleDAL.GetAll();
        }

        public int Modify(Role model)
        {
            return roleDal.Modify(model);
        }

        public int Remove(int id)
        {
            return roleDal.Remove(id);
        }

        public int Remove(Role model)
        {
            return roleDal.Remove(model);
        }
    }
}
