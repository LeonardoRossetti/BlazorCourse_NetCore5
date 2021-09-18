using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Models
{
    public partial class Create
    {
        [Inject] IHttpRepository<Model> _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }
        [Inject] IJSRuntime js { get; set; }

        Model Model = new Model();

        protected async override Task OnInitializedAsync()
        {
        }

        private async Task CreateModel()
        {
            await _client.Create(ApiEndpoints.Models, Model);
            _navManager.NavigateTo(PagePath.Models);
        }
    }
}
