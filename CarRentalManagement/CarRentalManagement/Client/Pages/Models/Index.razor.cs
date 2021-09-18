using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Models
{
    public partial class Index
    {
        [Inject] IHttpRepository<Model> _client { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private IList<Model> Model;

        protected async override Task OnInitializedAsync()
        {
            Model = await _client.GetAll(ApiEndpoints.Models);
        }

        async Task Delete(int id)
        {
            var model = Model.First(m => m.Id == id);

            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {model.Name}?");

            if (confirm)
            {
                await _client.Delete(ApiEndpoints.Models, id);
                await OnInitializedAsync();
            }
        }
    }
}
