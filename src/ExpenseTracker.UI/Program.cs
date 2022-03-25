using BlazorStrap;
using ExpenseTracker.UI.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExpenseTracker.UI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddHttpClient<ExpenseHttpClient>(client =>
                client.BaseAddress = new Uri("https://localhost:6700/api/expenses"));
            builder.Services.AddHttpClient<ExpenseTypeHttpClient>(client =>
                client.BaseAddress = new Uri("https://localhost:6700/api/expensetypes"));
            builder.Services.AddBootstrapCss();

            await builder.Build().RunAsync();
        }
    }
}
