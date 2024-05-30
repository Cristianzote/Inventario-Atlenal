using System;
using System.Collections.Generic;
namespace Access.API
{
    public class Transaction
    {
        public int idTransaction { get; set; }
        public float value { get; set; }
        public DateTimeOffset date { get; set; }
        public TransactionType type { get; set; }
        public List<TransactionDetail> transactionDetail { get; set; }
    }

    public enum TransactionType
    {
        INCOME = 1,
        OUTPUT = 2
    }
}
