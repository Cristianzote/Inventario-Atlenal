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
        public float priceOutputCover { get; set; }
        public int priceRetail { get; set; }
        public int priceRetailCover { get; set; }
        public bool hasRetail { get; set; }
        public int stock { get; set; }
        public DateTimeOffset date { get; set; }
        public int product { get; set; }
    }
}
