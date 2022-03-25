using ExpenseTracker.UI.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ExpenseTracker.UI.Services
{
    public class ExpenseTypeHttpClient
    {
        
        private HttpClient _client;

        public ExpenseTypeHttpClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<ExpenseTypesListModel> GetAll()
        {
            return await _client.GetFromJsonAsync<ExpenseTypesListModel>(_client.BaseAddress);
        }

        public async Task<HttpResponseMessage> Post(ExpenseTypeModel expenseType)
        {
            var response = await _client.PostAsJsonAsync(_client.BaseAddress, expenseType);
            return response;
        }
    }
}
