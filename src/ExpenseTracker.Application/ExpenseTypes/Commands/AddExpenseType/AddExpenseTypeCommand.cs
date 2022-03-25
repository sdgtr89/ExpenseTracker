using ExpenseTracker.Application.Common.Handlers;
using ExpenseTracker.Application.Common.Interfaces;
using ExpenseTracker.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ExpenseTracker.Application.ExpenseTypes.Commands.AddExpenseType
{
    public class AddExpenseTypeCommand : IRequest<int>
    {
        public string Name { get; set; }
    }

    public class AddExpenseTypeCommandHandler : CommandHandlerBase, IRequestHandler<AddExpenseTypeCommand, int>
    {
        public AddExpenseTypeCommandHandler(IDbContext context) 
            : base(context)
        {
        }

        public async Task<int> Handle(AddExpenseTypeCommand request, CancellationToken cancellationToken)
        {
            var expenseTypeToAdd = new ExpenseType()
            {
                Name = request.Name
            };

            await _context.ExpenseTypes.AddAsync(expenseTypeToAdd);
            await _context.SaveChangesAsync(cancellationToken);

            return expenseTypeToAdd.Id;
        }
    }
}
