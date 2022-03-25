using System.Collections.Generic;

namespace ExpenseTracker.Domain.Entities
{
    public class ExpenseType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Expense> Expenses { get; set; }

        public ExpenseType()
        {
            Expenses = new HashSet<Expense>();
        }
    }
}
