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

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class Create : IDisposable
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        Customer Customer = new Customer();

        protected async override Task OnInitializedAsync()
        {
        }

        private async Task CreateCustomer()
        {
            _interceptor.MonitorEvent();
            await _client.PostAsJsonAsync(ApiEndpoints.Customers, Customer);
            _navManager.NavigateTo(PagePath.Customers);
        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
