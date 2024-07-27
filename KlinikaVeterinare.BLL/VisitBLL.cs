using KlinikaVeterinare.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlinikaVeterinare.DAL;

namespace KlinikaVeterinare.BLL
{
    public class VisitBLL
    {
        public static bool AddVisit(Visit visit, User loggeduser)

        {
            return VisitDAL.AddVisit(visit, loggeduser);
        }

        public static List<Visit> GetAll()
        {
            return VisitDAL.GetAll();
        }

        public static Visit GetVisitById (int id)
        {
            return VisitDAL.GetVisitById(id);
        }

        public static bool UpdateVisit(Visit visit,User loggeduser)
        {
            return VisitDAL.UpdateVisit(visit, loggeduser);
        }
    }
}
