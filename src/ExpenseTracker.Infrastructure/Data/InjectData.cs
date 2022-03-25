using Microsoft.Extensions.Configuration;
using ExpenseTracker.Application.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Infrastructure.Data
{
    public static class InjectData
    {
        public static IServiceCollection InjectDataLayer(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ExpenseTrackerDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ExpenseTrackerDbContext).Assembly.FullName)));

            services.AddScoped<IDbContext>(provider => provider.GetService<ExpenseTrackerDbContext>());

            return services;
        }
    }
}
