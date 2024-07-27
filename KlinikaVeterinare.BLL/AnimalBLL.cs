using KlinikaVeterinare.BO;
using KlinikaVeterinare.BO.Interfaces;
using KlinikaVeterinare.DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikaVeterinare.BLL
{

    public class AnimalBLL// : IBaseCrud<Animal>
    {
        public static bool Add(Animal animal, Owner owner, User loggeduser)
        {
            return DAL.AnimalDAL.Add(animal, owner, loggeduser);
        }

        public static bool Edit(Animal animal, Owner owner, User loggeduser)
        {
            return AnimalDAL.Modify(animal,owner ,loggeduser);
        }
        public static List<Animal> GetAll()

        {
            return AnimalDAL.GetAll();
        }

        public static Animal Get(string animalid)
        {
            return AnimalDAL.Get(animalid);
        }
    }
}
