using System;

namespace Access.API
{
    public class Product
    {
        public int ID_PRODUCT { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string IMAGE { get; set; }
        public DateTimeOffset DATE { get; set; }
        public Presentation Presentations { get; set; }
    }
}
