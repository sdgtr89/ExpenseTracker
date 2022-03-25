using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.UI.Models
{
    public class ExpenseFilterModel
    {
        public int Month { get; set; }
        public decimal MinAmount { get; set; }
        public decimal MaxAmount { get; set; }

        public ExpenseFilterModel()
        {
            Month = 0;
            MinAmount = 0m;
            MaxAmount = 0m;
        }
    }
}
