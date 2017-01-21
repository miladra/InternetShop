using System;
using System.Collections.Generic;

namespace InternetShop.Model
{
    public partial class Province
    {
        public Province()
        {
            this.Agencies = new List<Agency>();
            this.Cities = new List<City>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Agency> Agencies { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
