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
    public partial class Create
    {
        [Inject] IHttpRepository<Booking> _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }
        [Inject] IJSRuntime js { get; set; }

        Booking Booking = new Booking()
        {
            DateOut = DateTime.Now.Date
        };

        private async Task CreateBookings()
        {
            await _client.Create(ApiEndpoints.Bookings, Booking);
            _navManager.NavigateTo(PagePath.Bookings);
        }
    }
}
