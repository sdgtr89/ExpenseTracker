using System.Collections.Generic;

namespace ExpenseTracker.UI.Models
{
    public class ExpenseTypesListModel
    {
        public List<ExpenseTypeModel> ExpenseTypes { get; set; }
        public ExpenseTypesListModel()
        {
            ExpenseTypes = new();
        }
    }
}
