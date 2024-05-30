using System;
namespace Access.API
{
    public class TransactionDetail
    {
        public int idTransactionDetail { get; set; }
        public int quantity { get; set; }
        public bool detail { get; set; }
        public int presentation { get; set; }
        public Presentation? presentations { get; set; }
        //public Presentation? Presentation { get; set; }
        public int transaction { get; set; }
        //public Transaction Transaction { get; set; }
    }
}
