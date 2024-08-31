using System;
using System.Collections.Generic;
using System.Text;

namespace Access.API
{
    public class MonthlyRegister
    {
        public int idMonthlyRegister { get; set; }
        public DateTime initialDate { get; set; }
        public DateTime finalDate { get; set; }
        public int initialInventory { get; set; }
        public int finalInventory { get; set; }
        public int purchases { get; set; }
        public int expenses { get; set; }
    }
}