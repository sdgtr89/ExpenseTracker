#pragma checksum "C:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\Pages\Expenses.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b62b8a6947211321f5963075be46d1d2ddde64e"
// <auto-generated/>
#pragma warning disable 1591
namespace ExpenseTracker.UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using ExpenseTracker.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using ExpenseTracker.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using ExpenseTracker.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using ExpenseTracker.UI.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using ExpenseTracker.UI.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using ExpenseTracker.UI.Extensions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/expenses")]
    public partial class Expenses : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>All Expenses</h2>\r\n\r\n");
            __builder.OpenComponent<ExpenseTracker.UI.Pages.AddExpenseComponent>(1);
            __builder.AddAttribute(2, "OnExpenseAdded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ExpenseTracker.UI.Models.ExpenseModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ExpenseTracker.UI.Models.ExpenseModel>(this, 
#nullable restore
#line 7 "C:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\Pages\Expenses.razor"
                                     OnExpenseAddedHandler

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ExpenseTypesList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ExpenseTracker.UI.Models.ExpenseTypesListModel>(
#nullable restore
#line 7 "C:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\Pages\Expenses.razor"
                                                                              _expenseTypesList

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenComponent<ExpenseTracker.UI.Pages.ExpenseTypeModal>(5);
            __builder.AddAttribute(6, "OnExpenseTypeAdded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ExpenseTracker.UI.Models.ExpenseTypeModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ExpenseTracker.UI.Models.ExpenseTypeModel>(this, 
#nullable restore
#line 8 "C:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\Pages\Expenses.razor"
                                      OnExpenseTypeAddedHandler

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n    \r\n<br>\r\n");
            __builder.OpenComponent<ExpenseTracker.UI.Pages.ExpensesList>(8);
            __builder.AddAttribute(9, "DeleteExpenseEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 11 "C:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\Pages\Expenses.razor"
                                  OnExpenseDeletedHandler

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ExpenseList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ExpenseTracker.UI.Models.ExpensesListModel>(
#nullable restore
#line 11 "C:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\Pages\Expenses.razor"
                                                                        _expensesList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ResetFilterEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 11 "C:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\Pages\Expenses.razor"
                                                                                                         OnFilterHandler

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\Pages\Expenses.razor"
       
    private ExpensesListModel _expensesList;
    private ExpenseTypesListModel _expenseTypesList;

    protected override async Task OnInitializedAsync()
    {
        _expensesList = new();
        _expenseTypesList = new();
        await FetchExpenses();
        await FetchExpenseTypes();
    }

    //Event Handlers 

    private async Task OnExpenseAddedHandler(ExpenseModel expenseToAdd)
    {
        if (expenseToAdd is not null)
        {
            await _expenseClient.Post(expenseToAdd);
            await FetchExpenses();
        }
    }

    private async Task OnExpenseDeletedHandler(int id)
    {
        if (id > 0)
        {
            await _expenseClient.Delete(id);
            await FetchExpenses();
        }
    }

    private async Task OnExpenseTypeAddedHandler(ExpenseTypeModel expenseTypeToAdd)
    {
        if (expenseTypeToAdd is not null)
        {
            await _expenseTypeClient.Post(expenseTypeToAdd);
            await FetchExpenseTypes();
        }
    }

    private async Task OnFilterHandler()
    {
        await FetchExpenses();
    }

    //Data Fetching

    private async Task FetchExpenses()
    {
        _expensesList = await _expenseClient.GetAll();
    }

    private async Task FetchExpenseTypes()
    {
        _expenseTypesList = await _expenseTypeClient.GetAll();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ExpenseTypeHttpClient _expenseTypeClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ExpenseHttpClient _expenseClient { get; set; }
    }
}
#pragma warning restore 1591