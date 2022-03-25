using ExpenseTracker.Application.Common.Handlers;
using ExpenseTracker.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace ExpenseTracker.Application.Expenses.Commands.DeleteExpense
{
    public class DeleteExpenseCommand : IRequest
    {
        public int Id { get; set; }
    }

    public class DeleteExpenseCommandHandler : CommandHandlerBase, IRequestHandler<DeleteExpenseCommand>
    {
        public DeleteExpenseCommandHandler(IDbContext context) 
            : base(context)
        {
        }

        public async Task<Unit> Handle(DeleteExpenseCommand request, CancellationToken cancellationToken)
        {
            var expenseToDelete = await _context.Expenses.FirstOrDefaultAsync(e => e.Id == request.Id);
            _context.Expenses.Remove(expenseToDelete);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }    
}
