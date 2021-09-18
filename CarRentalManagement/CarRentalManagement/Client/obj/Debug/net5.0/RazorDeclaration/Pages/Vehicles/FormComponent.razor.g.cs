// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CarRentalManagement.Client.Pages.Vehicles
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
    public partial class FormComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 104 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
       
    [Parameter] public Vehicle Vehicle { get; set; }
    [Parameter] public string Title { get; set; } = "Form";
    [Parameter] public string ButtonText { get; set; } = "Save";
    [Parameter] public EventCallback OnValidSubmit { get; set; }
    [Parameter] public bool Disabled { get; set; } = false;

    private List<Make> Makes;
    private List<Model> Models;
    private List<Colour> Colors;
    string UploadFileWarning;

    List<string> AllowedImageExtensions = new List<string>() { ".jpg", ".jpeg", ".png" };

    private async void HandleFileSelection(InputFileChangeEventArgs e)
    {
        var file = e.File;
        if (file != null)
        {
            var ext = System.IO.Path.GetExtension(file.Name);
            if (AllowedImageExtensions.Contains(ext.ToLower()))
            {
                var picId = Guid.NewGuid().ToString().Replace("-", "");
                Vehicle.ImageName = $"{picId}{ext}";
                Vehicle.Image = new byte[file.Size];
                await file.OpenReadStream().ReadAsync(Vehicle.Image);
                UploadFileWarning = string.Empty;
            }
            else
            {
                UploadFileWarning = "Please select a valid image file (*.jpg | *.png)";
            }
        }
    }

    protected async override Task OnInitializedAsync()
    {
        Makes = await _client.GetFromJsonAsync<List<Make>>($"{ApiEndpoints.Makes}");
        Models = await _client.GetFromJsonAsync<List<Model>>($"{ApiEndpoints.Models}");
        Colors = await _client.GetFromJsonAsync<List<Colour>>($"{ApiEndpoints.Colours}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _client { get; set; }
    }
}
#pragma warning restore 1591
