using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikaVeterinare.BO
{
    public class User : BaseAuditObject
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public bool IsActive { get; set; }



        //public DateTime LastLoginDate { get; set; }
        //public DateTime LastPasswordChangeDate { get; set; }
        //public bool IsPasswordChanged { get; set; }


        public virtual Role Role { get; set; }
    }
}
