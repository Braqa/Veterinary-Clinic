using KlinikaVeterinare.BO;
using KlinikaVeterinare.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikaVeterinare.BLL
{
    public class SexBLL
    {
        public static List<Sex> GetSexes()
        {
            return SexDAL.GetSexes();
        }
    }
}
