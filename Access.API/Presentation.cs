using System;
namespace Access.API
{
    public class Presentation
    {
        public int idPresentation { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
        public float priceIncome { get; set; }
        public float priceOutput { get; set; }
        public int stock { get; set; }
        public int retailStock { get; set; }
        public int retailStockRatio { get; set; }
        public int priceRetail { get; set; }
        public DateTimeOffset date { get; set; }
        public int product { get; set; }
    }
}
