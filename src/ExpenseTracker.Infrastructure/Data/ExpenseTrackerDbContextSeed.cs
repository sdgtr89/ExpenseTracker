using ExpenseTracker.Domain.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.Infrastructure.Data
{
    public class ExpenseTrackerDbContextSeed
    {
        public static async Task SeedSampleDataAsync(ExpenseTrackerDbContext context)
        {
            await SeedExpenseTypes(context);
            await SeedExpenses(context);
        }

        private static async Task SeedExpenseTypes(ExpenseTrackerDbContext context)
        {
            if (!context.ExpenseTypes.Any())
            {
                context.ExpenseTypes.AddRange(
                    new ExpenseType()
                    {
                        Name = "Car Repair"
                    },
                    new ExpenseType()
                    {
                        Name = "Phone"
                    },
                    new ExpenseType()
                    {
                        Name = "Heat"
                    },
                    new ExpenseType()
                    {
                        Name = "Internet"
                    },
                    new ExpenseType()
                    {
                        Name = "Groceries"
                    },
                    new ExpenseType()
                    {
                        Name = "Gas"
                    },
                    new ExpenseType()
                    {
                        Name = "Credit Card"
                    });

                await context.SaveChangesAsync();
            }
        }

        private static async Task SeedExpenses(ExpenseTrackerDbContext context)
        {
            if (!context.Expenses.Any())
            {
                context.Expenses.AddRange(
                    new Expense()
                    {
                        Amount = 26.54m,
                        ExpenseTypeId = context.ExpenseTypes.SingleOrDefault(pf => pf.Name == "Gas").Id,
                        Date = DateTime.Parse("2021-03-25")
                    },
                    new Expense()
                    {
                        Amount = 173.54m,
                        ExpenseTypeId = context.ExpenseTypes.SingleOrDefault(pf => pf.Name == "Internet").Id,
                        Date = DateTime.Parse("2021-02-27")
                    },
                    new Expense()
                    {
                        Amount = 145.21m,
                        ExpenseTypeId = context.ExpenseTypes.SingleOrDefault(pf => pf.Name == "Groceries").Id,
                        Date = DateTime.Parse("2021-03-28")
                    },
                    new Expense()
                    {
                        Amount = 86.04m,
                        ExpenseTypeId = context.ExpenseTypes.SingleOrDefault(pf => pf.Name == "Credit Card").Id,
                        Date = DateTime.Parse("2021-03-25")
                    },
                    new Expense()
                    {
                        Amount = 210.98m,
                        ExpenseTypeId = context.ExpenseTypes.SingleOrDefault(pf => pf.Name == "Car Repair").Id,
                        Date = DateTime.Parse("2021-03-25")
                    },
                    new Expense()
                    {
                        Amount = 81.02m,
                        ExpenseTypeId = context.ExpenseTypes.SingleOrDefault(pf => pf.Name == "Phone").Id,
                        Date = DateTime.Parse("2021-02-27")
                    },
                    new Expense()
                    {
                        Amount = 98.00m,
                        ExpenseTypeId = context.ExpenseTypes.SingleOrDefault(pf => pf.Name == "Heat").Id,
                        Date = DateTime.Parse("2021-03-28")
                    });

                await context.SaveChangesAsync();
            }
        }
    }
}
