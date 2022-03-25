using AutoMapper;
using ExpenseTracker.Application.Common.Interfaces;

namespace ExpenseTracker.Application.Common.Handlers
{
    public abstract class QueryHandlerBase
    {
        protected readonly IDbContext _context;
        protected readonly IMapper _mapper;

        protected QueryHandlerBase(IDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
