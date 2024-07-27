using KlinikaVeterinare.BO;
using KlinikaVeterinare.BO.Interfaces;
using KlinikaVeterinare.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikaVeterinare.BLL
{
    public class AppResponse<T>
    {
        public string Message { get; set; }
        public Exception Exception { get; set; }
        public T Data { get; set; }
    }

    // Thirrja e interfacit CRUD
    public class OwnerBLL //: IBaseCrud<Owner>
    {
        // Nje lloj proxy middleware ndermejt UI dha DAL
        private readonly OwnerDAL dal;

        // Construcor
        public OwnerBLL()
        {
            dal = new OwnerDAL();
        }

        // konvertimi dhe manipulimi i te dhenave ne DAL, krijimi i listave per dropdown SelectItemBox,
        public static bool Add(Owner model,User loggeduser)
        {
            return OwnerDAL.Add(model,loggeduser);       
        }

        public static Owner Get(int id)
        {
            return OwnerDAL.Get(id);
        }

        public Owner Get(Owner model)
        {
            throw new NotImplementedException();
        }

        public static List<Owner> GetAll()
        {
            // me i kthy vlerat ne data grid
            return OwnerDAL.GetAll();
        }

        public static bool Modify(Owner model,User loggeduser)
        {
            return OwnerDAL.Modify(model,loggeduser);
        }

        public int Remove(int id)
        {
            return dal.Remove(id);
        }


        public Owner Remove(Owner model)
        {
            throw new NotImplementedException();
        }
    }
}
