using System;
using System.Collections.Generic;

namespace InternetShop.Model
{
    public partial class Factor
    {
        public Factor()
        {
            this.FactorItems = new List<FactorItem>();
        }

        public int ID { get; set; }
        public System.DateTime BuyDate { get; set; }
        public string FlloweCode { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> UserID { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string CodePosti { get; set; }
        public bool IsFinish { get; set; }
        public virtual ICollection<FactorItem> FactorItems { get; set; }
        public virtual User User { get; set; }
    }
}
