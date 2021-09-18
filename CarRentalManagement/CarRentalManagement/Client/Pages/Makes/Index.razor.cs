using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Makes
{
    public partial class Index
    {
        [Inject] IHttpRepository<Make> _client { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private IList<Make> Model;

        protected async override Task OnInitializedAsync()
        {
            Model = await _client.GetAll(ApiEndpoints.Makes);
        }

        async Task Delete(int id)
        {
            var make = Model.First(m => m.Id == id);

            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {make.Name}?");

            if (confirm)
            {
                await _client.Delete(ApiEndpoints.Makes, id);
                await OnInitializedAsync();
            }
        }
    }
}
