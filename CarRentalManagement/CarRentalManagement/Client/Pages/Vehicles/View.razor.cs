using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class View
    {
        [Inject] IHttpRepository<Vehicle> _client { get; set; }

        [Parameter] public int id { get; set; }
        Vehicle Vehicle = new Vehicle();

        protected async override Task OnParametersSetAsync()
        {
            Vehicle = await _client.GetDetails(ApiEndpoints.Vehicles, id);
        }
    }
}
