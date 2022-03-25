using AutoMapper;
using AutoMapper.QueryableExtensions;
using ExpenseTracker.Application.Common.Handlers;
using ExpenseTracker.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ExpenseTracker.Application.Expenses.Queries
{
    public class GetAllExpensesQuery : IRequest<ExpensesVm>
    {
    }

    public class GetAllExpensesQueryHandler : QueryHandlerBase, IRequestHandler<GetAllExpensesQuery, ExpensesVm>
    {
        public GetAllExpensesQueryHandler(IDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async Task<ExpensesVm> Handle(GetAllExpensesQuery request, CancellationToken cancellationToken)
        {
            return new ExpensesVm()
            {
                Expenses = await _context.Expenses
                    .ProjectTo<ExpenseDto>(_mapper.ConfigurationProvider)
                    .OrderBy(e => e.Date)
                    .ToListAsync(cancellationToken)
            };
        }
    }
}
