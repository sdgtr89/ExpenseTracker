using ExpenseTracker.Application.Common.Interfaces;

namespace ExpenseTracker.Application.Common.Handlers
{
    public abstract class CommandHandlerBase
    {
        protected readonly IDbContext _context;

        protected CommandHandlerBase(IDbContext context)
        {
            _context = context;
        }
    }
}
