#pragma checksum "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d355d1fadf92e4575bd706308ee426f43b7925b"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "h3");
            __builder.AddAttribute(1, "class", "card-title");
            __builder.AddContent(2, 
#nullable restore
#line 3 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                        Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n<hr>\r\n<br>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                 Vehicle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                                         OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n    ");
                __builder2.OpenElement(12, "fieldset");
                __builder2.AddAttribute(13, "disabled", 
#nullable restore
#line 10 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                         Disabled

#line default
#line hidden
#nullable disable
                );
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.AddMarkupContent(16, "<label>Image (Optional):</label>\r\n            ");
                __builder2.OpenElement(17, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(18);
                __builder2.AddAttribute(19, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                                     HandleFileSelection

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n                ");
                __builder2.OpenElement(21, "p");
                __builder2.AddAttribute(22, "class", "text-danger");
                __builder2.AddContent(23, 
#nullable restore
#line 16 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                                        UploadFileWarning

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "<label>Make: </label>\r\n            ");
                __builder2.OpenElement(28, "div");
                __Blazor.CarRentalManagement.Client.Pages.Vehicles.FormComponent.TypeInference.CreateInputSelect_0(__builder2, 29, 30, "form-control", 31, 
#nullable restore
#line 22 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                                          Vehicle.MakeId

#line default
#line hidden
#nullable disable
                , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Vehicle.MakeId = __value, Vehicle.MakeId)), 33, () => Vehicle.MakeId, 34, (__builder3) => {
                    __builder3.AddMarkupContent(35, "<option value>Select Make</option>");
#nullable restore
#line 25 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                     if (Makes != null)
                    {
                        foreach (var make in Makes)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(36, "option");
                    __builder3.AddAttribute(37, "value", 
#nullable restore
#line 29 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                                            make.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(38, 
#nullable restore
#line 29 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                                                      make.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 30 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(39, "\r\n                ");
                __Blazor.CarRentalManagement.Client.Pages.Vehicles.FormComponent.TypeInference.CreateValidationMessage_1(__builder2, 40, 41, 
#nullable restore
#line 33 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                                        () => Vehicle.MakeId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n        ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group");
                __builder2.AddMarkupContent(45, "<label>Model: </label>\r\n            ");
                __builder2.OpenElement(46, "div");
                __Blazor.CarRentalManagement.Client.Pages.Vehicles.FormComponent.TypeInference.CreateInputSelect_2(__builder2, 47, 48, "form-control", 49, 
#nullable restore
#line 39 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                                          Vehicle.ModelId

#line default
#line hidden
#nullable disable
                , 50, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Vehicle.ModelId = __value, Vehicle.ModelId)), 51, () => Vehicle.ModelId, 52, (__builder3) => {
                    __builder3.AddMarkupContent(53, "<option value>Select Model</option>");
#nullable restore
#line 41 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                     if (Models != null)
                    {
                        foreach (var model in Models)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(54, "option");
                    __builder3.AddAttribute(55, "value", 
#nullable restore
#line 45 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                                            model.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(56, 
#nullable restore
#line 45 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                                                       model.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 46 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(57, "\r\n                ");
                __Blazor.CarRentalManagement.Client.Pages.Vehicles.FormComponent.TypeInference.CreateValidationMessage_3(__builder2, 58, 59, 
#nullable restore
#line 49 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                                        () => Vehicle.ModelId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n        ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-group");
                __builder2.AddMarkupContent(63, "<label>Color: </label>\r\n            ");
                __builder2.OpenElement(64, "div");
                __Blazor.CarRentalManagement.Client.Pages.Vehicles.FormComponent.TypeInference.CreateInputSelect_4(__builder2, 65, 66, "form-control", 67, 
#nullable restore
#line 55 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                                          Vehicle.ColourId

#line default
#line hidden
#nullable disable
                , 68, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Vehicle.ColourId = __value, Vehicle.ColourId)), 69, () => Vehicle.ColourId, 70, (__builder3) => {
                    __builder3.AddMarkupContent(71, "<option value>Select Color</option>");
#nullable restore
#line 57 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                     if (Colors != null)
                    {
                        foreach (var color in Colors)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(72, "option");
                    __builder3.AddAttribute(73, "value", 
#nullable restore
#line 61 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                                            color.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(74, 
#nullable restore
#line 61 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                                                       color.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 62 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(75, "\r\n                ");
                __Blazor.CarRentalManagement.Client.Pages.Vehicles.FormComponent.TypeInference.CreateValidationMessage_5(__builder2, 76, 77, 
#nullable restore
#line 65 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                                        () => Vehicle.ColourId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n        ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "form-group");
                __builder2.AddMarkupContent(81, "<label>Year: </label>\r\n            ");
                __builder2.OpenElement(82, "div");
                __Blazor.CarRentalManagement.Client.Pages.Vehicles.FormComponent.TypeInference.CreateInputNumber_6(__builder2, 83, 84, "form-control", 85, 
#nullable restore
#line 71 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                                          Vehicle.Year

#line default
#line hidden
#nullable disable
                , 86, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Vehicle.Year = __value, Vehicle.Year)), 87, () => Vehicle.Year);
                __builder2.AddMarkupContent(88, "\r\n                ");
                __Blazor.CarRentalManagement.Client.Pages.Vehicles.FormComponent.TypeInference.CreateValidationMessage_7(__builder2, 89, 90, 
#nullable restore
#line 72 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                                        () => Vehicle.Year

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n        ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "form-group");
                __builder2.AddMarkupContent(94, "<label>Licence Plate Number: </label>\r\n            ");
                __builder2.OpenElement(95, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(96);
                __builder2.AddAttribute(97, "class", "form-control");
                __builder2.AddAttribute(98, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 78 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                                        Vehicle.LicensePlateNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(99, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Vehicle.LicensePlateNumber = __value, Vehicle.LicensePlateNumber))));
                __builder2.AddAttribute(100, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Vehicle.LicensePlateNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(101, "\r\n                ");
                __Blazor.CarRentalManagement.Client.Pages.Vehicles.FormComponent.TypeInference.CreateValidationMessage_8(__builder2, 102, 103, 
#nullable restore
#line 79 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                                        () => Vehicle.LicensePlateNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n        ");
                __builder2.OpenElement(105, "div");
                __builder2.AddAttribute(106, "class", "form-group");
                __builder2.AddMarkupContent(107, "<label>Vehicle Identification Number: </label>\r\n            ");
                __builder2.OpenElement(108, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(109);
                __builder2.AddAttribute(110, "class", "form-control");
                __builder2.AddAttribute(111, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 85 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                                        Vehicle.Vin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(112, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Vehicle.Vin = __value, Vehicle.Vin))));
                __builder2.AddAttribute(113, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Vehicle.Vin));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(114, "\r\n                ");
                __Blazor.CarRentalManagement.Client.Pages.Vehicles.FormComponent.TypeInference.CreateValidationMessage_9(__builder2, 115, 116, 
#nullable restore
#line 86 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                                        () => Vehicle.Vin

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n        ");
                __builder2.OpenElement(118, "div");
                __builder2.AddAttribute(119, "class", "form-group");
                __builder2.AddMarkupContent(120, "<label>Daily Rate: </label>\r\n            ");
                __builder2.OpenElement(121, "div");
                __Blazor.CarRentalManagement.Client.Pages.Vehicles.FormComponent.TypeInference.CreateInputNumber_10(__builder2, 122, 123, "form-control", 124, 
#nullable restore
#line 92 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                                          Vehicle.RentalRate

#line default
#line hidden
#nullable disable
                , 125, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Vehicle.RentalRate = __value, Vehicle.RentalRate)), 126, () => Vehicle.RentalRate);
                __builder2.AddMarkupContent(127, "\r\n                ");
                __Blazor.CarRentalManagement.Client.Pages.Vehicles.FormComponent.TypeInference.CreateValidationMessage_11(__builder2, 128, 129, 
#nullable restore
#line 93 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                                        () => Vehicle.RentalRate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 97 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
     if (!Disabled)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(130, "button");
                __builder2.AddAttribute(131, "type", "submit");
                __builder2.AddAttribute(132, "class", "btn btn-success btn-block");
                __builder2.AddContent(133, 
#nullable restore
#line 99 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                                                                 ButtonText

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 100 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<CarRentalManagement.Client.Components.BackToList>(134);
                __builder2.AddAttribute(135, "Target", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 101 "C:\Users\Leonardo\source\repos\Blazor Course\BlazorCourse_NetCore5\CarRentalManagement\CarRentalManagement\Client\Pages\Vehicles\FormComponent.razor"
                         PagePath.Vehicles

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
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
namespace __Blazor.CarRentalManagement.Client.Pages.Vehicles.FormComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_10<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_11<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
