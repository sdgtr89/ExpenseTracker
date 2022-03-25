using ExpenseTracker.Application.Common.Handlers;
using ExpenseTracker.Application.Common.Interfaces;
using ExpenseTracker.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ExpenseTracker.Application.Expenses.Commands.AddExpense
{
    public class AddExpenseCommand : IRequest<int>
    {
        public int ExpenseTypeId { get; set; }
        public decimal Amount { get; set; }
        public string Date { get; set; }
    }

    public class AddExpenseCommandHandler : CommandHandlerBase, IRequestHandler<AddExpenseCommand, int>
    {
        public AddExpenseCommandHandler(IDbContext context) 
            : base(context)
        {
        }

        public async Task<int> Handle(AddExpenseCommand request, CancellationToken cancellationToken)
        {
            var expenseToAdd = new Expense()
            {
                ExpenseTypeId = request.ExpenseTypeId,
                Amount = request.Amount,
                Date = DateTime.Parse(request.Date)
            };

            await _context.Expenses.AddAsync(expenseToAdd);
            await _context.SaveChangesAsync(cancellationToken);

            return expenseToAdd.Id;
        }
    }
}
