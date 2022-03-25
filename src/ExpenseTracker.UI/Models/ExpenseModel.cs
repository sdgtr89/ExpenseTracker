using System;

namespace ExpenseTracker.UI.Models
{
    public class ExpenseModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public ExpenseTypeModel ExpsenseType { get; set; }
        public int ExpenseTypeId { get; set; }
    }
}
