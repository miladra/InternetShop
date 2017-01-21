using System;
using System.Collections.Generic;

namespace InternetShop.Model
{
    public partial class Group
    {
        public Group()
        {
            this.Group1 = new List<Group>();
            this.Products = new List<Product>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> ParentID { get; set; }
        public virtual ICollection<Group> Group1 { get; set; }
        public virtual Group Group2 { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
