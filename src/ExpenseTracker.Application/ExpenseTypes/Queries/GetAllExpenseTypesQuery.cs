using AutoMapper;
using AutoMapper.QueryableExtensions;
using ExpenseTracker.Application.Common.Handlers;
using ExpenseTracker.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ExpenseTracker.Application.ExpenseTypes.Queries
{
    public class GetAllExpenseTypesQuery : IRequest<ExpenseTypesVm>
    {
    }

    public class GetAllExpenseTypesQueryHandler : QueryHandlerBase, IRequestHandler<GetAllExpenseTypesQuery, ExpenseTypesVm>
    {
        public GetAllExpenseTypesQueryHandler(IDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async Task<ExpenseTypesVm> Handle(GetAllExpenseTypesQuery request, CancellationToken cancellationToken)
        {
            return new ExpenseTypesVm()
            {
                ExpenseTypes = await _context.ExpenseTypes
                    .ProjectTo<ExpenseTypeDto>(_mapper.ConfigurationProvider)
                    .OrderBy(et => et.Name)
                    .ToListAsync(cancellationToken)
            };
        }
    }
}
