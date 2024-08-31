using System;
using System.Collections.Generic;
using System.Text;

namespace Access.API
{
    public class Expense
    {
        public int idExpense { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public int value { get; set; }
        public ExpenceType type { get; set; }
        public double multiplier { get; set; }
        public bool active { get; set; }
    }

    public enum ExpenceType
    {
        OCCASIONAL = 1,
        RECURRENT = 2,
    }
}
