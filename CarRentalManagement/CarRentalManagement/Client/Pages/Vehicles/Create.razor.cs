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

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class Create : IDisposable
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        Vehicle Vehicle = new Vehicle();

        private async Task CreateVehicle()
        {
            _interceptor.MonitorEvent();
            await _client.PostAsJsonAsync(ApiEndpoints.Vehicles, Vehicle);
            _navManager.NavigateTo(PagePath.Vehicles);
        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
