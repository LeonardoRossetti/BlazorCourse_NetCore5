using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Bookings
{
    public partial class View
    {
        [Inject] IHttpRepository<Booking> _client { get; set; }

        [Parameter] public int id { get; set; }
        Booking Booking = new Booking();

        protected async override Task OnParametersSetAsync()
        {
            Booking = await _client.GetDetails(ApiEndpoints.Bookings, id);
        }
    }
}
