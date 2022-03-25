using System.Collections.Generic;

namespace ExpenseTracker.UI.Models
{
    public class ExpensesListModel
    {
        public List<ExpenseModel> Expenses { get; set; }
        public ExpensesListModel()
        {
            Expenses = new();
        }
    }
}
