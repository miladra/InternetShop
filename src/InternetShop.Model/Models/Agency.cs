using System;
using System.Collections.Generic;

namespace InternetShop.Model
{
    public partial class Agency
    {
        public int ID { get; set; }
        public Nullable<int> CityID { get; set; }
        public int ProvinceID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual City City { get; set; }
        public virtual Province Province { get; set; }
    }
}
