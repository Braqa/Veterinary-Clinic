using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikaVeterinare.BO
{
    public class Role : BaseAuditObject
    {
        public int RoleID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        //public virtual List<User> Users { get; set; }
    }
}
