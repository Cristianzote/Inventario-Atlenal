using System;
using System.Collections.Generic;
namespace Access.API
{
    public class Transaction
    {
        public int idTransaction { get; set; }
        public float value { get; set; }
        public bool cover { get; set; }
        public DateTimeOffset date { get; set; }
        public TransactionType type { get; set; }
        public List<TransactionDetail> transactionDetail { get; set; }
        public Table table { get; set; }
    }

    public enum TransactionType
    {
        INCOME = 1,
        OUTPUT = 2
    }

    public enum Table
    {
        SOSSA = 1,
        PIANO = 2,
        VIRGEN = 3,
        RINCON = 4,
        MITAD = 5,
        MORENO = 6,
        BARRA = 7,
        AFUERA = 8,
    }
}
