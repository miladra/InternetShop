using System;
using System.Collections.Generic;

namespace InternetShop.Model
{
    public partial class Message
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public Nullable<bool> IsRead { get; set; }
    }
}
