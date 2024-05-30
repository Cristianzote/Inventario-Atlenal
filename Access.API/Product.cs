using System;
using System.Collections.Generic;

namespace Access.API
{
    public class Product
    {
        public int idProduct { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int category { get; set; }
        public string image { get; set; }
        public DateTimeOffset date { get; set; }
        //[ForeignKey("Inventory")]
        //public int INVENTORY { get; set; }

        //PK
        public ICollection<Presentation> presentations { get; set; }
    }
}
