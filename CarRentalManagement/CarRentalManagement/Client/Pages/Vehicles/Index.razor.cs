using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class Index
    {
        [Inject] IHttpRepository<Vehicle> _client { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private IList<Vehicle> Model;

        protected async override Task OnInitializedAsync()
        {
            Model = await _client.GetAll(ApiEndpoints.Vehicles);
        }

        async Task Delete(int id)
        {
            var model = Model.First(m => m.Id == id);

            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {model.Model.Name}?");

            if (confirm)
            {
                await _client.Delete(ApiEndpoints.Vehicles, id);
                await OnInitializedAsync();
            }
        }
    }
}
