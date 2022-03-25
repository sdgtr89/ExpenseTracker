using ExpenseTracker.Application.Expenses;
using ExpenseTracker.Application.Expenses.Commands.AddExpense;
using ExpenseTracker.Application.Expenses.Commands.DeleteExpense;
using ExpenseTracker.Application.Expenses.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ExpenseTracker.Api.Controllers
{
    public class ExpensesController : DefaultControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<ExpensesVm>> Get([FromQuery] GetAllExpensesQuery query)
        {
            return await Mediator.Send(query);
        }

        [HttpPost]
        public async Task<int> Add(AddExpenseCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {

            await Mediator.Send(new DeleteExpenseCommand { Id = id });

            return NoContent();
        }
    }
}
