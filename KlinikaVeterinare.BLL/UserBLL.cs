using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using KlinikaVeterinare.BO;
using KlinikaVeterinare.DAL;

namespace KlinikaVeterinare.BLL
{
    public class UserBLL
    {
        public static string ComputeHash256(string rawdata)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawdata));

                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public static User LogIn(string username,string password)
        {
            return UserDAL.Login(username, password);
        }
        public static List<User> UsersList()
        {
            return DAL.UserDAL.GetAll();
        }
        public static bool Add(User user, User loggeduser)
        {
            return UserDAL.Add(user, loggeduser);
        }
        public static bool Update(User user,User loggeduser,bool changePassword)
        {
            return DAL.UserDAL.Update(user,loggeduser,changePassword);
        }

        public static User GetUser(int userid)
        {
            return UserDAL.Get(userid);
        }
    }
}
