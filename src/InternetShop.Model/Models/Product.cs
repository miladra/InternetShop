using System;
using System.Collections.Generic;

namespace InternetShop.Model
{
    public partial class Product
    {
        public Product()
        {
            this.FactorItems = new List<FactorItem>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> GroupID { get; set; }
        public decimal Price { get; set; }
        public string Url { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
        public bool Enabled { get; set; }
        public string Image { get; set; }
        public string Summery { get; set; }
        public virtual ICollection<FactorItem> FactorItems { get; set; }
        public virtual Group Group { get; set; }
    }
}
