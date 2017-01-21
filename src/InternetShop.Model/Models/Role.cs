using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop.Model
{
    public partial class Role
    {
        public Role()
        {
            this.RoleUsers = new List<RoleUser>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<RoleUser> RoleUsers { get; set; }

    }
}
