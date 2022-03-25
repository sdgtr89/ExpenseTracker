using System;

namespace ExpenseTracker.Domain.Entities
{
    public class Expense
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public ExpenseType ExpsenseType { get; set; }
        public int ExpenseTypeId { get; set; }
    }
}
