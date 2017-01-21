
using System;
using System.Collections.Generic;

namespace InternetShop.Model
{
    public partial class User
    {
        public User()
        {
            this.Factors = new List<Factor>();
            this.RoleUsers = new List<RoleUser>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Mobile { get; set; }
        public string Tell { get; set; }
        public Nullable<bool> Gender { get; set; }
        public Nullable<byte> Status { get; set; }

        // Save image by user id
        //  public string image { get; set; }

        public virtual ICollection<RoleUser> RoleUsers { get; set; }
        public virtual ICollection<Factor> Factors { get; set; }
    }
}
