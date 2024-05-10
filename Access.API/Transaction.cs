using System;
using System.Collections.Generic;
namespace Access.API
{
    public class Transaction
    {
        public int ID_TRANSACTION { get; set; }
        public float VALUE { get; set; }
        public DateTimeOffset DATE { get; set; }
        public TransactionType TYPE { get; set; }
        public List<TransactionDetail> TransactionDetail { get; set; }
    }

    public enum TransactionType
    {
        INCOME = 1,
        OUTPUT = 2
    }
}
