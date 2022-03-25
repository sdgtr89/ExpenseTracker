using ExpenseTracker.Application.Common.Mapping;
using ExpenseTracker.Application.ExpenseTypes;
using ExpenseTracker.Domain.Entities;
using System;

namespace ExpenseTracker.Application.Expenses
{
    public class ExpenseDto : IMapFrom<Expense>
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public ExpenseTypeDto ExpsenseType { get; set; }
    }
}
