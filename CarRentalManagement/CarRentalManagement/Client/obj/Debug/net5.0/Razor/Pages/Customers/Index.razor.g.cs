#pragma checksum "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Customers\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb85c638e0157876aa6b546e998dcbd87a436783"
// <auto-generated/>
#pragma warning disable 1591
namespace CarRentalManagement.Client.Pages.Customers
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\_Imports.razor"
using CarRentalManagement.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\_Imports.razor"
using CarRentalManagement.Client.Static;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\_Imports.razor"
using CarRentalManagement.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\_Imports.razor"
using CarRentalManagement.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\_Imports.razor"
using CarRentalManagement.Shared.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Customers\Index.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/customers/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"card-title\">Customers</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<a href=\"/customers/create\" class=\"btn btn-secondary\"><span class=\"oi oi-plus\"></span>\r\n    Create New Customer\r\n</a>\r\n\r\n<hr>\r\n<br>");
#nullable restore
#line 15 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Customers\Index.razor"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<div class=\"alert alert-info\">Loading Customers...</div>");
#nullable restore
#line 18 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Customers\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table table-responsive");
            __builder.AddMarkupContent(5, "<thead><tr><th>Tax ID</th>\r\n                <th>Contact Number</th>\r\n                <th>Email Address</th>\r\n                <th>Actions</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 31 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Customers\Index.razor"
             foreach (var customer in Model)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 34 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Customers\Index.razor"
                         customer.TaxId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 35 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Customers\Index.razor"
                         customer.ContactNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 36 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Customers\Index.razor"
                         customer.EmailAddress

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.OpenElement(18, "a");
            __builder.AddAttribute(19, "href", "/makes/view/" + (
#nullable restore
#line 38 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Customers\Index.razor"
                                              customer.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "class", "btn btn-primary");
            __builder.AddMarkupContent(21, "<span class=\"oi oi-book\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "href", "/makes/edit/" + (
#nullable restore
#line 41 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Customers\Index.razor"
                                              customer.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "class", "btn btn-warning");
            __builder.AddMarkupContent(26, "<span class=\"oi oi-pencil\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "class", "btn btn-danger");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Customers\Index.razor"
                                                                 () => Delete(customer.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(31, "<span class=\"oi oi-delete\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Customers\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Customers\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Customers\Index.razor"
       
    private List<Customer> Model;

    protected async override Task OnInitializedAsync()
    {
        Model = await _client.GetFromJsonAsync<List<Customer>>(Endpoints.Customers);
    }

    async Task Delete(int id)
    {
        var customer = Model.First(m => m.Id == id);

        var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {customer.TaxId}?");

        if (confirm)
        {
            await _client.DeleteAsync($"{Endpoints.Customers}/{id}");
            await OnInitializedAsync();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _client { get; set; }
    }
}
#pragma warning restore 1591
