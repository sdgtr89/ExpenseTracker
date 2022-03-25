using ExpenseTracker.UI.Extensions;
using ExpenseTracker.UI.Models;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ExpenseTracker.UI.Services
{
    public class ExpenseHttpClient
    {
        private readonly HttpClient _client;

        public ExpenseHttpClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<ExpensesListModel> GetAll()
        {
            return await _client.GetFromJsonAsync<ExpensesListModel>(_client.BaseAddress);
        }

        public async Task<HttpResponseMessage> Post(ExpenseModel expense)
        {
            var response = await _client.PostAsJsonAsync(_client.BaseAddress, expense);
            return response;
        }

        public async Task<HttpResponseMessage> Delete(int id)
        {
            var endpoint = $"{_client.BaseAddress}/{id}";
            var response = await _client.DeleteAsync(endpoint);
            return response;
        }
    }
}
