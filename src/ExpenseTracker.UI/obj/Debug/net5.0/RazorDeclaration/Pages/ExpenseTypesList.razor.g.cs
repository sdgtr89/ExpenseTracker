// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ExpenseTracker.UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using ExpenseTracker.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using ExpenseTracker.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using ExpenseTracker.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using ExpenseTracker.UI.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "c:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using ExpenseTracker.UI.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "c:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "c:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "c:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\_Imports.razor"
using ExpenseTracker.UI.Extensions;

#line default
#line hidden
#nullable disable
    public partial class ExpenseTypesList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "c:\Users\Steve\source\repos\ExpenseTracker\src\ExpenseTracker.UI\Pages\ExpenseTypesList.razor"
       
    ExpenseTypesListModel expenseTypes;
    string errors;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            expenseTypes = await _expenseTypeClient.GetAll();
        }
        catch (Exception ex)
        {

            errors = $"An error has occurred fetching data: {ex.Message}";
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ExpenseTypeHttpClient _expenseTypeClient { get; set; }
    }
}
#pragma warning restore 1591
