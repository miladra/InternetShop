using System;
using System.Collections.Generic;

namespace InternetShop.Model
{
    public partial class FactorItem
    {
        public int ID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<byte> Qty { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<bool> IsBuy { get; set; }
        public int FactorID { get; set; }
        public virtual Factor Factor { get; set; }
        public virtual Product Product { get; set; }
    }
}
