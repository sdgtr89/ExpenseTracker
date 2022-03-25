using ExpenseTracker.Application.Common.Mapping;
using ExpenseTracker.Domain.Entities;

namespace ExpenseTracker.Application.ExpenseTypes
{
    public class ExpenseTypeDto : IMapFrom<ExpenseType>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
