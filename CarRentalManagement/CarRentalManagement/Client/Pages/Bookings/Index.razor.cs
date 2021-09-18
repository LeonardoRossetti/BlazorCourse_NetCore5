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

namespace CarRentalManagement.Client.Pages.Bookings
{
    public partial class Index : IDisposable
    {
        [Inject] IHttpRepository<Booking> _client { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private IList<Booking> Model;

        private string _tableId = "bookingsTable";

        protected async override Task OnInitializedAsync()
        {
            Model = await _client.GetAll(ApiEndpoints.Bookings);
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            await js.InvokeVoidAsync("AddDataTable", "#"+ _tableId);
        }

        void IDisposable.Dispose()
        {
            js.InvokeVoidAsync("DataTablesDispose", "#" + _tableId);
        }

        async Task Delete(int id)
        {
            var model = Model.First(m => m.Id == id);

            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {model.Customer.EmailAddress}?");

            if (confirm)
            {
                await _client.Delete(ApiEndpoints.Bookings, id);
                await OnInitializedAsync();
            }
        }
    }
}
