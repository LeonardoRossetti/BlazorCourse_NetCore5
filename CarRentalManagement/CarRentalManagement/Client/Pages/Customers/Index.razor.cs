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
    public partial class Index : IDisposable
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        private List<Customer> Model;

        protected async override Task OnInitializedAsync()
        {
            _interceptor.MonitorEvent();
            Model = await _client.GetFromJsonAsync<List<Customer>>(ApiEndpoints.Customers);
        }

        async Task Delete(int id)
        {
            var customer = Model.First(m => m.Id == id);

            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {customer.TaxId}?");

            if (confirm)
            {
                _interceptor.MonitorEvent();
                await _client.DeleteAsync($"{ApiEndpoints.Customers}/{id}");
                await OnInitializedAsync();
            }
        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
