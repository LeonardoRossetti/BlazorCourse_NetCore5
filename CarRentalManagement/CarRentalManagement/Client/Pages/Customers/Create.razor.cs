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

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class Create
    {
        [Inject] IHttpRepository<Customer> _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }
        [Inject] IJSRuntime js { get; set; }

        Customer Customer = new Customer();

        protected async override Task OnInitializedAsync()
        {
        }

        private async Task CreateCustomer()
        {
            await _client.Create(ApiEndpoints.Customers, Customer);
            _navManager.NavigateTo(PagePath.Customers);
        }
    }
}
