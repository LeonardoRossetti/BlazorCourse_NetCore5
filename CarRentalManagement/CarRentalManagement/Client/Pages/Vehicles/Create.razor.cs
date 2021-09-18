using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class Create
    {
        [Inject] IHttpRepository<Vehicle> _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }
        [Inject] IJSRuntime js { get; set; }

        Vehicle Vehicle = new Vehicle();

        private async Task CreateVehicle()
        {
            await _client.Create(ApiEndpoints.Vehicles, Vehicle);
            _navManager.NavigateTo(PagePath.Vehicles);
        }
    }
}
