using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetShop.Model
{
    public partial class RoleUser
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }

        public int RoleID { get; set; }
        public virtual Role Role { get; set; }


    }
}
