#pragma checksum "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Colours\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81c0a663ca9d6f95a9db7d5f5e73f9df02cab98f"
// <auto-generated/>
#pragma warning disable 1591
namespace CarRentalManagement.Client.Pages.Colours
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
#line 1 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Colours\Index.razor"
           [Route("/" + PagePath.Colours)]

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Colours\Index.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"card-title\">Colours</h3>\r\n\r\n");
            __builder.OpenElement(1, "a");
            __builder.AddAttribute(2, "href", (
#nullable restore
#line 6 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Colours\Index.razor"
          PagePath.Colours

#line default
#line hidden
#nullable disable
            ) + "/create");
            __builder.AddAttribute(3, "class", "btn btn-secondary");
            __builder.AddMarkupContent(4, "<span class=\"oi oi-plus\"></span>\r\n    Create New Color\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n<hr>\r\n<br>");
#nullable restore
#line 13 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Colours\Index.razor"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<div class=\"alert alert-info\">Loading Colours...</div>");
#nullable restore
#line 16 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Colours\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "<thead><tr><th>Name</th>\r\n                <th>Actions</th></tr></thead>\r\n        ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 27 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Colours\Index.razor"
             foreach (var colour in Model)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 30 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Colours\Index.razor"
                         colour.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
            __builder.OpenElement(16, "a");
            __builder.AddAttribute(17, "href", "/" + (
#nullable restore
#line 32 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Colours\Index.razor"
                                   PagePath.Colours

#line default
#line hidden
#nullable disable
            ) + "/view/" + (
#nullable restore
#line 32 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Colours\Index.razor"
                                                          colour.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "class", "btn btn-primary");
            __builder.AddMarkupContent(19, "<span class=\"oi oi-book\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "href", "/" + (
#nullable restore
#line 35 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Colours\Index.razor"
                                   PagePath.Colours

#line default
#line hidden
#nullable disable
            ) + "/edit/" + (
#nullable restore
#line 35 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Colours\Index.razor"
                                                          colour.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "class", "btn btn-warning");
            __builder.AddMarkupContent(24, "<span class=\"oi oi-pencil\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "btn btn-danger");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Colours\Index.razor"
                                                                 () => Delete(colour.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(29, "<span class=\"oi oi-delete\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Colours\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Colours\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
