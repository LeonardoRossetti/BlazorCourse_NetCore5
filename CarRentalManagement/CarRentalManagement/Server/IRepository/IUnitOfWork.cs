using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Make> MakesRepository { get; }
        IGenericRepository<Model> ModelRepository { get; }
        IGenericRepository<Vehicle> VehicleRepository { get; }
        IGenericRepository<Booking> BookingRepository { get; }
        IGenericRepository<Colour> ColourRepository { get; }
        IGenericRepository<Customer> CustomerRepository { get; }
    }
}
