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

namespace CarRentalManagement.Client.Pages.Colours
{
    public partial class Index : IDisposable
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        private List<Colour> Model;

        protected async override Task OnInitializedAsync()
        {
            _interceptor.MonitorEvent();
            Model = await _client.GetFromJsonAsync<List<Colour>>(ApiEndpoints.Colours);
        }

        async Task Delete(int id)
        {
            var model = Model.First(m => m.Id == id);

            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {model.Name}?");

            if (confirm)
            {
                _interceptor.MonitorEvent();
                await _client.DeleteAsync($"{ApiEndpoints.Colours}/{id}");
                await OnInitializedAsync();
            }
        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
