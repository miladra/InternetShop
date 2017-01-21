using System;
using System.Collections.Generic;

namespace InternetShop.Model
{
    public partial class City
    {
        public City()
        {
            this.Agencies = new List<Agency>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int ProvinceID { get; set; }
        public virtual ICollection<Agency> Agencies { get; set; }
        public virtual Province Province { get; set; }
    }
}
