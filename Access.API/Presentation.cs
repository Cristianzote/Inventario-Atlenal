using System;
namespace Access.API
{
    public class Presentation
    {
        public int ID_PRESENTATION { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public int QUANTITY { get; set; }
        public float PRICE_INCOME { get; set; }
        public float PRICE_OUTPUT { get; set; }
        public int STOCK { get; set; }
        public int RETAIL_STOCK { get; set; }
        public int RETAIL_STOCK_RATIO { get; set; }
        public int PRICE_RETAIL { get; set; }
        public DateTimeOffset DATE { get; set; }
        public int PRODUCT { get; set; }
        public Product? Product { get; set; }
    }
}
