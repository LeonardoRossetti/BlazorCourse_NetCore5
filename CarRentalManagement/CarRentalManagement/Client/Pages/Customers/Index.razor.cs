using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class Index 
    {
        [Inject] IHttpRepository<Customer> _client { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private IList<Customer> Model;

        protected async override Task OnInitializedAsync()
        {
            Model = await _client.GetAll(ApiEndpoints.Customers);
        }

        async Task Delete(int id)
        {
            var customer = Model.First(m => m.Id == id);

            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {customer.TaxId}?");

            if (confirm)
            {
                await _client.Delete(ApiEndpoints.Customers, id);
                await OnInitializedAsync();
            }
        }
    }
}
