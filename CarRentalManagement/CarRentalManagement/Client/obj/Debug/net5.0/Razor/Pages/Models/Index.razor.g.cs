#pragma checksum "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Models\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e0930bd627b64f3597d475bf27c44a17a72eb54"
// <auto-generated/>
#pragma warning disable 1591
namespace CarRentalManagement.Client.Pages.Models
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
#line 4 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Models\Index.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/models/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"card-title\">Models</h3>\r\n<hr>\r\n<br>");
#nullable restore
#line 9 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Models\Index.razor"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"alert alert-info\">Loading Models...</div>");
#nullable restore
#line 12 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Models\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-responsive");
            __builder.AddMarkupContent(4, "<thead><tr><th>Name</th>\r\n                <th>Actions</th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 23 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Models\Index.razor"
             foreach (var model in Model)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 26 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Models\Index.razor"
                         model.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "td");
            __builder.OpenElement(11, "a");
            __builder.AddAttribute(12, "href", "/makes/view/" + (
#nullable restore
#line 28 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Models\Index.razor"
                                              model.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "class", "btn btn-primary");
            __builder.AddMarkupContent(14, "<span class=\"oi oi-book\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                        ");
            __builder.OpenElement(16, "a");
            __builder.AddAttribute(17, "href", "/makes/edit/" + (
#nullable restore
#line 31 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Models\Index.razor"
                                              model.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "class", "btn btn-warning");
            __builder.AddMarkupContent(19, "<span class=\"oi oi-pencil\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "class", "btn btn-danger");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Models\Index.razor"
                                                                 () => Delete(model.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(24, "<span class=\"oi oi-delete\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Models\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Models\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Models\Index.razor"
       
    private List<Model> Model;

    protected async override Task OnInitializedAsync()
    {
        Model = await _client.GetFromJsonAsync<List<Model>>(Endpoints.Models);
    }

    async Task Delete(int id)
    {
        var model = Model.First(m => m.Id == id);

        var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {model.Name}?");

        if (confirm)
        {
            await _client.DeleteAsync($"{Endpoints.Models}/{id}");
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
