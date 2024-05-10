using System;
namespace Access.API
{
    public class TransactionDetail
    {
        public int ID_TRANSACTION_DETAIL { get; set; }
        public int QUANTITY { get; set; }
        public bool DETAIL { get; set; }
        public int PRESENTATION { get; set; }
        public Presentation? Presentation { get; set; }
        public int TRANSACTION { get; set; }
        public Transaction Transaction { get; set; }
    }
}
