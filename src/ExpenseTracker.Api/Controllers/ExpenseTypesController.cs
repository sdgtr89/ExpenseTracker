using ExpenseTracker.Application.ExpenseTypes;
using ExpenseTracker.Application.ExpenseTypes.Commands.AddExpenseType;
using ExpenseTracker.Application.ExpenseTypes.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ExpenseTracker.Api.Controllers
{

    public class ExpenseTypesController : DefaultControllerBase
    {
        [HttpGet()]
        public async Task<ActionResult<ExpenseTypesVm>> Get([FromQuery] GetAllExpenseTypesQuery query)
        {
            return await Mediator.Send(query);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Add(AddExpenseTypeCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
